const Task = require('../models/Task');

module.exports = {
    index: (req, res) => {
        Task.find({}).then(tasks => {
            res.render("task/index", {tasks: tasks});
        });
    },
	createGet: (req, res) => {
        res.render("task/create");
	},
	createPost: (req, res) => {
        let taskArguments = req.body;

        Task.create(taskArguments).then(task => {
            res.redirect('/')
        })
	},
	deleteGet: (req, res) => {
        let taskId = req.params.id;

        Task.findById(taskId).then(task => {
            res.render('task/delete', task)
        })
	},
	deletePost: (req, res) => {
        let taskId = req.params.id;

        Task.findByIdAndRemove(taskId).then(task => {
            res.redirect('/');
        })
    }
};