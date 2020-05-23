using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Locate_closest_business.Models;
using System.Collections.Generic; 
using System.Data;
using System.Data.SqlClient;

namespace Locate_closest_business.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Search(string searchOption)
        {
            return RedirectToAction("");
        }

        private BusinessManagementModel BusinessModelHelper()
        {
            BusinessManagementModel model = new BusinessManagementModel();
            model.NewBusiness = new BusinessModel();
            model.Businesses = new List<BusinessModel>();
            //TODO: populate list with their businesses
            return model;
        }

        public IActionResult RegisterBusiness()
        {
            return View(BusinessModelHelper());
        }

        [HttpPost]
        public IActionResult RegisterBusiness(BusinessModel business)
        {
            if (ModelState.IsValid)
            {
                string CS = "data source=localhost\\SQLEXPRESS; database=EssentialBusinesses; integrated security=true;";
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand("spAddNewBusiness", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@CompanyName", business.CompanyName);
                    cmd.Parameters.AddWithValue("@RegistrationNumber", business.RegistrationNumber);
                    cmd.Parameters.AddWithValue("@Category", business.Category);
                    cmd.Parameters.AddWithValue("@NumEmployees", business.NumEmployees);
                    cmd.Parameters.AddWithValue("@Address", business.Address);
                    cmd.Parameters.AddWithValue("@AddressTown", business.AddressTown);
                    cmd.Parameters.AddWithValue("@AddressLongitude", business.AddressLongitude);
                    cmd.Parameters.AddWithValue("@AddressLatitude", business.AddressLatitude);
                    cmd.ExecuteNonQuery();
                }
                ViewBag.SuccessfulSubmit = true;
                return RedirectToAction("Index");

            }

            BusinessManagementModel model = BusinessModelHelper();
            model.NewBusiness = business;
            return View(model);
        }  

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
