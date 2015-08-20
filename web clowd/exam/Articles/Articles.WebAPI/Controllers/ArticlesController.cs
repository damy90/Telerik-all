using Articles.Data;
using Articles.Models;
using Articles.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNet.Identity;

namespace Articles.WebAPI.Controllers
{
    public class ArticlesController : BaseApiController
    {
        public ArticlesController(IArticlesData data)
            : base(data)
        {

        }

        [HttpPost]
        [Authorize]
        public IHttpActionResult Create(ArticleDataModel model)
        {
            var userID = this.User.Identity.GetUserId();
            var tags = GetTags(model);
            var category = GetCategory(model.Category);
            var article = new Article
            {
                Title = model.Title,
                Content = model.Content,
                DateCreated = DateTime.Now,
                CategoryID = category.ID,
                AuthorID = userID,
                Tags = tags
            };
            this.data.Articles.Add(article);
            this.data.SaveChanges();

            model.ID = article.ID;
            model.DateCreated = article.DateCreated;
            model.Tags = article.Tags.AsQueryable()
                .Select(TagDataModel.FromTag).ToArray();

            return Ok(model);
        }

        private ICollection<Tag> GetTags(ArticleDataModel model)
        {
            var titleTags = model.Title.Split(' ');
            var allTags = new HashSet<string>(titleTags);
            foreach (var modelTags in model.Tags)
            {
                allTags.Add(modelTags.Name);
            }

            var articleTags = new HashSet<Tag>();
            foreach (var tagName in model.Tags)
            {
                var tag = this.data.Tags
                    .All()
                    .FirstOrDefault(t => t.Name == tagName.Name);

                if (tag == null)
                {
                    tag = new Tag
                    {
                        Name = tagName.Name
                    };

                    this.data.Tags.Add(tag);
                    articleTags.Add(tag);
                }
            }


            return articleTags;
        }

        private Category GetCategory(string modelCategory)
        {
            var category = this.data.Categories
                .All()
                .FirstOrDefault(c => c.Name == modelCategory);

            if (category == null)
            {
                category = new Category
                {
                    Name = modelCategory
                };
                this.data.Categories.Add(category);
            }

            return category;
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            var articles = this.data.Articles.All().Take(10).Select(ArticleDataModel.FromArticle);
            return Ok(articles);
        }
    }
}
