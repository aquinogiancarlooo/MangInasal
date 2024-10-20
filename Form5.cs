using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MangInasal
{
    public partial class Form5 : Form
    {
        Form6 f6 = new Form6();
        public static Form5 instance;

        public Form5()
        {
            InitializeComponent();
            instance = this;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
           
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if(a<1)
            {
                quantity.Text = 0.ToString();
            }
            else
            {
                a--;
                quantity.Text = a.ToString();
            }
        }
        private int a = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            a++;
            quantity.Text = a.ToString();
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            
            
            int pprice = 10;
            int p = a * pprice;
            Form4.instance.lbl1.Text = quantity.Text;
            Form4.instance.lbl2.Text = p.ToString();
        
            this.Hide();
        }

        private void pprice_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
