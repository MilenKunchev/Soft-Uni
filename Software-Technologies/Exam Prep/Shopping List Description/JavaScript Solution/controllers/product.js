const Product = require('../models').Product;

module.exports = {
	index: (req, res) => {

        Product.findAll().then(products => {
            res.render("product/index", {"entries": products});
        })


},

	createGet: (req, res) => {

        res.render("product/create");
	},

	createPost: (req, res) => {

        let body = req.body;

        Product.create(body).then(() => {
            res.redirect("/");
        }).catch(err => {
            console.log(err.message);
        })
	},

	editGet: (req, res) => {

        let id = req.params.id;

        Product.findById(id).then(product => {
            res.render("product/edit", product.dataValues);
        }).catch(err => {
            console.log(err.message);
        })

	},

	editPost: (req, res) => {

        let id = req.params.id;
        //console.log(id);
        let body = req.body;
        //console.log(body);

        Product.findById(id).then(product => {
            product.updateAttributes(body).then(() =>{
                res.redirect("/" );
            });
        })
	}
};