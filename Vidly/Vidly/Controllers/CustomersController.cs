using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index() 
        {
            var customers = new List<Customer>
            {
                new Customer { Name = "Juan Gimenez", Id = 1 },
                new Customer { Name = "Fatima chuli", Id = 2 }
            };

            var viewModel = new CustomerViewModel
            {
                Customers = customers
            };

            return View(viewModel);
        }
        
        public ActionResult Detail(int id) 
        {
            var customer = GetCustomer(id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

        public Customer GetCustomer(int id)
        {
            var customers = new List<Customer>
            {
                new Customer { Name = "Juan Gimenez", Id = 1 },
                new Customer { Name = "Fatima chuli", Id = 2 }
            };

            return customers.SingleOrDefault(c => c.Id == id);
        }
    }
}