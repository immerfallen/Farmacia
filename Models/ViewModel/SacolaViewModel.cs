using System.Collections.Generic;

namespace Farmacia.Models.ViewModel
{
    public class SacolaViewModel
    {
        public List<Clinica> Clinicas { get; set; }
        public List<ItemPedido> Itens { get; set; }
        
        public int IdClinica { get; set; }
        
        
        
        
    }
}