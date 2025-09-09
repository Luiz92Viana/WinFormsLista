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
    public partial class FormEx1 : Form
    {
        public FormEx1()
        {
            InitializeComponent();
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            int soma1 = Convert.ToInt32(tbxNum.Text);
            int soma2 = soma1 * (soma1 + 1) / 2;
        }
    }
}
