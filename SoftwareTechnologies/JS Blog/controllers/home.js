const Article = require('../models').Article;
const User = require('../models').User;

module.exports = {
    index: (req, res) => {
        Article.findAll({limit: 6, include: [{
                model: User
            }]}).then(articles => {
                console.log(articles);
            res.render('home/index', {articles: articles});
        });
    }
};




