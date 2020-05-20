using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Locate_closest_business.Models;
using System.Data;
using System.Data.SqlClient;

namespace Locate_closest_business.Controllers
{
    public class HomeController : Controller
    {
        string[] essentialServiceOptions = {
            "Agriculture, hunting, forestry, fishing",
            "Electricity, Gas, Water supply",
            "Manufacturing",
            "Construction and related services",
            "Wholesale, Retail trade, Spaza shops",
            "Information and Communication services",
            "Media and Entertainment",
            "Financial and Business services",
            "Accommodation for quarantine, essential services",
            "Food services (Deliveries)",
            "Transport, Storage, Communication services",
            "Mining and Quarrying",
            "Repair and Related Emergency services",
            "Supply Chain",
            "Health, Social and Personal services"
        };

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RegisterBusiness()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterBusiness(BusinessModel business)
        {
            if (ModelState.IsValid)
            {
                // System.Console.WriteLine("Model valid!");
                string CS = "data source=localhost\\SQLEXPRESS; database=EssentialBusinesses; integrated security=true;";
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand("spAddNewBusiness", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@FirstName", business.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", business.LastName);
                    cmd.Parameters.AddWithValue("@Email", business.Email);
                    cmd.Parameters.AddWithValue("@Phone", business.Phone);
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
            } else {
                // Todo: Model is invalid, do error handling
            }
            return RedirectToAction("RegisterBusiness");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
