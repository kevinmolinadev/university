const mongoose=require("mongoose");
const BranchSchema = mongoose.Schema({
    name:{
        type:String,
        require:true,
        trim:true,
    },
    address:{
        type:String,
        require:true,
        trim:true,
    },
    phone:{
        type:String,
        required:true
    },
    date_created:{
        type:Date,
        default:Date.now()
    },
    user_id: {
        type: mongoose.Schema.Types.ObjectId,
        require: true,
        ref:'users'
    }
})
module.exports = mongoose.model("branchs",BranchSchema);