using MySql.Data.MySqlClient;

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

        /* public List<Clinica> Lista(int id){
            conexao.Open();
            string sql = "SELECT * FROM clinica " + (id > 0 ? "WHERE id = @id " : "") + "ORDER BY nome"; 
            MySqlCommand comandoQuery = new MySqlCommand(sql,conexao);
            if(id>0)
            {
                comandoQuery.Parameters.AddWithValue("@id", id);

            }
            MySqlDataReader reader = comandoQuery.ExecuteReader();

            List<Clinica> lista = new List<Clinica>();

            while (reader.Read()){
                Clinica clinica = new Clinica();
                clinica.Id = reader.GetInt32("Id");

                if(!reader.IsDBNull(reader.GetOrdinal("Nome")))
                clinica.Nome = reader.GetString("Nome");

                if(!reader.IsDBNull(reader.GetOrdinal("Detalhes")))
                clinica.Detalhes = reader.GetString("Detalhes");
                lista.Add(clinica);
            }
            conexao.Close();
            return lista;
        }

        public List<Clinica> Lista(){
            return Lista(0);
        } */
    }
}