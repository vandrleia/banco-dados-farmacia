using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
   public  class RemedioRepositorio
    {

        string CadeiaConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\65984\Documents\ExemploBancoDados02.mdf;Integrated Security=True;Connect Timeout=30";
        public List<Remedio> ObterTodos()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "SELECT * FROM remedios";
            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());

            List<Remedio> remedios = new List<Remedio>();
            for (int i = 0; i < tabela.Rows.Count; i++)
            {

                DataRow linha = tabela.Rows[i];
                Remedio remedio = new Remedio();
                remedio.Id = Convert.ToInt32(linha["id"]);
                remedio.Nome = linha["nome"].ToString();
                remedio.Categoria = linha["categoria"].ToString();
                remedio.ContraIndicacao = linha["contra_indicacao"].ToString();
                remedio.Generico = Convert.ToBoolean(linha["generico"]);
                remedio.Bula = linha["bula"].ToString();
                remedio.Receita = Convert.ToBoolean(linha["receita"]);
                remedio.Faixa = linha["faixa"].ToString();
                remedios.Add(remedio);

            }
            conexao.Close();
            return remedios;
        }

    }
}
