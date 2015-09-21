using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tabuada
{
    public partial class frmTabu : Form
    {
        int valor;
        int result;

        private void calcular()
        {
            try
            {
                valor = int.Parse(mtbValor.Text);
                int i = 1;

                while (i <= 10)
                {
                    result = i * valor;
                    tbResult.Text += i.ToString() + " x " + valor.ToString() + " = " + result.ToString() + Environment.NewLine;
                    i++;
                    lblTitle.Text = "A tabuada escolhida foi: " + valor;
                    lblTitle.Visible = true;
                }
                
            }

            catch (Exception)
            {
                MessageBox.Show("Não possui tabuada para este valor. Por favor, digite outro número para a tabuada.");
                mtbValor.Clear();
                mtbValor.Focus();
            }

        }

        public frmTabu()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            calcular();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tbResult.Clear();
            mtbValor.Clear();
            mtbValor.Focus();
            lblTitle.Visible = false;
        }

        private void mtbValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                calcular();
            }
        }

        private void mtbValor_Enter(object sender, EventArgs e)
        {
            mtbValor.SelectionStart = 0;
        }

        private void mtbValor_Click(object sender, EventArgs e)
        {
            mtbValor.Clear();
            mtbValor.SelectionStart = 0;
        }

    }
}
