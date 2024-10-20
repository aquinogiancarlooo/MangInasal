using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;


using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using MySql.Data.MySqlClient;

namespace MangInasal
{
    public partial class Form4 : Form
    {
        Form6 f6 = new Form6();
         String mycon = "datasource=localhost;Database=dbkiosk;username=root;convert zero datetime=true";
        dbcon mc = new dbcon();
        public static Form4 instance;
        public Label lbl1;
        public Label lbl2;
        Form5 f5 = new Form5();

        public Form4()
        {
            InitializeComponent();
            instance = this;
            lbl1 = item;
            lbl2 = total;
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


        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
             Form5 f5 = new Form5();
            f5.Show();
       
            try
            {
                mc.connect();
                mc.cmd = new MySqlCommand("select * from tbinventory where prodid = @prodid", mc.con);

                mc.cmd.Parameters.Add(new MySqlParameter("prodid", button8.Text));
                mc.dr = mc.cmd.ExecuteReader();
                if (mc.dr.Read())
                {
                    f5.productid.Text = mc.dr.GetValue(0).ToString();
                    f5.productname.Text = mc.dr.GetValue(1).ToString();
                    f5.productdesc.Text = mc.dr.GetValue(5).ToString();
                    f5.price.Text = mc.dr.GetValue(3).ToString();
                    f5.hide.Text = mc.dr.GetValue(6).ToString();
                  

                     try
                        {
                            mc.connect();
                            mc.cmd = new MySqlCommand("select * from tbinventory where prodid = @prodid", mc.con);

                            mc.cmd.Parameters.Add(new MySqlParameter("prodid", f5.productid.Text));
                            mc.dr = mc.cmd.ExecuteReader();
                            if (mc.dr.Read())
                            {

                             
                                f5.pictureBox1.Image = Image.FromFile(mc.dr.GetValue(6).ToString());
                        



                            }
                            else
                            {
                                MessageBox.Show("Books Not Found", "Invalid Search!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            mc.Disconnect();
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                }
                else
                {
                    MessageBox.Show("Books Not Found", "Invalid Search!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                mc.Disconnect();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
     
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button40_Click(object sender, EventArgs e)
        {
            
            Form6 f6 = new Form6();
           
            f6.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();

            try
            {
                mc.connect();
                mc.cmd = new MySqlCommand("select * from tbinventory where prodid = @prodid", mc.con);

                mc.cmd.Parameters.Add(new MySqlParameter("prodid", button9.Text));
                mc.dr = mc.cmd.ExecuteReader();
                if (mc.dr.Read())
                {
                    f5.productid.Text = mc.dr.GetValue(0).ToString();
                    f5.productname.Text = mc.dr.GetValue(1).ToString();
                    f5.productdesc.Text = mc.dr.GetValue(5).ToString();
                    f5.price.Text = mc.dr.GetValue(3).ToString();
                    f5.hide.Text = mc.dr.GetValue(6).ToString();


                    try
                    {
                        mc.connect();
                        mc.cmd = new MySqlCommand("select * from tbinventory where prodid = @prodid", mc.con);

                        mc.cmd.Parameters.Add(new MySqlParameter("prodid", f5.productid.Text));
                        mc.dr = mc.cmd.ExecuteReader();
                        if (mc.dr.Read())
                        {


                            f5.pictureBox1.Image = Image.FromFile(mc.dr.GetValue(6).ToString());




                        }
                        else
                        {
                            MessageBox.Show("Books Not Found", "Invalid Search!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        mc.Disconnect();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                else
                {
                    MessageBox.Show("Books Not Found", "Invalid Search!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                mc.Disconnect();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();

            try
            {
                mc.connect();
                mc.cmd = new MySqlCommand("select * from tbinventory where prodid = @prodid", mc.con);

                mc.cmd.Parameters.Add(new MySqlParameter("prodid", button10.Text));
                mc.dr = mc.cmd.ExecuteReader();
                if (mc.dr.Read())
                {
                    f5.productid.Text = mc.dr.GetValue(0).ToString();
                    f5.productname.Text = mc.dr.GetValue(1).ToString();
                    f5.productdesc.Text = mc.dr.GetValue(5).ToString();
                    f5.price.Text = mc.dr.GetValue(3).ToString();
                    f5.hide.Text = mc.dr.GetValue(6).ToString();


                    try
                    {
                        mc.connect();
                        mc.cmd = new MySqlCommand("select * from tbinventory where prodid = @prodid", mc.con);

                        mc.cmd.Parameters.Add(new MySqlParameter("prodid", f5.productid.Text));
                        mc.dr = mc.cmd.ExecuteReader();
                        if (mc.dr.Read())
                        {


                            f5.pictureBox1.Image = Image.FromFile(mc.dr.GetValue(6).ToString());




                        }
                        else
                        {
                            MessageBox.Show("Books Not Found", "Invalid Search!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        mc.Disconnect();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                else
                {
                    MessageBox.Show("Books Not Found", "Invalid Search!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                mc.Disconnect();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
