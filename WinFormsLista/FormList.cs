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
    public partial class FormList : Form
    {
        public FormList()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            lbxList.Items.Clear();
            
            for(int i = 0; i <= 10; i++) 
            {
                lbxList.Items.Add(i);
            }

            //while
            int num = 0;
            while(num <= 10) 
            {
                
                lbxList.Items.Add(num);
                num++;
            }
            //do while
            int num02 = -1;
            do
            {
                num02++;
                lbxList.Items.Add(num02);
            } while (num02 <= 9);
        }
    }
    
}
