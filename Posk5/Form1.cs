using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Posk5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                Form2 mustGoOn = new Form2();
                mustGoOn.Show();
                this.Hide();
            }
            else
            {
                
                MessageBox.Show("Nieprawidłowy login lub hasło!");
                textBox1.Clear();
                textBox2.Clear();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
