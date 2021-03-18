using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace Farmacia.Models
{
    public class MedicamentoRepository : Repository
    {
         public void Cadastra(Medicamento m){
            conexao.Open();

            string sql = "INSERT INTO medicamentos (nome, descricao, valor, dosagem, qtdEstoque) VALUE (@nome, @descricao, @valor, @dosagem, @qtdEstoque)";
            MySqlCommand comando = new MySqlCommand(sql,conexao);
            comando.Parameters.AddWithValue("@nome",m.Nome);
            comando.Parameters.AddWithValue("@descricao",m.Descricao);
            comando.Parameters.AddWithValue("@valor",m.Valor);
            comando.Parameters.AddWithValue("@dosagem",m.Dosagem);
            comando.Parameters.AddWithValue("@qtdEstoque",m.QtdEstoque);

            comando.ExecuteNonQuery();

            conexao.Close();
        }

        public List<Medicamento> Lista(int id){
            conexao.Open();
            string sql = "SELECT * FROM medicamentos " + (id > 0 ? "WHERE id = @id " : "") + "ORDER BY nome"; 
            MySqlCommand comandoQuery = new MySqlCommand(sql,conexao);
            if(id>0)
            {
                comandoQuery.Parameters.AddWithValue("@id", id);

            }
            MySqlDataReader reader = comandoQuery.ExecuteReader();

            List<Medicamento> lista = new List<Medicamento>();

            while (reader.Read()){
                Medicamento medicamento = new Medicamento();
                medicamento.Id = reader.GetInt32("Id");

                if(!reader.IsDBNull(reader.GetOrdinal("Nome")))
                medicamento.Nome = reader.GetString("Nome");

                if(!reader.IsDBNull(reader.GetOrdinal("Descricao")))
                medicamento.Descricao = reader.GetString("Descricao");

                if(!reader.IsDBNull(reader.GetOrdinal("Valor")))
                medicamento.Valor = reader.GetDecimal("Valor");

                if(!reader.IsDBNull(reader.GetOrdinal("Dosagem")))
                medicamento.Dosagem = reader.GetString("Dosagem");

                if(!reader.IsDBNull(reader.GetOrdinal("QtdEstoque")))
                medicamento.Descricao = reader.GetString("QtdEstoque");

                lista.Add(medicamento);
            }
            conexao.Close();
            return lista;
        }

        public List<Medicamento> Lista(){
            return Lista(0);
        }
    }
}