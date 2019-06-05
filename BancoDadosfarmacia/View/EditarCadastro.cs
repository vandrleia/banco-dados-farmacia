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
    public partial class EditarCadastro : Form
    {
        public EditarCadastro()
        {
            InitializeComponent();
        }
        public  EditarCadastro(ProdutoHigienico produtoHigienico)
        {
            InitializeComponent();
            txtNome.Text = produtoHigienico.Nome;
            mtdPreco.Text = Convert.ToString(produtoHigienico.Preco);
            txtQuantidade.Text = Convert.ToString(produtoHigienico.Quantidade);
            cbCategoria.SelectedItem = produtoHigienico.Categoria;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ProdutoHigienico produtoHigienico = new ProdutoHigienico();
            produtoHigienico.Nome = txtNome.Text;
            produtoHigienico.Preco = Convert.ToDecimal(mtdPreco.Text.Replace("R$", "").Replace(" ", ""));
            produtoHigienico.Quantidade = Convert.ToInt32(txtQuantidade.Text);
            produtoHigienico.Categoria = cbCategoria.SelectedItem.ToString();
            ProdutosRepositorio repositorio = new ProdutosRepositorio();
            repositorio.Atualizar(produtoHigienico);

            MessageBox.Show("Editado com sucesso");
        }
    }
}
