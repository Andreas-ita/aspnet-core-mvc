using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Dynamic;
using Webgentle.BookStore.Models;

namespace Webgentle.BookStore.Controllers
{
    public class HomeController : Controller
    {
        [ViewData]
        public string CustomProperty { get; set; }

        [ViewData]
        public string Title { get; set; }

        [ViewData]
        public BookModel Book { get; set; }


        public ViewResult Index()
        {
            Book = new BookModel();
            Title = "Home page";
            Book.Id = 1;
            Book.Title = "Hello";
            return View();
        }
          
        public ViewResult AboutUs()
        {
            Title = "About us";
            return View();
        }

        public ViewResult ContactUs()
        {
            Title = "Contact us";
            return View();
        }
    }
}