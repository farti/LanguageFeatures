using LanguageFeatures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            return "Przejście do adresu URL pokazującego przykład:";
        }

        public ViewResult AutoProperty()
        {
            // utworzenie nowego obiektu Product
            Product myProduct = new Product();

            // ustawienie wartości właściwości
            myProduct.Name = "Kajak";

            // odczytanie właściwości
            string productName = myProduct.Name;

            // wygenerowanie widoku
            return View("Result", (object)String.Format("Nazwa produktu: { 0}", productName));
        }
    }
}