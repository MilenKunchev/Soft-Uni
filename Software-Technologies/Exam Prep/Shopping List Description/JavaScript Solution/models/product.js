const Sequelize = require('sequelize');

module.exports = function(sequelize){

    const Product = sequelize.define("Product", {

    name: {
        type: Sequelize.TEXT,
            required: true,
            allowNull: false
    },

    priority: {
        type: Sequelize.INTEGER,
            required: true,
            allowNull: false
    },

    quantity: {
        type: Sequelize.INTEGER,
            required: true,
            allowNull: false
    },

    status: {
        type: Sequelize.TEXT,
            required: true,
            allowNull: false
    }

}, {
    timestamps: false
});

return Product;
};