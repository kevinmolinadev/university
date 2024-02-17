const mongoose=require("mongoose");
const ClientSchema = mongoose.Schema({
    name:{
        type:String,
        require:true,
        trim:true,
    },
    last_name:{
        type:String,
        require:true,
        trim:true,
    },
    company:{
        type:String,
        trim:true
    },
    email:{
        type:String,
        require:true,
        trim:true,
        unique:true
    },
    phone:{
        type:String,
        required:true
    },
    date_created:{
        type:Date,
        default:Date.now()
    },
    seller: {
        type: mongoose.Schema.Types.ObjectId,
        require: true,
        ref:'users'
    }
})
module.exports = mongoose.model("clients",ClientSchema);