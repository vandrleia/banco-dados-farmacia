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
    public partial class CadastroProdutoHigienico : Form
    {
        public CadastroProdutoHigienico()
        {
            InitializeComponent();
        }
        private void CadastroProdutoHigienico_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ProdutoHigienico produtoHigienico = new ProdutoHigienico();
            produtoHigienico.Nome = txtNome.Text;
            produtoHigienico.Preco = Convert.ToDecimal(mtdPreco.Text.Replace("R$", "").Replace(" ", ""));
            produtoHigienico.Quantidade = Convert.ToInt32(txtQuantidade.Text);
            produtoHigienico.Categoria = cbCategoria.Text;
            ProdutosRepositorio repositorio = new ProdutosRepositorio();
            repositorio.Inserir(produtoHigienico);
            Close();

        }

        private void mtdPreco_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblQuantidade_Click(object sender, EventArgs e)
        {

        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPreco_Click(object sender, EventArgs e)
        {

        }

        private void lblCategoria_Click(object sender, EventArgs e)
        {

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }
    }
}
