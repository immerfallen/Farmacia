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

            ItemPedido ip = new ItemPedido();
            
            ip.Quantidade = 3;  
            ip.Pedido = new Pedido();
            ip.Pedido.Id = 1;
            ip.Medicamento = new Medicamento();
            ip.Medicamento.Id = 1;
            ip.Medicamento.Nome = "Citalgina";
            ip.Medicamento.Valor = 15;

           

            ItemPedidoRepository itempedirepo = new ItemPedidoRepository();          
            id =7;
                       

            itempedirepo.Lista(id);
                       
            return View();
        }
        
    }
}
