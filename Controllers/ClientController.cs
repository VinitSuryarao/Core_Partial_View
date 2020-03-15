using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Partial_View.ViewModel;

namespace Partial_View.Controllers
{
    public class ClientController : Controller
    {
        [BindProperty]

        public ClientViewModel ClientViewModel { get; set; }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult OnSubmit()
        {
            return View();
        }
    }
}