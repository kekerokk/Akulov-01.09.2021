﻿using System;
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


        private void button1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Double click");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("One click");
            
        }

    }
}
