using ApplicationCsharp.entity;

namespace ApplicationCsharp.builder
{
    internal class ArticleBuilder: JsonBuilder<List<Article>>
    {
        public static List<Article> CreateListOfArticles()
        {
            return Build("article");
        }
    }
}
