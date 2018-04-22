const Report = require('../models').Report;

module.exports = {
    index: (req, res) => {
        let reports = Report.findAll().then(reports=>{
            res.render("report/index", {"reports":reports})
        });
    },
    createGet: (req, res) => {
        res.render("report/create");
    },
    createPost: (req, res) => {
        let body = req.body;

        Report.create(body).then(() => {
            res.redirect("/");
        }).catch(err=>{
            console.log(err.message);
        })
    },
    detailsGet: (req, res) => {
        let id = req.params.id;

        Report.findById(id).then(report =>{
            res.render("report/details",{
                "status": report.status,
                "message": report.message,
                "origin": report.origin,
                "id": id});
        }).catch(err => {
            console.log(err.message);
        })
    },
    deleteGet: (req, res) => {
        let id = req.params.id;

        Report.findById(id).then(report =>{
            res.render("report/delete",{
                "status": report.status,
                "message": report.message,
                "origin": report.origin,
                "id": id});
            }).catch(err => {
                console.log(err.message);
        })
    },
    deletePost: (req, res) => {
        let id = req.params.id;

        Report.findById(id).then(report=>{
            report.destroy().then(()=>{
                res.redirect('/');
            })
        })
    }
};