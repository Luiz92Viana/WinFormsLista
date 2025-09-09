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
    public partial class FormEx8 : Form
    {
        public FormEx8()
        {
            InitializeComponent();
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            double num = 0;
            num = Convert.ToDouble(tbxNum.Text);
            

            for(int i = 2; i <= num; i++)
            {
                bool primo = true;
                for(int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if(i%j == 0)
                    {
                        primo = false;
                        break;
                    }
                    
                }
                if (primo)
                {
                    lbxLista.Items.Add(i);
                }
            }

        }
    }
}
