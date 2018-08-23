using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LibraryAppGCP.Models;

namespace LibraryAppGCP.Controllers
{
    public class BooksController : Controller
    {
        // GET: Books
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Instore()
        {
            BookRepo booksRepo = new BookRepo();
            List<Book> booksList = new List<Book>();
            booksList.Add(new Book { ID = 001, Name = "Linux World", Stream = "Computer Science", Location = "Shelf A" });
            booksList.Add(new Book { ID = 002, Name = "Windows World", Stream = "Computer Science", Location = "Shelf A" });
            booksList.Add(new Book { ID = 003, Name = "History of India", Stream = "History", Location = "Shelf C" });
            booksList.Add(new Book { ID = 004, Name = "What a Plant Knows", Stream = "Botany", Location = "Shelf D" });

            booksRepo.BookList = booksList;
            return View(booksRepo);
        }


    }
}