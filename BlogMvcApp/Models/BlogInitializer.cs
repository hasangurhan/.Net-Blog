using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogMvcApp.Models
{
    public class BlogInitializer: DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            List<Category> kategoriler = new List<Category>()
            {
               new Category() {kategoriAdi = "C#"},
               new Category() {kategoriAdi = "asp .net mvc"},
               new Category() {kategoriAdi = "asp .net web form"},
               new Category() {kategoriAdi = "windows form"},
               
            };
            foreach (var item in kategoriler)
            {
                context.Kategoriler.Add(item);
            }
            context.SaveChanges();

            List<Blog> Bloglar = new List<Blog>()
            {
                new Blog() {Baslik ="a", Aciklama="sad",EklenmeTarihi=DateTime.Now,Anasayfa=true,Onay=true,Icerik="asdsad",Resim="1.jpg",CategoryId=1},
                new Blog() {Baslik ="b", Aciklama="sad",EklenmeTarihi=DateTime.Now,Anasayfa=false,Onay=true,Icerik="asdsad",Resim="1.jpg",CategoryId=1},
                new Blog() {Baslik ="c", Aciklama="sad",EklenmeTarihi=DateTime.Now,Anasayfa=false,Onay=true,Icerik="asdsad",Resim="1.jpg",CategoryId=1},
                new Blog() {Baslik ="d", Aciklama="sad",EklenmeTarihi=DateTime.Now,Anasayfa=true,Onay=true,Icerik="asdsad",Resim="1.jpg",CategoryId=1},
                new Blog() {Baslik ="e", Aciklama="sad",EklenmeTarihi=DateTime.Now,Anasayfa=false,Onay=true,Icerik="asdsad",Resim="1.jpg",CategoryId=1},
                new Blog() {Baslik ="f", Aciklama="sad",EklenmeTarihi=DateTime.Now,Anasayfa=true,Onay=true,Icerik="asdsad",Resim="1.jpg",CategoryId=1},
                new Blog() {Baslik ="g", Aciklama="sad",EklenmeTarihi=DateTime.Now,Anasayfa=false,Onay=true,Icerik="asdsad",Resim="1.jpg",CategoryId=1},
                new Blog() {Baslik ="h", Aciklama="sad",EklenmeTarihi=DateTime.Now,Anasayfa=true,Onay=true,Icerik="asdsad",Resim="1.jpg",CategoryId=1},
            };
            foreach (var item in Bloglar)
            {
                context.Bloglar.Add(item);
            }
            context.SaveChanges();
            base.Seed(context);
        }
    }
}