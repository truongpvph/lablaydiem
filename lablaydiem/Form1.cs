﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lablaydiem
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void menuitemqldoibong_Click(object sender, EventArgs e)
        {
           Form2 form2 = new Form2();
            form2.ShowDialog();

        }

        private void menuitemQualicauthu_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void quanLiDoiBongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void danhSachCauThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }
    }
}
