using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompraIngresso.view
{
    public partial class TelaVenda : Form
    {
        public TelaVenda()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            TelaVenda telavenda = new TelaVenda();
            int valor = Convert.ToInt32(lbl_resultado.Text);
            lbl_calcular.Text = TelaVenda.Calcular(valor);
        }

       
    }
}
