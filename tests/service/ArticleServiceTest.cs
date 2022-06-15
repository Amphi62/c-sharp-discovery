using Xunit;
using ApplicationCsharp.builder;
using ApplicationCsharp.entity;
using ApplicationCsharp.service;

namespace ApplicationCsharp.tests.service
{
    public class ArticleServiceTest
    {
        private ArticleService ArticleService = new();
        private List<Article> ListArticles;

        public ArticleServiceTest()
        {
            ListArticles = ArticleBuilder.CreateListOfArticles();
        }

        [Fact]
        public void GetKFirstArticlesTest()
        {
            List<Article> get2FirstArticles = ArticleService.GetKFirstArticles(ListArticles, 2);
            Assert.Equal(2, get2FirstArticles.Count);
            Assert.Same(ListArticles[0], get2FirstArticles[0]);
            Assert.Same(ListArticles[1], get2FirstArticles[1]);

            // case error
            Assert.Throws<ArgumentException>(() => ArticleService.GetKFirstArticles(ListArticles, ListArticles.Count + 5));
        }

        private DateTime CreateDateTimeWithString(string stringFormat)
        {
            return DateTime.ParseExact(stringFormat, "yyyy-MM-dd HH:mm:ss", null);
        }
    }
}
