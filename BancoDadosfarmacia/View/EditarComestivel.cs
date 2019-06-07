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
    public partial class EditarComestivel : Form
    {
        public EditarComestivel()
        {
            InitializeComponent();
        }
        public EditarComestivel(Comestivel comestivel)
        {
            InitializeComponent();
            txtId.Text = comestivel.Id.ToString();
            txtNome.Text = comestivel.Nome;
            mtdValor.Text = Convert.ToString(comestivel.Valor);
            dtpDataVencimento.Text = comestivel.DataVencimento.ToString("yyyy-MM-dd");
            txtQuantidade.Text = Convert.ToString(comestivel.Quantidade);
            txtMarca.Text = comestivel.Marca;
        }

        private void btnSalvarComestivel_Click(object sender, EventArgs e)
        {
            Comestivel comestivel = new Comestivel();
            comestivel.Id = Convert.ToInt32(txtId.Text);
            comestivel.Nome = txtNome.Text;
            comestivel.Valor = Convert.ToDecimal(mtdValor.Text.Replace("R$", "").Replace(" ", ""));
            comestivel.DataVencimento = Convert.ToDateTime(dtpDataVencimento.Text);
            comestivel.Quantidade = Convert.ToInt32(txtQuantidade.Text);
            comestivel.Marca = txtMarca.Text;
            ComestivelRepositorio repositorio = new ComestivelRepositorio();
            repositorio.Atualizar(comestivel);

            MessageBox.Show("Editado com sucesso");
                 
        }
    }
}
