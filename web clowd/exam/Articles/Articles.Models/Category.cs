using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Articles.Models
{
    public class Category
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Article> Articles { get; set; }

        public Category()
        {
            this.Articles = new HashSet<Article>();
        }
    }
}
