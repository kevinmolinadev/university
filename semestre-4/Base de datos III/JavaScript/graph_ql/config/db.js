const {mongoose}=require("mongoose")
require("dotenv").config();

const connectionDB=async ()=>{
    try {
        await mongoose.connect(process.env.DB_MONGO);
        console.log("Conexion exitosa a la base de datos");
    }catch (e) {
        console.error(`Error: ${e}`);
        process.exit(1);
    }
}
module.exports = connectionDB;