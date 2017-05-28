﻿using Blog.Unit.Tests.Models;
using Blog.Unit.Tests.Pages.ReviewingArticle;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTests;
using UnitTests.Pages.CreateArticlePage;
using UnitTests.Pages.RegistrationPage;

namespace Blog.Unit.Tests
{
    [TestFixture]
    public class ReviewingArticle
    {
        private IWebDriver driver;

        [SetUp]
        public void Init()
        {
            this.driver = new ChromeDriver();
            this.driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void CleanUp()
        {
            this.driver.Quit();
        }

        [Test]
        [Author("Hristina Mineva")]
        public void CheckArticleIsCreated()
        {
            var email = "Katy" + DateTime.Now.Ticks + "@abv.bg";
            var registrationPage = new RegistrationPage(this.driver);
            var registrationUser = new RegisterUser(email, "Katy Perry", "0123456789", "0123456789");
            registrationPage.NavigateTo();

            registrationPage.FillRegistrationForm(registrationUser);

            var createdArticle = new CreateArticlePage(this.driver);

            var newArticle = new Article("Hello!", "I am new article!");

            createdArticle.CreateArticle(newArticle);

            createdArticle.AssertArticleIsCreated("The new article is visible!");
        }
    }
}
