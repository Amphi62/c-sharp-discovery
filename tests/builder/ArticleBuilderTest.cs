using Xunit;
using ApplicationCsharp.entity;
using ApplicationCsharp.builder;

namespace ApplicationCsharp.tests.builder
{
    public class ArticleBuilderTest
    {
        [Fact]
        public void CreateListOfArticles()
        {
            List<Article> articles = ArticleBuilder.CreateListOfArticles();

            Assert.NotNull(articles);
            Assert.Equal(5, articles.Count());
        }
    }
}
