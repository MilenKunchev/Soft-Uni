const Report = require('../models').Report;

module.exports = {
    index: (req, res) => {
        Report.findAll().then(reports => {
            res.render("report/index", {"reports": reports});
        })
    },
    createGet: (req, res) => {
        res.render("report/create");
    },
    createPost: (req, res) => {
        let body = req.body;

        Report.create(body).then(() => {
            res.redirect("/");
        }).catch(err => {
            console.log(err.message);
        })
    },
    detailsGet: (req, res) => {

        let id = req.params.id;

        Report.findById(id).then(report => {
            res.render("report/details", {
                "status": report.dataValues.status,
                "message": report.dataValues.message,
                "origin": report.dataValues.origin
            });
        })
    },
    deleteGet: (req, res) => {
        let id = req.params.id;

        Report.findById(id).then(report => {
            res.render("report/delete", {
                "status": report.dataValues.status,
                "message": report.dataValues.message,
                "origin": report.dataValues.origin
            });
        })
    },
    deletePost: (req, res) => {
        let id = req.params.id;

        Report.findById(id).then(report => {
            report.destroy().then(() => {
                res.redirect("/");
            })
        });
    }
};