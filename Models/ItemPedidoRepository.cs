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

        public List<ItemPedido> Lista(int id){
            conexao.Open();
            string sql = "SELECT * FROM itempedido " + (id > 0 ? "WHERE id = @id " : "") + "ORDER BY id_pedido"; 
            MySqlCommand comandoQuery = new MySqlCommand(sql,conexao);
            if(id>0)
            {
                comandoQuery.Parameters.AddWithValue("@id", id);

            }
            MySqlDataReader reader = comandoQuery.ExecuteReader();

            List<ItemPedido> lista = new List<ItemPedido>();

            while (reader.Read()){
                ItemPedido itempedido = new ItemPedido();
                itempedido.Id = reader.GetInt32("Id");

                if(!reader.IsDBNull(reader.GetOrdinal("id_pedido")))
                itempedido.Pedido = new Pedido();
                itempedido.Pedido.Id = reader.GetInt32("id_pedido");

                if(!reader.IsDBNull(reader.GetOrdinal("id_medicamento")))
                itempedido.Medicamento = new Medicamento();
                itempedido.Medicamento.Id = reader.GetInt32("id_medicamento");

                if(!reader.IsDBNull(reader.GetOrdinal("quantidade")))                
                itempedido.Quantidade = reader.GetInt32("quantidade");
               
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