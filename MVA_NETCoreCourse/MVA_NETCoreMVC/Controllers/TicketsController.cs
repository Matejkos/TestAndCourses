using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVA_NETCoreMVC.Models;

namespace MVA_NETCoreMVC.Controllers
{
    public class TicketsController : Controller
    {
        public ActionResult Index()
        {
            var s = new Seat() { Location = "Orchestra", Price =300.00 };
            
            return View(s);
        }
    }
}