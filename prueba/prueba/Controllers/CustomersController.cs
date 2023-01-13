using prueba.Models;
using prueba.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prueba.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = GetCustomers();

            var viewModel = new CustomerViewModel
            {
                Customers = customers
            };

            return View(viewModel);
        }

        public ActionResult Detail(int id)
        {

            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }
        
        List<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer { Name = "Juan Gimenez", Id = 1 },
                new Customer { Name = "Fatima chuli", Id = 2 }
            };
        }
    }
}