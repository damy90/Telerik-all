﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Articles.Models
{
    public class Tag
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Article> Articles { get; set; }

        public Tag()
        {
            this.Articles = new HashSet<Article>();
        }
    }
}
