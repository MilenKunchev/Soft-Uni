const Sequelize = require('sequelize');

module.exports = function (sequelize) {
    const Report = sequelize.define("Report", {

        status: {
            type: Sequelize.TEXT,
            required: true,
            allowNull: false
        },

        message: {
            type: Sequelize.TEXT,
            required: true,
            allowNull: false
        },

        origin: {
            type: Sequelize.TEXT,
            required: true,
            allowNull: false
        }
    }, {
        timestamps: false
    });

    return Report;
};