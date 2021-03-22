using Microsoft.AspNetCore.Mvc;
using Farmacia.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;

namespace Farmacia.Controllers
{
    public class MedicamentoController : Controller
    {
        public IActionResult Lista(){
            MedicamentoRepository medicamentoRepo = new MedicamentoRepository();
            List<Medicamento> medicamentos = medicamentoRepo.Lista();

            return View(medicamentos);
        }
        [HttpPost]
        public IActionResult AdicionaSacola(ItemPedido novoItem){
            List<ItemPedido> itemSacola = new List<ItemPedido>();
            string listaEmTexto = HttpContext.Session.GetString("sacola");
            if(!String.IsNullOrEmpty(listaEmTexto)){
                itemSacola = JsonConvert.DeserializeObject<List<ItemPedido>>(listaEmTexto);
            }
            itemSacola.Add(novoItem);
            listaEmTexto = JsonConvert.SerializeObject(itemSacola);
            HttpContext.Session.SetString("sacola", listaEmTexto);
            

                return RedirectToAction("Lista");
            }
    }
}