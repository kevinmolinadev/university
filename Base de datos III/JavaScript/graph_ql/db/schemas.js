//Definicion de tipos de schemas
const { gql } = require('apollo-server');

const tyeDefs = gql ` 
    type User {
        id: ID
        name: String
        last_name: String
        email: String
        date_created: String
    }
    
    type Token {
        token: String
    }
    
    type Product{
        id: ID
        name: String
        existence: Int
        price: Int
            
    }
    
    type Client{
        id: ID
        name: String
        last_name: String
        email: String
        seller: ID
    }

    input UserInput {
        name: String
        last_name: String
        email: String
        password: String
        
    }
    
    input AuthUser{
        email: String
        password: String
    }
    
    input ProductInput{
        name: String
        existence: Int
        price: Int
    }
    
    input ClientInput{
        name: String
        last_name: String
        email: String
        phone: String
    }    

    type Query {
        #Users
        getUser(token: String): User
        
        #Products
        getProduct(id: ID): Product
         
    }
    
    type Mutation {
        #User
        newUser(input: UserInput):User
        authUser(input: AuthUser): Token
        
        #Product
        newProduct(input: ProductInput): Product
        updateProduct(id:ID,input:ProductInput): String
        
        #Client
        newClient(input: ClientInput): Client
    }
`;

module.exports = tyeDefs;