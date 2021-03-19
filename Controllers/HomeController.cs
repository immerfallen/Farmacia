using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Farmacia.Models;

namespace Farmacia.Controllers
{
    public class HomeController : Controller
    {        

        public IActionResult Index(int id)
        {
            PedidoRepository pedirepo = new PedidoRepository();               
            id = 1;
            pedirepo.Lista(id);
                       
            return View();
        }
        
    }
}
