using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCsharp.entity
{
    internal class Article
    {
        public User User { get; set; }

        public string Title { get; set; }   

        public string Description { get; set; }

        public DateTime CreatedDate { get; set; }

        public Article(User User, string Title, string Description, DateTime CreatedDate)
        {
            this.User = User;
            this.Title = Title;
            this.Description = Description;
            this.CreatedDate = CreatedDate;
        }

        public override string ToString()
        {
            return $"- {Title} ({Description}) écrit le {CreatedDate} par {User.Username} ({User.Email})";
        }
    }
}
