﻿using Model;
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
    public partial class ComestivelCadastro : Form
    {
        public ComestivelCadastro()
        {
            InitializeComponent();
        }
        private void ComestivelCadastro_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvarComestivel_Click(object sender, EventArgs e)
        {
            Comestivel comestivel = new Comestivel();
            comestivel.Nome = txtNome.Text;

            comestivel.Valor = Convert.ToDecimal(mtdValor.Text.Replace("R$", "").Replace(" ", ""));
            comestivel.DataVencimento = dtpDataVencimento.Value;
            comestivel.Quantidade = Convert.ToInt32(txtQuantidade.Text);
            comestivel.Marca = txtMarca.Text;
            ComestivelRepositorio repositorio = new ComestivelRepositorio();
            repositorio.Inserir(comestivel);
            Close();
        }
    }
}
