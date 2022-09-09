using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionDesafio1
{
    public partial class Form1 : Form
    {
        private int ciclo = 0;
        public Form1()
        {
            InitializeComponent();
            panel2.Width = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 37;

            label3.Text = ""+(this.ciclo += 1);

            if(this.ciclo > 15){
                timer1.Stop();
                Form2 fm2 = new Form2();
                fm2.Show();
                this.Hide();
            }
        }
    }
}
