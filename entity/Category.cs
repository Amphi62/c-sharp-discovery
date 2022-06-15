using ApplicationCsharp.exception;

namespace ApplicationCsharp.entity
{
    internal class Category
    {
        public string Name { get; set; }

        public List<Category> SubCategories { get; set; } = new List<Category>();

        public List<Article> ListArticles { get; set; } = new List<Article>();

        public int order { get; set; }

        public Category(string Name)
        {
            this.Name = Name;

        }
       
        public void AddArticle(Article article)
        {
            this.ListArticles.Add(article);
        }

        public void AddArticle(List<Article> article)
        {
            this.ListArticles.AddRange(article);
        }

        public void RemoveArticle(Article article)
        {
            if (!this.ListArticles.Contains(article))
            {
                throw new NotExistException();
            }

            this.ListArticles.Remove(article);
            // other method (not util in this case) : this.ListArticles = this.ListArticles.FindAll(art => art.Id != article.Id);

        }

        public void RemoveArticle(int order)
        {
            if (order >= this.ListArticles.Count)
            {
                throw new IndexOutOfRangeException();
            }

            this.ListArticles.RemoveAt(order);
        }

        public void AddSubCategory(Category subCategory)
        {
            this.SubCategories.Add(subCategory);
        }

        public void removeSubCategory(Category subCategory)
        {
            this.SubCategories.Remove(subCategory);
        }
    }
}
