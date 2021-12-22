# Proyectos-b-sicos-de-C-Sharp-de-Tech-Academy
Introduccion:En este repositorio se almacenaran algunos proyectos basicos de C#
Lenguaje: C#
Herramientas: IDE Visual estudio, GitHub, Share,  y mas..
# AppMVC
Es una aplicación MVC básica, que contiene:
se creo un proyecto Aplicación web ASP.NET (.NET Framework), de tipo MVC.
Automaticamente se cargaron las vistas y controladores correspondientes.
Se modificaron las etiquetas de las vista para personalizarlo.
Se agrego una etiqueta de tipo DataTime, en la que se visualiza la fecha de la ultima actualizacion
Se pasaron parametros atravez de la URL.
Se agrego una nueva vista
Se agregaron las propiedades en el Modelo.
En el Home controller se asignaron valores a las propiedades, atravez de un constructor
Y finalmente se mostraron en pantalla por medio de una Vista.
Se creo un nuevo controlador con su respectiva vista.
 
# AsignacionInterfaz
Se Creo una interfaz llamada IQuittable y haga que defina un método vacío llamado Quit ().
Haga que su clase de empleado del ejercicio anterior herede esa interfaz e implemente el método Quit () de la forma que elija. class Empleado : Person, IQuittable
Se utilizo polimorfismo para crear un objeto de tipo IQuittable y llame al método Quit () en él. Sugerencia: un objeto puede ser de un tipo de interfaz si implementa esa interfaz específica.
            
# BoletinInformativo
Se creo un CRUDE utilizando MVC de la manera mas generica.
Se establecio conexion con la Bdd.
Se insertaron registros en la Bdd.
Se editaron los registros en la BDD.
Se creo un metodo para poder eliminar datos de la BDD.

# CarInsurance
Se completaron estas acciones:
Open Visual Studio and click File > New > Project.
Select Visual C# > ASP.NET Web Application (.NET Framework).
Name the project "CarInsurance", then click OK.
Select the MVC template, then click OK.
In the Solution Explorer, right click the App_Data folder and select Add > New Item.
Select SQL Server Database and name your database “Insurance.mdf”, then click Add.
In the Solution Explorer, double click Insurance.mdf.
In the Server Explorer, under Insurance.mdf, right-click the Tables folder and select Add New Table.
Click Update, then click Update Database.
In the Solution Explorer, right click the Models folder and select Add > New Item.
Select ADO.NET Entity Data Model, name your data model “InsuranceEntities”, then click Add.
Select EF Designer from the database, then click Next.
Ensure that your data connection is to Insurance.mdf and that you're saving connection settings in Web.Config as “InsuranceEntities”, then click Next.
If prompted, select Entity Framework 6.x, then click Next.
Click Tables (and, if possible, Views and Stored Procedures and Functions), then click Finish.
Build the project (CTRL + SHIFT + B).
In the Solution Explorer, right click the Controllers folder and select Add > Controller.
Select MVC 5 Controller with views, using Entity Framework, then click Add.
From the Model class dropdown list, select Insuree (CarInsurance.Models).
From the Data context class dropdown list, select InsuranceEntities (CarInsurance.Models).
Change the controller name from “InsureesController” to “InsureeController”, then click Add.
Complete these actions:
Calculate a quote:
Start with a base of $50 / month.
If the user is 18 and under, add $100 to the monthly total.
If the user is between 19 and 25, add $50 to the monthly total.
If the user is over 25, add $25 to the monthly total.
If the car's year is before 2000, add $25 to the monthly total.
If the car's year is after 2015, add $25 to the monthly total.
If the car's Make is a Porsche, add $25 to the price.
If the car's Make is a Porsche and its model is a 911 Carrera, add an additional $25 to the price.
Add $10 to the monthly total for every speeding ticket the user has.
If the user has ever had a DUI, add 25% to the total.
If it's full coverage, add 50% to the total.
Create an Admin view for a site administrator. This page must:
Show all quotes issued, along with the user's first name, last name, and email address.
Email all database .mdf and .ldf files to an Instructor. These are located in your project’s app_data folder.

# EstudiantesFC
Entity Framework introdujo el enfoque Code-First con Entity Framework 4.1. Code-First es principalmente útil en el diseño controlado por dominios . En el enfoque Code-First, usted se enfoca en el dominio de su aplicación y comienza a crear clases para su entidad de dominio en lugar de diseñar su base de datos primero y luego crear las clases que coincidan con el diseño de su base de datos. La siguiente figura ilustra el enfoque de código primero.

# OperadoresMatematicos
Se creo una aplicacion en la que se utilizaron diferentes operadores Matematicos para realizar diferentes funciones.

# StringsFunctions
Se creo una aplicacion en la que se utilizaron diferentes funciones de string.
Se creo el metodo UperCase, LowerCase.
Se utilizaron tabuladores

# Switch
Se creo una apliacion en donde se utilizo la estructura de condicion Switch convinado con la estructura DO - WHILE

# arraysAndList
Create a console app that does/contains the following:
Create a one-dimensional Array of strings. Ask the user to select an index of the Array and then display the string at that index on the screen.
Create a one-dimensional Array of integers. Ask the user to select an index of the Array and then display the integer at that index on the screen.
Add in a message that displays when the user selects an index that doesn’t exist.
Create a list of strings. Ask the user to select an index of the list and then display the content at that index on the screen.
Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code. 


# asignacionComparacion
Se realizo una aplicacion en la que se utilizaron operadores de comparacion if else, para calcular los requerimientos de longitudes de paquetes

# asignacionConstructor
Se realizo una aplicacion en la que se utilizo la implementacion del uso de constructores parametrizados con uso de sobrecarga de metodos.

# asignacionEnums
Se creo una enumeración para los días de la semana con el metodo enum

# asignacionHerencia
Se crearon dos clases en la cual una de ellas es la clase padre y la clase hija es la que hereda las propiedades y metodos de la clase padre

# asignacionLamda
Se creo una aplicacion en la que se hace uso del las funciones Lamnda para donde se realiza una consulta para buscar nombres repetidos y el resultado de esta se pasa a una lista nueva

# asignacionMetodos
Se creo una aplicacion en la que se implementaron el uso de metodos para relaizar diferentes funciones.

# ejemplocClasesAbstractas
Se creo una clase abstracta en la que se le asignaron propiedades y una clase abstracta
