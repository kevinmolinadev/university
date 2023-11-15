//Definicion de tipos de schemas
const { gql } = require('apollo-server');

const tyeDefs = gql ` 
    
    #TYPES
    
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
    
    type Branch{
        id: ID
        name: String
        address: String
        phone: String
        date_created: String
        user_id: ID
    }

    type Sale {
        id: ID
        quantity: Int
        price: Int
        amount: Int
        sale_date: String
        branch_id: ID
    }
    
    type OrderItems {
        id: ID
        quantity: Int
    }

    type Order {
        id:ID
        items:[OrderItems]
        total: Float
        client: ID
        seller: ID
        date_created: String
        status: OrderStatus
    }
    
    type TopClient {
        total: Float
        client: [Client]
    }

    type TopSeller {
        total: Float
        seller: [User]
    }

    
    #INPUTS 
    
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
    
    input BranchInput{
        name: String
        address: String
        phone: String
    }    
    
    input SaleInput{
        quantity: Int
        price: Int
        amount: Int
        branch: ID
    }
    
    input OrderItemInput {
        id: ID
        quantity: Int
    }
    
    input OrderInput {
        items:[OrderItemInput]
        client:ID
        status: OrderStatus        
    }
   
    enum OrderStatus{
        PENDIENTE
        COMPLETADO
        RECHAZADO
    }
    
    type Query {
        #Users
        getUser(token: String): User
        
        #Products
        getProduct(id: ID): Product
        
        #Branchs
        getBranch(id: ID): Branch
        
        #Sales
        getSale(id:ID):Sale
        
        #Orders
        getOrders: [Order]
        getSellerOrders: [Order]
        getOrderById(id: ID): Order
        getOrdersByStatus(status: String!): [Order]

        #Top
        topClients: [TopClient]
        topSellers: [TopSeller]
        searchProducts(text: String!): [Product]
         
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
        
        #Branch
        newBranch(input: BranchInput): Branch
        updateBranch(id:ID,input:BranchInput):String
        deleteBranch(id:ID): String
        
        #Sale
        newSale(input: SaleInput): Sale
        updateSale(id:ID,input:SaleInput):String
        deleteSale(id:ID): String
        
        #Order
        newOrder(input: OrderInput):Order
        updateOrder(id: ID!, input: OrderInput):Order
        deleteOrder(id: ID!): String
    }
`;

module.exports = tyeDefs;