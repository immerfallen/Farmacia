using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace Farmacia.Models
{
    public class PedidoRepository : Repository
    {
        public int Cadastra(Pedido p){
            conexao.Open();

            string sql = "INSERT INTO pedido (dataPedido, entregue, id_clinica) VALUE (@dataPedido, @entregue, @id_clinica)";
            MySqlCommand comando = new MySqlCommand(sql,conexao);
            comando.Parameters.AddWithValue("@dataPedido",p.DataPedido);
            comando.Parameters.AddWithValue("@entregue",p.Entregue);
            comando.Parameters.AddWithValue("@id_clinica",p.Clinica.Id);

            comando.ExecuteNonQuery();
            int idNovoPedido = (int)comando.LastInsertedId;

            conexao.Close();
            return idNovoPedido;
        }

        public List<Pedido> Lista(int id){
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
        }
    }
}