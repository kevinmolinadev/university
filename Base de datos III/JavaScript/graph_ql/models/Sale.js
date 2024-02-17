const mongoose=require("mongoose");
const SaleSchema = mongoose.Schema({
    branch_id: {
        type: mongoose.Schema.Types.ObjectId,
        require: true,
        ref:'branchs'
    },
    quantity:{
        type:Number,
        require:true,
        trim:true,
    },
    price:{
        type:Number,
        require:true,
        trim:true,
    },
    amount:{
        type:Number,
        require:true,
        trim:true,
    },
    sale_date:{
        type:Date,
        default:Date.now()
    }
})
module.exports = mongoose.model("sales",SaleSchema);