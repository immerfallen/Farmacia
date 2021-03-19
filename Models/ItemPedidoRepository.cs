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

        /* public List<Pedido> Lista(int id){
            conexao.Open();
            string sql = "SELECT * FROM pedido " + (id > 0 ? "WHERE id = @id " : "") + "ORDER BY dataPedido"; 
            MySqlCommand comandoQuery = new MySqlCommand(sql,conexao);
            if(id>0)
            {
                comandoQuery.Parameters.AddWithValue("@id", id);

            }
            MySqlDataReader reader = comandoQuery.ExecuteReader();

            List<Pedido> lista = new List<Pedido>();

            while (reader.Read()){
                Pedido pedido = new Pedido();
                pedido.Id = reader.GetInt32("Id");

                if(!reader.IsDBNull(reader.GetOrdinal("dataPedido")))
                pedido.DataPedido = reader.GetDateTime("dataPedido");

                if(!reader.IsDBNull(reader.GetOrdinal("entregue")))
                pedido.Entregue = reader.GetBoolean("entregue");

                if(!reader.IsDBNull(reader.GetOrdinal("id_clinica")))
                pedido.Clinica = new Clinica();
                pedido.Clinica.Id = reader.GetInt32("id_clinica");
                lista.Add(pedido);
            }
            conexao.Close();
            return lista;
        }

        public List<Pedido> Lista(){
            return Lista(0);
        } */
    }
    
}