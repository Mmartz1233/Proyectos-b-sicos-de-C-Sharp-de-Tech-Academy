using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        
        {
           // var nombre = (from e in db.Insurees where e.DateOfBirth > DateTime.Now).ToList();

            return View(db.Insurees.ToList());
        }
     


        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
           

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create() //esta solo me lanza a la vista crear 
        {
          
            return View();
        }

        // POST: Insuree/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingeTickets,CoverageType,Quote")] Insuree insuree)
        { //oportunidad de 
            
            if (ModelState.IsValid)
            {  //Asignar valor a la base
                decimal bases = 50m;
                decimal cotizacion = insuree.Quote;//asignar valores a la variable cotizacion
                DateTime fechaNac = insuree.DateOfBirth;
                int anioAuto = insuree.CarYear;
                string marcaAuto = insuree.CarMake;
                string modeloAuto = insuree.CarModel;
                int multaAuto = insuree.SpeedingeTickets;
                bool DuiAuto = insuree.DUI;
                bool coberturaAuto = insuree.CoverageType;
                decimal edadValor = 0, valorAnioAuto = 0, valorMarcaModAuto = 0, valorMulta = 0, totalGeneral= 0;
                

              

                TimeSpan fechActual = DateTime.Now - fechaNac;
                int edad = DateTime.Today.AddTicks(-fechaNac.Ticks).Year - 1;
               if (edad < 18)
                {
                    edadValor = 100;
                } else if (edad > 19 && edad < 25)
                {
                    edadValor = 50;
                } else if (edad > 25)
                {
                    edadValor = 25.2m;
                }
                
               if (anioAuto < 2000)
                {
                    valorAnioAuto = 25;
                }else if (anioAuto > 2015)
                {
                    valorAnioAuto = 25;
                }else if (anioAuto > 2000 && anioAuto < 2015)
                {
                    valorAnioAuto = 0;
                }

               if (marcaAuto == "Porsche" || marcaAuto == "Porsche" && modeloAuto == "911 Carrera")
                {
                    valorMarcaModAuto = 50;
                }

                totalGeneral = edadValor + valorAnioAuto + valorMarcaModAuto;

               if (multaAuto >0 )
                {
                    totalGeneral = totalGeneral + (multaAuto * 10);
                    
                }
               if (DuiAuto == true)
                {
                    totalGeneral = totalGeneral * .25m + totalGeneral;
                }
               if (coberturaAuto == true)
                {
                    totalGeneral = totalGeneral * .50m + totalGeneral;
                }

                insuree.Quote = totalGeneral + bases;


                db.Insurees.Add(insuree);//agregan los datos a la base de datos
                db.SaveChanges();//guardar cambios
                return RedirectToAction("Index");//nombre de la view 
            }
            return View(insuree);
        }

        //CREO una vista administrador
        public ActionResult Administrador()
        {
            List<Insuree> listaAdmin = null;
            using (var db = new InsuranceEntities())
            {
                //1.	Muestre todas las cotizaciones emitidas, junto con el nombre, apellido y dirección de correo electrónico del usuario.
                listaAdmin = (from admin in db.Insurees
                              select new Insuree
                              {
                                  Quote = admin.Quote,
                                  FirstName = admin.FirstName,
                                  LastName = admin.LastName,
                                  EmailAddress = admin.EmailAddress
                              }).ToList();
            }
            return View(listaAdmin);
        }




        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingeTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}
