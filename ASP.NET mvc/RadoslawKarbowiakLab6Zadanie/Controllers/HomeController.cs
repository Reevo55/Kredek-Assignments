using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RadoslawKarbowiakLab6Zadanie.Models;

namespace RadoslawKarbowiakLab6Zadanie.Controllers
{
    public class HomeController : Controller
    {
        ClientsArray clientsArray;

        /// <summary>
        /// Konstruktor
        /// </summary>
        public HomeController()
        {
            clientsArray = ClientsArray.GetInstance();

        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DefaultMenu()
        {
            return View();
        }
        /// <summary>
        /// Sluzy do wyswietlania strony z lista wszystkich klientow 
        /// </summary>
        /// <returns></returns>
        public IActionResult GetAllClients()
        {
            return View(clientsArray.clientViewModels);
        }



        /// <summary>
        /// Employee login
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult EmployeeLogin()
        {
            return View();
        }
        /// <summary>
        /// Employee menu
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult EmployeeLogin(EmployeeViewModel employeeViewModel)
        {
            TempData["Name"] = employeeViewModel.FirstName;

            return View("EmployeeMenu");
        }
        /// <summary>
        /// Do formy tworzenia nowych klientow
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult CreateClientForm()
        {
            return View();
        }
        /// <summary>
        /// Wyswietlenie kogo dodano
        /// </summary>
        /// <param name="formViewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult CreateClientForm(ClientViewModel formViewModel)
        {
            ClientViewModel client = formViewModel;
            clientsArray.Add(client); 
            ViewBag.Data =  " " + formViewModel.FirstName + " " + formViewModel.SecondName + " z rachunkiem: " + formViewModel.Bill;

            return View("ShowAddedClient");
        }

        /// <summary>
        /// Do usuwania klienta
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult DeleteClient()
        {
            return View();
        }

        /// <summary>
        /// Usuniecie
        /// </summary>
        /// <param name="formViewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult DeleteClient(ClientViewModel formViewModel)
        {
            ClientViewModel client = formViewModel;
            if (clientsArray.Contains(formViewModel))
            {
                clientsArray.Remove(client);
                ViewBag.Data = "Usunięto " + formViewModel.FirstName + " " + formViewModel.SecondName + " z rachunkiem: " + formViewModel.Bill;
            }
            else ViewBag.Data = " " + formViewModel.FirstName + " " + formViewModel.SecondName + " z rachunkiem: " + formViewModel.Bill + " nie ma go w spisie";

            return View("ShowDelietedClient");
        }


        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
