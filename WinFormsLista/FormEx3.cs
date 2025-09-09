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
    public partial class FormEx3 : Form
    {
        public FormEx3()
        {
            InitializeComponent();
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            double termoInicial = Convert.ToDouble(tbxTI.Text);
            double quantTermos = Convert.ToDouble(tbxQT.Text);
            double razao = Convert.ToDouble(tbxRazao.Text);
            double an = 0;

            for (int i = 1; i <= quantTermos; i++) 
            { 
                an = termoInicial + (i - 1) * razao;
                lbxLista.Items.Add($"a{i} = {an}");
            }
           



        }

        private void btnPG_Click(object sender, EventArgs e)
        {
            double a1 = Convert.ToDouble(tbxTI.Text);
            double n = Convert.ToDouble(tbxQT.Text);
            double q = Convert.ToDouble(tbxRazao.Text);
            double an = 0;

            lbxLista.Items.Clear();
            for (int i = 1;i <= n; i++) 
            {
                an = a1 * Math.Pow(q, i - 1);
                lbxLista.Items.Add($"a{i} = {an}");
                
            }
        }

        
    }
}
