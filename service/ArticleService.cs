using ApplicationCsharp.entity;

namespace ApplicationCsharp.service
{
    class ArticleService
    {
        public List<Article> GetKFirstArticles(List<Article> listArticles, int numberArticle)
        {
            if (listArticles.Count < numberArticle)
            {
                throw new ArgumentException("The number can't be superior of length of the array");
            }

            return listArticles.Take(numberArticle).ToList();
        }
    }
}
