using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Counter_Strike__Global_Offensive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Form2 form2 = new Form2();
        private void button1_Click(object sender, EventArgs e)
        {                     
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hesap Bilgileriniz Yanlıştır, Lütfen Yeniden Deneyiniz.");

                textBox1.Clear();
                textBox2.Clear();
            }
        }
    }
}
