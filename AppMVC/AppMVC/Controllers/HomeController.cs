using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Runtime;
using AppMVC.Models;
namespace AppMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact page - The Tehc Academy";

            return View();
        }
        //agregando metodos
        public ActionResult Instructor(int id = 0 ) //para imprimirlo es de la sig manera: https://localhost:44397/Home/Instructor
        {
            ViewBag.Id = id;
            Instructor dayTimeInstructor = new Instructor
            {
                Id = 1,
                Nombre = "Mayra",
                App = "Martz"

            };
            
            return View(dayTimeInstructor);
        }
        public ActionResult Instructores()
        {
            List<Instructor> instructors = new List<Instructor>
            {
                new Instructor
                {
                     Id = 1,
                    Nombre = "Erick",
                    App = "Gross"

                }, 
                new Instructor
                {
                     Id = 1,
                    Nombre = "Brett",
                     App = "Calendar"

                }, 
                new Instructor
                {
                     Id = 1,
                     Nombre = "Adam",
                     App = "Smithsonian"

                }
            };

            return View(instructors);
        }
    }
}