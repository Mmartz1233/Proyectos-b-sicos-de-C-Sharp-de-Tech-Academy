using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;
using BoletinInformativo.Models;
using BoletinInformativo.ViewModels;


namespace BoletinInformativo.Controllers
{
    public class HomeController : Controller
         
    {
        //Creamos la cadena de conexion
        private readonly String cadenaconxion = @"Data Source=DESKTOP-ELMBP1R\SQLEXPRESS;Initial Catalog=BoletinInformativo;Integrated Security=True";
        
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(String firstname, String lastName, string emailAddress)
        {
            if(string.IsNullOrEmpty(firstname)|| string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
            {
                return View("~/Views/Shared/Error.cshtml");
            }else
            {
                //creamos la consulta
                string consultaConexion = @"INSERT  INTO Registros (FisrtName,LastNme,EmailAddress) VALUES (@FisrtName, @LastNme, @EmailAddress)";
                using (SqlConnection conexion =  new SqlConnection(cadenaconxion))
                {
                    //agregamos parametros 
                    SqlCommand command = new SqlCommand(consultaConexion, conexion);
                    command.Parameters.Add("@FisrtName",SqlDbType.VarChar);
                    command.Parameters.Add("@LastNme", SqlDbType.VarChar);
                    command.Parameters.Add("@EmailAddress", SqlDbType.VarChar);

                    //Asignamos parametros
                    command.Parameters["@FisrtName"].Value = firstname;
                    command.Parameters["@LastNme"].Value = lastName;
                    command.Parameters["@EmailAddress"].Value = emailAddress;

                    //Abrimos, executamos y cerramos la conexion
                    conexion.Open();
                    command.ExecuteNonQuery();
                    conexion.Close();

                }
                return View("Success");
            }
            
        }

        public ActionResult AdminVista()
        {
            string consulta = @"SELECT Id, FisrtName, LastNme, EmailAddress, SocialSecurityNumber from Registros";
            List<RegistroModel> sigupslista = new List<RegistroModel>();
            using (SqlConnection conexion1 = new SqlConnection(cadenaconxion))
            {
                SqlCommand comand = new SqlCommand(consulta, conexion1);
                conexion1.Open();
                SqlDataReader reader = comand.ExecuteReader();
                while (reader.Read())
                {
                    var signup = new RegistroModel();
                    signup.Id = Convert.ToInt32(reader["ID"]);
                    signup.FirstName = reader["FisrtName"].ToString();
                    signup.LastName = reader["LastNme"].ToString();
                    signup.EmailAddress = reader["EmailAddress"].ToString();
                    signup.SocialSecurityNumber = reader["SocialSecurityNumber"].ToString();
                    sigupslista.Add(signup);
                }
            }
            var adminLista = new List<SignUpVm>();
            
            foreach(var registros in sigupslista)
            {
                var registAdmin = new SignUpVm();
                registAdmin.FirstName = registros.FirstName;
                registAdmin.LastName = registros.LastName;
                registAdmin.EmailAddress = registros.EmailAddress;
                adminLista.Add(registAdmin);

            }


                return View(adminLista);
        }

       
    }
}