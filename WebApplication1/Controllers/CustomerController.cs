using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            List<Customer> customers = new List<Customer>()
            {
                new Customer { Id = 1, Name = "maha" },
                new Customer { Id = 2, Name = " salem" },
                new Customer { Id = 3, Name = "amar" }
            };

            ViewData["data"] = customers;
            return View();
        }

        [HttpGet]
        public IActionResult CreateCustomer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCustomer(AddCustomerForm model)
        {
            var name = model.Name;
            var id = model.Id;
            Customer.Add(new Customer { Id = id, Name = name });
     

            return RedirectToAction("Index");
        }
    }
}