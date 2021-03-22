using Microsoft.AspNetCore.Mvc;
using Farmacia.Models;
using System.Collections.Generic;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using System;
using Farmacia.Models.ViewModel;

namespace Farmacia.Controllers
{
    public class PedidoController : Controller
    {
        public IActionResult Sacola(){
            List<ItemPedido> itensSacola = new List<ItemPedido>();
            string listaEmTexto = HttpContext.Session.GetString("sacola");

            if(!String.IsNullOrEmpty(listaEmTexto)){
                itensSacola = JsonConvert.DeserializeObject<List<ItemPedido>>(listaEmTexto);            
            }
            MedicamentoRepository medicamentoRepo = new MedicamentoRepository();
            List<Medicamento> resultadoBusca;
            foreach(ItemPedido item in itensSacola){
                resultadoBusca = medicamentoRepo.Lista(item.Medicamento.Id);
                if(resultadoBusca != null && resultadoBusca.Count>0)
                    {
                        item.Medicamento = resultadoBusca[0];
                    } 
            }      
            ClinicaRepository clinicaRepo = new ClinicaRepository();
            List<Clinica> listaClinicas = clinicaRepo.Lista(0);

            SacolaViewModel sacola = new SacolaViewModel();
            sacola.Clinicas = listaClinicas;
            sacola.Itens = itensSacola;

            return View(sacola); 
                    
        }      

        [HttpPost]  
        public IActionResult FecharPedido(SacolaViewModel sacola){
            PedidoRepository pedidoRepo = new PedidoRepository();
            Pedido novoPedido = new Pedido();
            novoPedido.DataPedido = DateTime.Now;
            novoPedido.Clinica = new Clinica();
            novoPedido.Clinica.Id = sacola.IdClinica;
            novoPedido.Entregue = false;
            novoPedido.Id = pedidoRepo.Cadastra(novoPedido);

            ItemPedidoRepository itemPedidoRepo = new ItemPedidoRepository();
            foreach(ItemPedido item in sacola.Itens)
            {
                item.Pedido = novoPedido;
                itemPedidoRepo.Cadastra(item);
            }
            HttpContext.Session.Remove("sacola");
            
            return View();
        }

        public IActionResult Lista(){
            PedidoRepository pedidoRepo = new PedidoRepository();
            List<Pedido> pedidos = pedidoRepo.Lista();

            return View(pedidos);
        }

        public IActionResult Detalhe(int id){
            Pedido pedido = null;
            PedidoRepository pedidoRepo = new PedidoRepository();
            List<Pedido> pedidos = pedidoRepo.Lista(id);
            if(pedidos != null && pedidos.Count > 0)
            {
                pedido = pedidos[0];

                ClinicaRepository clinicaRepo = new ClinicaRepository();
                List<Clinica> clinicas = clinicaRepo.Lista(pedido.Clinica.Id);
                pedido.Clinica = clinicas[0];

                ItemPedidoRepository itemPedidoRepo = new ItemPedidoRepository();
                List<ItemPedido> itens = itemPedidoRepo.Lista(pedido.Id);
                pedido.Itens = itens;
            }
            return View(pedido);
        }      

    }
}