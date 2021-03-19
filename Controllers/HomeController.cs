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

        public IActionResult Index(Pedido p)
        {
            PedidoRepository pedirepo = new PedidoRepository();
            p.Clinica = new Clinica();
            p.DataPedido = DateTime.Now;
            p.Entregue = true;
            p.Clinica.Id = 1;          
            
            pedirepo.Cadastra(p);
                       
            return View();
        }
        
    }
}
