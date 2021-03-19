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

        public IActionResult Index(ItemPedido ip)
        {
            ItemPedidoRepository itempedirepo = new ItemPedidoRepository();          
            
            ip.Medicamento = new Medicamento();
            ip.Pedido = new Pedido();   
            ip.Id = 1;
            ip.Medicamento.Id = 1;
            ip.Pedido.Id = 1;        
            ip.Quantidade = 3;

            itempedirepo.Cadastra(ip);
                       
            return View();
        }
        
    }
}
