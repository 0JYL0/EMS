//using EmployeeManagementSystem.Models;
//using EMS.DAL.Implementation;
//using EMS.DL;
//using EMS.MODEL.Models;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.Extensions.Logging;
//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Threading.Tasks;

//namespace EmployeeManagementSystem.Controllers
//{
//    public class HomeController : Controller
//    {
//        private readonly ILogger<HomeController> _logger;
//        private readonly EmployeesRepository employeesRepository;
        

//        public HomeController(ILogger<HomeController> logger, EmployeesRepository employeesRepository)
//        {
//            _logger = logger;
//            this.employeesRepository = employeesRepository;
//        }

//        public IActionResult Index()
//        {
//            return View();
//        }

//        public IActionResult Privacy()
//        {
//            return View();
//        }

//        public IActionResult Login(string usernm)
//        {
//            List<Authenticate> auth = new List<Authenticate>();

//            Authenticate authenticate = new Authenticate()
//            {
//                id = 1,
//                username = "jayal",
//                password = "123",
//            };

//            auth.Add(authenticate);

//            var validate = auth.Where(x => x.username == usernm).FirstOrDefault();

//            if(validate == null)
//            {
//                return View();
//            }
//            else
//            {
//                return View(auth);
//            }

            
//        }

//        //public IActionResult test(int id)
//        //{
//        //    var check = employeesRepository.GetAllEmployeeMappingDetails(id);

//        //    return View(check);
//        //}


//        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
//        public IActionResult Error()
//        {
//            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
//        }
//    }


//}
