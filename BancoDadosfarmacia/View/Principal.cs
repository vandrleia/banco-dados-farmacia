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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            ListaProdutoHigienico form = new ListaProdutoHigienico();
            form.Visible = true;
        }

        private void btnCadastroComestiveis_Click(object sender, EventArgs e)
        {
            ListaComestivel form = new ListaComestivel();
            form.Visible = true;
        }
    }
}
