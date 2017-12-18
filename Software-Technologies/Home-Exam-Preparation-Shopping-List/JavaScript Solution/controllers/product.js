const Product = require('../models/Product');

module.exports = {
	index: (req, res) => {
        Product.find({}).then(products => {
            res.render("product/index", {'entries': products});
        });
    	},
	createGet: (req, res) => {
        res.render("product/create");
	},
	createPost: (req, res) => {
        let productArguments = req.body;

        Product.create(productArguments).then(res.redirect('/'))
	},
	editGet: (req, res) => {
        let productId = req.params.id;

        Product.findById(productId).then(product => {
            res.render('product/edit', product)
        })
	},
	editPost: (req, res) => {
        let productId = req.params.id;

        let productArguments = req.body;

        Product.findByIdAndUpdate(productId, productArguments).then(product => {
            res.redirect('/');
        })
	}
};