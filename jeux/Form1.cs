using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace jeux
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 jeux = new Form4();
            jeux.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 autre = new Form3();
            autre.Show();
            this.Hide();
        }

        private void btFormes_Click(object sender, EventArgs e)
        {
            Form2 autre = new Form2();
            autre.Show();
            this.Hide();
        }
    }
}
