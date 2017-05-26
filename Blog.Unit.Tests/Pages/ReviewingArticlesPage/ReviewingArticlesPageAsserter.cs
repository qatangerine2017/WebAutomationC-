﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Unit.Tests.Pages.ReviewingArticles
{
   public static class ReviewingArticlesPageAsserter
    {
        public static void AssertArticleIsCreated(this ReviewingArticlesPage article, string nameArticle)
        {
            Assert.IsNotEmpty(article.CreatedArticle.Text); 
        }
    }
}