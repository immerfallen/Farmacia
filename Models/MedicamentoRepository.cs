using MySql.Data.MySqlClient;

namespace Farmacia.Models
{
    public class MedicamentoRepository : Repository
    {
         public void Cadastra(Medicamento m){
            conexao.Open();

            string sql = "INSERT INTO medicamentos (nome, descricao, valor, dosagem, qtdEstoque) VALUE (@nome, @descricao, @valor, @dosagem, @qtdEstoque)";
            MySqlCommand comando = new MySqlCommand(sql,conexao);
            comando.Parameters.AddWithValue("@nome",m.Nome);
            comando.Parameters.AddWithValue("descricao",m.Descricao);
            comando.Parameters.AddWithValue("valor",m.Valor);
            comando.Parameters.AddWithValue("dosagem",m.Dosagem);
            comando.Parameters.AddWithValue("qtdEstoque",m.QtdEstoque);

            comando.ExecuteNonQuery();

            conexao.Close();
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