﻿using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class ProdutosRepositorio
    {
        string CadeiaConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\65984\Documents\ExemploBancoDados02.mdf;Integrated Security=True;Connect Timeout=30";

        public List<ProdutoHigienico> ObterTodos()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "SELECT * FROM produtos_higienicos";

            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());

            List<ProdutoHigienico> produtosHigienicos = new List<ProdutoHigienico>();
            for (int i =0; i < tabela.Rows.Count; i++)
            {
                DataRow linha = tabela.Rows[i];
                ProdutoHigienico produtoHigienico = new ProdutoHigienico();
                produtoHigienico.Id = Convert.ToInt32(linha["id"]);
                produtoHigienico.Nome = linha["nome"].ToString();
                produtoHigienico.Preco = Convert.ToDecimal(linha["preco"]);
                produtoHigienico.Categoria = linha["categoria"].ToString();
                produtosHigienicos.Add(produtoHigienico);
            }
            conexao.Close();
            return produtosHigienicos;

        }
        public ProdutoHigienico ObterPeloId(int id)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "SELECT * FROM produtosHigienicos WHERE id = @ID ";
            comando.Parameters.AddWithValue("@ID", id);

            DataTable dataTable = new DataTable();
            dataTable.Load(comando.ExecuteReader());
            conexao.Close();
            if(dataTable.Rows.Count == 1)
            {
                DataRow linha = dataTable.Rows[0];
                ProdutoHigienico produtoHigienico = new ProdutoHigienico();
                produtoHigienico.Id = Convert.ToInt32(linha["id"]);
                produtoHigienico.Nome = linha["nome"].ToString();
                produtoHigienico.Preco = Convert.ToDecimal(linha["preco"]);
                produtoHigienico.Categoria = linha["categoria"].ToString();
                return produtoHigienico;
            }
            return null;
        }
        public void Inserir(ProdutoHigienico produtoHigienico)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"INSERT INTO produtosHigienicos(nome,preco,categoria)VALUES(@NOME, @PRECO, @CATEGORIA)";
            comando.Parameters.AddWithValue("@NOME", )
        }
    }
}
