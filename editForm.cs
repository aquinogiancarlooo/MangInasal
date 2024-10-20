using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace manginasal
{
    public partial class editForm : Form
    {
        String mycon = "datasource=localhost;Database=dbkiosk;username=root;convert zero datetime=true";
        dbcon mc = new dbcon();
        String imagepath = "";
        String imagePath = "";
        String Pathh = "";
        String pics = "";
        


        public editForm()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED
                return cp;
            }
        } 

        private void button1_Click(object sender, EventArgs e)
        {
            productid.Enabled = true;
            browse.Visible = true;
            stockk.Enabled = true;
            price.Enabled = true;
            category.Enabled = true;
            prodname.Enabled = true;
            txtproddes.Enabled = true;

            button1.Visible = false;
          
            bt2.Visible = false;
            savebtn.Visible = true;

        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            try
            {


                String Query = "update tbinventory set stock = '" + this.stockk.Text + "', price = '" + this.price.Text +
                    "', category = '" + this.category.Text + "', prodname = '" + this.prodname.Text +
                    "', productdesc = '" + this.txtproddes.Text + "', path = '" + pics + "' where prodid = '" + productid.Text + "';";


                MySqlConnection MyConn = new MySqlConnection(mycon);

                MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);
                MySqlDataReader MyReader2;
                MyConn.Open();
                MyReader2 = MyCommand.ExecuteReader();
                MessageBox.Show("Product Info Has Been Updated");
                MyConn.Close();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

            button1.Visible = true;
           
            bt2.Visible = true;
            savebtn.Visible = false;

            productid.Enabled = false;
            stockk.Enabled = false;
            price.Enabled = false;
            category.Enabled = false;
            prodname.Enabled = false;
            txtproddes.Enabled = false;
            browse.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            picneck();
        }
        private void picneck()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.FileName = "";
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";



            if (openFileDialog1.FileName.ToString() != "")
            {

                if (open.ShowDialog() == DialogResult.OK)
                {

                    pictureBox1.Image = new Bitmap(open.FileName);


                    imagePath = open.FileName.ToString();
                    imagepath = imagePath.ToString();
                    imagepath = imagepath.Substring(imagepath.LastIndexOf("\\"));
                    imagepath = imagepath.Remove(0, 1);
                }

            }



            pics = "C:\\\\images\\\\" + imagepath;
        }

    }
}
