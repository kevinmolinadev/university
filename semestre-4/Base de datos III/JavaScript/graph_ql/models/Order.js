const mongoose = require('mongoose');

const OrderSchema = mongoose.Schema({
    items: {
        type: Array,
        require: true
    },
    total: {
        type: Number,
        require: true
    },
    client: {
        type:mongoose.Schema.Types.ObjectId,
        required: true,
        ref: 'clients'
    },
    seller: {
        type:mongoose.Schema.Types.ObjectId,
        required: true,
        ref: 'users'

    },
    status: {
        type: String,
        default : 'PENDIENTE'
    },
    date_created:{
        type:Date,
        default:Date.now()
    }

});

module.exports = mongoose.model('orders', OrderSchema);