using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace Farmacia.Models
{
    public class ItemPedidoRepository : Repository
    {
        public void Cadastra(ItemPedido ip){
            conexao.Open();            
            string sql = "INSERT INTO itempedido (id_pedido, id_medicamento, quantidade) VALUE (@id_pedido, @id_medicamento, @quantidade)";
            MySqlCommand comando = new MySqlCommand(sql,conexao);
            comando.Parameters.AddWithValue("@id_pedido",ip.Pedido.Id);
            comando.Parameters.AddWithValue("@id_medicamento",ip.Medicamento.Id);
            comando.Parameters.AddWithValue("@quantidade",ip.Quantidade);

            comando.ExecuteNonQuery();
            

            conexao.Close();
           
        }

        public List<ItemPedido> Lista(int idPedido){
            conexao.Open();
            string sql = "SELECT ip.id as IdItemPedido, ip.id_pedido, ip.quantidade, m.id as IdMedicamento, m.nome, m.valor FROM itempedido ip JOIN medicamentos m ON ip.id_medicamento = m.id WHERE id_pedido = @idPedido"; 
            MySqlCommand comandoQuery = new MySqlCommand(sql,conexao);            
            comandoQuery.Parameters.AddWithValue("@idPedido", idPedido);            
            MySqlDataReader reader = comandoQuery.ExecuteReader();

            List<ItemPedido> lista = new List<ItemPedido>();

            while (reader.Read()){
                ItemPedido itempedido = new ItemPedido();
                itempedido.Id = reader.GetInt32("IdItemPedido");
                itempedido.Quantidade = reader.GetInt32("quantidade");
                                
                itempedido.Medicamento = new Medicamento();
                itempedido.Medicamento.Id = reader.GetInt32("IdMedicamento");

                if(!reader.IsDBNull(reader.GetOrdinal("nome")))
                itempedido.Medicamento.Nome = reader.GetString("nome");

                if(!reader.IsDBNull(reader.GetOrdinal("valor")))
                itempedido.Medicamento.Valor = reader.GetDecimal("valor");                                            
                              
                lista.Add(itempedido);
            }
            conexao.Close();
            return lista;
        }

        public List<ItemPedido> Lista(){
            return Lista(0);
        }
    }
    
}

