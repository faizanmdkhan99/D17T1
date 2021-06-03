using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace D17T1.Controllers
{
    public class Product : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public String SI(int id)
        {
            int rate = 5;
            int time = 2;
            int SI = (id * rate * time) / 100;
            return "Simple Interest is "+SI;
        }
    }
}
