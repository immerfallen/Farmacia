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

        public IActionResult Index(Medicamento m)
        {
            MedicamentoRepository medirepo = new MedicamentoRepository();
            m.Nome = "Citalgina";
            m.Descricao = "Citalgina para dor de cabeça";
            m.Dosagem = "15ml/kg";
            m.QtdEstoque = 3;
            m.Valor = 15;
            medirepo.Cadastra(m);
                       
            return View();
        }
        
    }
}
