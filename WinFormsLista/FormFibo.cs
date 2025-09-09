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
    public partial class FormFibo : Form
    {
        public FormFibo()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(tbxNum.Text);

            for(int i = 1; i <= num; i++)
            {


            }
        }
    }
}
