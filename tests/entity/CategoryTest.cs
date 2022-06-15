using Xunit;
using ApplicationCsharp.entity;
using ApplicationCsharp.builder;
using ApplicationCsharp.exception;

namespace ApplicationCsharp.tests.entity
{
    public class CategoryTest
    {
        private Category _category;
        private List<Article> ListArticles = ArticleBuilder.CreateListOfArticles();

        public CategoryTest()
        {
            _category = new Category("My category");
        }

        [Fact]
        public void AddArticleTest()
        {
            Assert.Empty(_category.ListArticles); // size = 0 for collection, use Assert.Empty for collection with > 1 element (NotEmpty also exist)
            _category.AddArticle(ListArticles[0]);
            Assert.Single(_category.ListArticles); // size = 1 for collection
        }

        [Fact]
        public void AddArticleWithListTest()
        {
            Assert.Empty(_category.ListArticles);
            _category.AddArticle(ListArticles);
            Assert.Equal(5, _category.ListArticles.Count);
        }

        [Fact]
        public void RemoveArticleByArticleTest()
        {
            _category.AddArticle(ListArticles);

            _category.RemoveArticle(ListArticles[2]);
            Assert.Equal(4, _category.ListArticles.Count);
            Assert.DoesNotContain(ListArticles[2], _category.ListArticles);

            Assert.Throws<NotExistException>(() => _category.RemoveArticle(ListArticles[2]));
        }

        [Fact]
        public void RemoveArticleByIndexTest()
        {
            _category.AddArticle(ListArticles);

            _category.RemoveArticle(2);
            Assert.Equal(4, _category.ListArticles.Count);
            Assert.DoesNotContain(ListArticles[2], _category.ListArticles);

            Assert.Throws<IndexOutOfRangeException>(() => _category.RemoveArticle(4));
        }
    }
}
