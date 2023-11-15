const User = require('../models/User');
const Product = require('../models/Product');
const Client = require('../models/Client');
const Branch = require('../models/Branch');
const Sale = require('../models/Sale');
const Order = require("../models/Order")
const bcryptjs = require('bcryptjs');
const jwt = require('jsonwebtoken');

require("dotenv").config({path:"variables.env"});

const getTotal=async (order)=> {
    //Verificar si la cantidad que el cliente esta pidiendo existe en inventario (stock)
    let total = 0;
    for (const article of order) {
        const { id } = article;
        const product = await Product.findById(id);
        if (Number(article.quantity) > Number(product.existence)) {
            throw new Error(`La cantidad del producto ${product.name} no existe en stock`);
        } else {
            product.existence -= Number(article.quantity);
            total += Number(product.price) * Number(article.quantity);
            if (!isNaN(total)) product.save();
        }
    }
    return total;
}

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
        },
        getOrders: async () => {
            try {
                return await Order.find();
            } catch (error) {
                console.log(error);
            }
        },
        getSellerOrders: async (_, {}, ctx) => {
            try {
                return await Order.find({ seller: ctx.id });
            } catch (error) {
                console.log(error);
            }
        },
        getOrderById: async (_, { id }, ctx) => {
            // Check if the order exists
            const order = await Order.findById(id);
            if (!order) {
                throw new Error('Order does not exist');
            }
            // Check if the order belongs to the seller
            if (order.seller.toString() !== ctx.id) {
                throw new Error('You do not have the credentials to perform this operation');
            }
            // Return the order
            return order;
        },
        getOrdersByStatus: async (_, { status }, ctx) => {
            try {
                return await Order.find({ seller: ctx.id, status });
            } catch (error) {
                console.log(error);
            }
        },

        // TOP
        topClients: async () => {
            const clients = await Order.aggregate([
                { $match: { status: "COMPLETADO" } },
                {
                    $group: {
                        _id: "$client",
                        total: { $sum: '$total' }
                    }
                },
                {
                    $lookup: {
                        from: 'clients',
                        localField: '_id',
                        foreignField: "_id",
                        as: "client"
                    }
                },
                {
                    $limit: 10
                },
                {
                    $sort: { total: -1 }
                }
            ]);

            return clients;
        },
        topSellers: async () => {
            const sellers = await Order.aggregate([
                { $match: { status: "COMPLETADO" } },
                {
                    $group: {
                        _id: "$seller",
                        total: { $sum: '$total' }
                    }
                },
                {
                    $lookup: {
                        from: 'users',
                        localField: '_id',
                        foreignField: '_id',
                        as: 'seller'
                    }
                },
                {
                    $limit: 3
                },
                {
                    $sort: { total: -1 }
                }
            ]);

            return sellers;
        },
        searchProducts: async (_, { text }) => {
            const products = await Product.find({ $text: { $search: text } }).limit(10)
            return products;
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
                console.log(error);
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
                console.log(e);
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
                console.log(e);
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
                console.log(e);
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
                console.log(e);
            }
        },

        //ORDER

        newOrder: async (_, { input }, ctx) => {
            const { client } = input;
            //Verificar si el cliente que esta haciendo el pedido existe
            const clientExists = await Client.findById(client);
            if (!clientExists) {
                throw new Error('Cliente no existe');
            }

            //Verificar si el cliente pertenece al vendedor en curso
            if (clientExists.seller.toString() !== ctx.id) {
                throw new Error('No tiene las credenciales para realizar esta operación');
            }
            //Crear el nuevo pedido
            const order = new Order(input);
            //Asignar el vendedor a ese pedido
            order.seller = ctx.id;
            //Obtenemos el total del pedido
            order.total = await getTotal(input.items);
            //Grabar el Pedido
            return await order.save();
        },
        updateOrder: async (_, { id, input }, ctx) => {
            //Verificar si el pedido existe
            const orderExists = await Order.findById(id);
            if (!orderExists) {
                throw new Error('Pedido no existe');
            }
            //Verificar si el cliente que esta haciendo el pedido existe
            const clientExists = await Client.findById(input.client);
            if (!clientExists) {
                throw new Error('Cliente no existe');
            }

            //Verificar si el cliente pertenece al vendedor en curso
            if (clientExists.seller.toString() !== ctx.id) {
                throw new Error('No tiene las credenciales para realizar esta operación');
            }

            //Obtenemos el total del pedido
            const totalUpdate = await getTotal(input.items);

            //Guardar el pedido a actualizar
            return Order.findOneAndUpdate({ _id: id }, { ...input, total: totalUpdate }, { new: true });
        },
        deleteOrder: async (_, { id }, ctx) => {
            //Verificar si el pedido existe
            const orderExists = await Order.findById(id);
            if (!orderExists) {
                throw new Error('Pedido no existe');
            }
            //Verificar si el cliente pertenece al vendedor en curso
            if (orderExists.seller.toString() !== ctx.id) {
                throw new Error('No tiene las credenciales para realizar esta operación');
            }
            //Eliminamos el pedido de la base de datos
            await Order.findOneAndDelete({ _id: id });
            return "El pedido fue eliminado!!!";
        }

    }
}
module.exports =resolvers;