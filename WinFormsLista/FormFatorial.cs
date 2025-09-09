using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsLista
{
    public partial class FormFatorial : Form
    {
        public FormFatorial()
        {
            InitializeComponent();
        }

        private void tbnCalc_Click(object sender, EventArgs e)
        {
            double numero = Convert.ToDouble(tbxNum.Text);
            double fatorial = 1;

            for(int i = 1; i <= numero; i++)
            {
                fatorial = i * fatorial;
                lblAnswer.Text = fatorial.ToString($"O Valor Fatorial é:{fatorial}" );
            }
        }
    }
}
