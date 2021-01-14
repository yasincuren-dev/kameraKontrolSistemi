using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kameraKontrolSistemi
{
    public partial class Form1 : Form
    {
        Form2 form2 = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="yasin" && textBox2.Text == "123")
            {
                MessageBox.Show("GİRİŞ BAŞARILI");
                form2.Show();
                this.Hide();
            }

            else
            {
                textBox1.Focus();
                MessageBox.Show("HATALI GİRİŞ");
            }
        }
    }
}
