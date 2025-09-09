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
    public partial class FormEx2 : Form
    {
        public FormEx2()
        {
            InitializeComponent();
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(tbxNum.Text);
            

            lbxNum.Items.Clear();

            double num2 = 1;
            while (num2 <= num) 
            {
                bool par = (num2 % 2 == 0);
                if (par)
                {
                    lbxNum.Items.Add(num2);

                }
                
                num2++;
            }
        }
    }
}
