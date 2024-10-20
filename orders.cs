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
    public partial class orders : Form
    {
        String mycon = "datasource=localhost;Database=dbkiosk;username=root;convert zero datetime=true";
        dbcon mc = new dbcon();
        public int total = 0;
        int payment = 0;
        int totalchange = 0;
       


        public orders()

        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int total = Convert.ToInt32(txttotal.Text);
            int payment = Convert.ToInt32(txtpayment.Text);


            if (payment >= total)
            {
                totalchange = payment - total;
                string changee = Convert.ToString(totalchange);
                change.Text = changee;
            }
            else
            {
                change.Text = "0";
                MessageBox.Show("Please add");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result1 = MessageBox.Show("Do you want to Continue?", "Important Question", MessageBoxButtons.YesNo);
                String Query = "";
                if (result1.Equals(DialogResult.Yes))
                {
                    Query = "delete from tbqueing where orderno = '" + txtordernum.Text + "';";
                }
                else
                {
                    MessageBox.Show("Nothing Changed");
                }

                MySqlConnection MyConn = new MySqlConnection(mycon);
                MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);
                MySqlDataReader MyReader2;
                MyConn.Open();
                MyReader2 = MyCommand.ExecuteReader();
                listofret();
                MessageBox.Show("Returned Successfully");
                
                MyConn.Close();
                this.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No Records To Delete");
            }
        }

        private void listofret()
        {
            try
            {
                String Query = "insert into tbrecords values('" + this.txtorders.Text + "', '" +
                      this.txtstatus.Text + "', '" +
                      this.txttotal.Text + "', '" +
                       this.txtpayment.Text + "', '" +
                        this.change.Text + "', '" + "');";

                    MySqlConnection MyConn = new MySqlConnection(mycon);
                    MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);
                    MySqlDataReader MyReader2;
                    MyConn.Open();
                    MyReader2 = MyCommand.ExecuteReader(); MessageBox.Show("New Book Has Been Added");
                    //databooks();
                    MyConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtorders_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
