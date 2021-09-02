using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЦштАщкьы
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Zapis(object sender, EventArgs e)
        {
            People people1 = new People();
            people1.Name = textBox1.Text;
            people1.Age = Int32.Parse(textBox2.Text);
            people1.Rost = Int32.Parse(textBox3.Text);
            people1.Iswork = checkBox1.AutoCheck;

            textBox1.Text = "";
            checkBox1.AutoCheck = false;
            textBox2.Text = "";
            textBox3.Text = "";
            label5.Text = people1.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
