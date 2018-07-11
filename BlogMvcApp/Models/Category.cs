using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogMvcApp.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string kategoriAdi { get; set; }

        public List<Blog> Bloglar { get; set; }
    }
}