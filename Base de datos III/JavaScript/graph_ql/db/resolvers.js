const User = require('../models/User');
const Product = require('../models/Product');
const Client = require('../models/Client');
const Branch = require('../models/Branch');
const Sale = require('../models/Sale');
const bcryptjs = require('bcryptjs');
const jwt = require('jsonwebtoken');

require("dotenv").config({path:"variables.env"});

const newToken = (user, secret_key, expiresIn) => {
    const { id, name, last_name, email, date_created } = user;
    return jwt.sign({ id, name, last_name, email, date_created }, secret_key, {expiresIn});
}

const resolvers = {
    Query: {
        getUser: async (_, { token }) => {
            return jwt.verify(token, process.env.SECRET_KEY);
            // const usuarioID = await jwt.verify(token, process.env.FIRMA_SECRETA);
            //return usuarioID;
        },
        getProduct:async (_, { id })=>{
            return Product.findOne({_id:id});
        },
        getBranch:async (_,{id})=>{
            try{
                const branch=await Branch.findById(id);
                if(branch) return branch;
                return "La sucursal no existe";
            }catch (e) {
                console.log(e);
            }
        },
        getSale:async (_,{id})=>{
            try{
                const sale=await Sale.findById(id);
                if(sale) return sale;
                return "La venta no existe";
            }catch (e) {
                console.log(e);
            }
        }
    },
    Mutation: {
        //USER
        newUser: async (_, {input}) => {
            //console.log(input);
            const {email, password} = input;
            //Verificar si el usuario ya existe
            const userExists = await User.findOne({email});
            if (userExists) {
                throw new Error(`El usuario con el correo ${email} ya fue registrado`);
            }
            //Hashear el password
            const salt = bcryptjs.genSaltSync(10);
            input.password = await bcryptjs.hash(password, salt);
            //Guardarlo en la Base de Datos
            try {
                const user = new User(input);
                await user.save();
                return user;
            } catch (error) {
                console.log(error)
            }
        },
        authUser: async (_, {input}) => {
            const {email, password} = input;
            //Verificar si el usuario con ese mail existe
            const userExists = await User.findOne({email});
            if (!userExists) {
                throw new Error(`El usuario con el correo ${email} no existe`);
            }
            //Verificar que el password sea correcto
            const isEqualPassword = await bcryptjs.compare(password, userExists.password);
            if (!isEqualPassword) {
                throw new Error('El password es incorrecto!!!');
            }
            //Crear el Token
            return {
                token: newToken(userExists, process.env.SECRET_KEY, 300000)
            }

        },
        //PRODUCT
        newProduct: async (_, {input}) => {
            console.log(input);
            try {
                const product = new Product(input);
                //Grabamos en la base de datos
                console.log(product.toString());
                return await product.save();
            } catch (error) {
                console.log('Hubo un error al registrar el producto!!!');
                console.log(error);
            }
        },
        updateProduct: async (_, {id, input}) => {
            try {
                const product = await Product.findById(id);
                if (product._id != null) {
                    await Product.updateOne({_id: id}, input)
                    return `El producto con id ${id} fue actulizado`;
                }
                return `El producto con id ${id} no existe`;
            } catch (error) {
                console.log(error);
            }
        },
        //CLIENT
        newClient: async (_, {input}, ctx) => {
            const {email} = input;
            try {
                const clientExists = await User.findOne({email});
                if (clientExists) throw new Error("El cliente ya existe");
                const client = new Client({...input, seller: ctx.id})
                return await client.save();
            } catch (e) {
                console.log('Hubo un error al registrar el cliente!!!');
                console.log(e);
            }
        },

        //BRANCH


        newBranch: async (_, {input}, ctx) => {
            try {
                if (ctx.id) {
                    const branch = new Branch({...input, user_id: ctx.id})
                    return await branch.save();
                }
            } catch (e) {
                console.log('Hubo un error al registrar el cliente!!!');
                console.log(e);
            }
        },
        updateBranch: async (_, {id, input}) => {
            try {
                const branch = await Branch.findById(id);
                if (branch._id != null) {
                    await Branch.updateOne({_id: id}, input);
                    return `La sucursal con el id ${id} fue actulizada`;
                }
                return `La sucursal con el id ${id} no existe`;
            } catch (e) {
                console.log(e)
            }
        },
        deleteBranch: async (_, {id}) => {
            try {
                const branch = await Branch.findById(id);
                if (branch._id != null) {
                    await Branch.deleteOne({_id: id});
                    return `La sucursal fue eliminado`;
                }
                return `La sucursal con el id ${id} no existe`;
            } catch (e) {
                console.log(e)
            }
        },


        //SALE

        newSale: async (_, {input}) => {
            const {branch:branch_id}=input;
            try {
                const branch = await Branch.findById(branch_id);
                if(branch){
                    const sale = new Sale({...input,branch_id:branch._id});
                    return await sale.save();
                }
                return "el id de la sucursal no existe";
            } catch (e) {
                console.log('Hubo un error al registrar el cliente!!!');
                console.log(e);
            }
        },
        updateSale: async (_, {id, input}) => {
            try {
                const sale = await Sale.findById(id);
                if (sale._id != null) {
                    await Sale.updateOne({_id: id}, input);
                    return `La venta con el id ${id} fue actulizada`;
                }
                return `La venta con el id ${id} no existe`;
            } catch (e) {
                console.log(e)
            }
        },
        deleteSale: async (_, {id}) => {
            try {
                const branch = await Sale.findById(id);
                if (branch._id != null) {
                    await Sale.deleteOne({_id: id});
                    return `La venta fue eliminado`;
                }
                return `La venta con el id ${id} no existe`;
            } catch (e) {
                console.log(e)
            }
        }
    }
}
module.exports =resolvers;