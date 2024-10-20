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
    public partial class Form6 : Form
    {
        public static Form6 instance;
        public Label lbl3;
        public Form6()
        {
            InitializeComponent();
            instance = this;
            lbl3 = prod1;
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void prod1_Click(object sender, EventArgs e)
        {

        }
    }
}
