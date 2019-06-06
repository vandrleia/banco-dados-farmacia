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
    public partial class ListaComestivel : Form
    {
        public ListaComestivel()
        {
            InitializeComponent();
        }
        private void AtualizarTabela()
        {
            ComestivelRepositorio repositorio = new ComestivelRepositorio();
            List<Comestivel> comestivel = repositorio.ObterTodos();
            dataGridView1.Rows.Clear();
            for (int i = 0; i < comestivel.Count; i++)
            {
                Comestivel comestivel = comestivel[i];
                dataGridView1.Rows.Add(new object[] { comestivel.Id, comestivel.Nome, comestivel.Valor, comestivel.DataVencimento, comestivel.Quantidade, comestivel.Marca });

            }
        }
        private void btnCadastrarComestivel_Click(object sender, EventArgs e)
        {
            ComestivelCadastro cadastrar = new ComestivelCadastro();
            cadastrar.ShowDialog();

        }

        private void btnApagarComestivel_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ComestivelRepositorio repositorio = new ComestivelRepositorio();
            repositorio.Apagar(id);
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(data)
        }
    }
}
