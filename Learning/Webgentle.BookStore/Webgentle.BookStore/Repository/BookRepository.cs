using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webgentle.BookStore.Models;

namespace Webgentle.BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string title,string authorName)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(authorName)).ToList();
        }
        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id =1, Title="MVC", Author ="Nitish", Description="This is the description of the MVC book", Category="Programming", Language="English", TotalPages=134},
                new BookModel(){Id =2, Title="Dot Net Core", Author ="Nitish", Description="This is the description of the Dot net core book", Category="Framework", Language="Chinese", TotalPages=567},
                new BookModel(){Id =3, Title="Java", Author ="Monika", Description="This is the description of the java book", Category="Developer", Language="Hindi", TotalPages=897},
                new BookModel(){Id =4, Title="php", Author ="WebGentle", Description="This is the description of the php book", Category="Concept", Language="English", TotalPages=564},
                new BookModel(){Id =5, Title="vue", Author ="WebGentle", Description="This is the description of the vue book", Category="Programming", Language="English", TotalPages=100},
                new BookModel(){Id =5, Title="Azure devops", Author ="nitish", Description="This is the description of the azure devops book", Category="DevOps", Language="English", TotalPages=800},
            };
        }
    }
}
