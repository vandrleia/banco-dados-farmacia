using Model;
using Repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class ListaProdutoHigienico : Form
    {
        public ListaProdutoHigienico()
        {
            InitializeComponent();
        }
        private void AtualizarTabela()
        {
            ProdutosRepositorio repositorio = new ProdutosRepositorio();
            List<ProdutoHigienico> produtosHigienicos = repositorio.ObterTodos();
            dataGridView1.Rows.Clear();

            for (int i = 0; i < produtosHigienicos.Count; i++) 
            {
                ProdutoHigienico produtoHigienico = produtosHigienicos[i];
                dataGridView1.Rows.Add(new object[] { produtoHigienico.Id, produtoHigienico.Nome, produtoHigienico.Preco, produtoHigienico.Quantidade, produtoHigienico.Categoria });

            }

        }

        private void ListaProdutoHigienico_Load(object sender, EventArgs e)
        {

        }

        private void bynApagar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ProdutosRepositorio repositorio = new ProdutosRepositorio();
            repositorio.Apagar(id);
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);


        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastroProdutoHigienico cadastrar = new CadastroProdutoHigienico();
            cadastrar.ShowDialog();
        }
        private void ListaProdutoHigienico_Activated(object sender, EventArgs e  )
        {
            AtualizarTabela();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ProdutosRepositorio repositorio = new ProdutosRepositorio();
            ProdutoHigienico produtoHigienico = repositorio.ObterPeloId(id);
            EditarCadastro cadastroProdutoHigienico = new EditarCadastro(produtoHigienico);
            cadastroProdutoHigienico.ShowDialog();



        }

        private void ListaProdutoHigienico_Activated_1(object sender, EventArgs e)
        {
            AtualizarTabela();
        }
    }
}
