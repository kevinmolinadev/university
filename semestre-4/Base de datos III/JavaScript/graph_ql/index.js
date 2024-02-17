const {ApolloServer} = require("apollo-server");
const connectionDB = require("./config/db");
const typeDefs = require("./db/schemas");
const resolvers = require("./db/resolvers");
const jwt = require('jsonwebtoken');


//Iniciar la base de datos
connectionDB();

//Preparamos el servidor GraphQL
const server = new ApolloServer({
    typeDefs,
    resolvers,
    context:({req})=>{
        const token=req.headers["authorization"] || "";
        //Veificar si el token es válido
        if (token) {
            try {
                return jwt.verify(token, process.env.SECRET_KEY);
            } catch (error){
                console.log('Hubo un error al validar el token!!!');
                console.log(error);
            }
        }
    }
});

//Levantar servidor
server.listen().then(({ url }) => console.log(`Server running at: ${url}`));
