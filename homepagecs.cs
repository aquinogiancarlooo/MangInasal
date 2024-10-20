using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
namespace manginasal
{
    public partial class homepagecs : Form
    {
        String mycon = "datasource=localhost;Database=dbkiosk;username=root;convert zero datetime=true";
        dbcon mc = new dbcon();
        editForm ef = new editForm();
        orders ord = new orders();
        receipt rt = new receipt();
              
        String imagepath = "";
        String imagePath = "";
        String Pathh = "";
        String pics = "";
        public homepagecs()
        {
            InitializeComponent();
        }

            private void homepagecs_Load(object sender, EventArgs e)
        {
            databooks();
            accountTable();
            queingtable();
            tablerecords();
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

        private void inventory_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void records_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void sales_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }

        private void queing_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
        }

        private void admin_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 5;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void databooks()
        {
            try
            {
                dgvinventory.AutoResizeColumns();
                dgvinventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvinventory.DefaultCellStyle.Font = new Font("Tahoma", 11);

                String Query = "select * from tbinventory;";
                MySqlConnection MyConn = new MySqlConnection(mycon);
                MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);

                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dgvinventory.DataSource = dTable;
                dgvinventory.Columns[0].HeaderText = "PRODUCT ID";
                dgvinventory.Columns[1].HeaderText = "PRODUCT NAME";
                dgvinventory.Columns[2].HeaderText = "CATEGORY";
                dgvinventory.Columns[3].HeaderText = "PRICE";
                dgvinventory.Columns[4].HeaderText = "STOCK";
                dgvinventory.Columns[5].HeaderText = "PRODUCT DESCRIPTION";
                dgvinventory.Columns[6].HeaderText = "IMAGE PATH";
             
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    
        private void dgvinventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "editForm")
                {
                    isopen = true;
                    f.BringToFront();
                    MessageBox.Show("please close the current tab to select new");
                    break;
                }
            }

            if (isopen == false)
            {
                editForm ef = new editForm();
                ef.Show();

                try
                {
                    DataGridViewCell cell = null;
                    foreach (DataGridViewCell selectedCell in dgvinventory.SelectedCells)
                    {
                        cell = selectedCell;
                    }
                    if (cell != null)
                    {
                        DataGridViewRow row = cell.OwningRow;
                        ef.productid.Text = row.Cells["prodid"].Value.ToString();
                        ef.stockk.Text = row.Cells["stock"].Value.ToString();
                        ef.price.Text = row.Cells["price"].Value.ToString();
                        ef.category.Text = row.Cells["category"].Value.ToString();
                        ef.txtproddes.Text = row.Cells["productdesc"].Value.ToString();
                        ef.prodname.Text = row.Cells["prodname"].Value.ToString();
                        

                        databooks();

                        try
                        {
                            mc.connect();
                            mc.cmd = new MySqlCommand("select * from tbinventory where prodid = @prodid", mc.con);

                            mc.cmd.Parameters.Add(new MySqlParameter("prodid", ef.productid.Text));
                            mc.dr = mc.cmd.ExecuteReader();
                            if (mc.dr.Read())
                            {

                             
                                ef.pictureBox1.Image = Image.FromFile(mc.dr.GetValue(6).ToString());
                        



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
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);

                }
            }

           
            

            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            }


         private void accountTable()
        {
            try
            {
                dgvaccounts.AutoResizeColumns();
                dgvaccounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvaccounts.DefaultCellStyle.Font = new Font("arial", 12);

                String Query = "select * from tbadmin;";
                MySqlConnection MyConn = new MySqlConnection(mycon);
                MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);

                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dgvaccounts.DataSource = dTable;
                dgvaccounts.Columns[0].HeaderText = "USERNAME";
                dgvaccounts.Columns[1].HeaderText = "PASSWORD";
                dgvaccounts.Columns[2].HeaderText = "USER ROLE";
             
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

         private void dgvaccounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
         {

             try
             {
                 DataGridViewCell cell = null;
                 foreach (DataGridViewCell selectedCell in dgvaccounts.SelectedCells)
                 {
                     cell = selectedCell;
                 }
                 if (cell != null)
                 {
                     DataGridViewRow row = cell.OwningRow;
                     txtusername.Text = row.Cells["username"].Value.ToString();
                     txtpassword.Text = row.Cells["password"].Value.ToString();
                     txtuserrole.Text = row.Cells["userrole"].Value.ToString();


                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("" + ex);

             }
         }

         private void button4_Click(object sender, EventArgs e)
         {
             try
             {
                 String Query = "update tbadmin set username = '" + this.txtusername.Text +
                     "', password = '" + this.txtpassword.Text + "', userrole = '" + this.txtuserrole.Text + "' where username = '" + txtusername.Text + "';";
                 MySqlConnection MyConn = new MySqlConnection(mycon);

                 MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);
                 MySqlDataReader MyReader2;
                 MyConn.Open();
                 MyReader2 = MyCommand.ExecuteReader();
                 MessageBox.Show("Account has been updated");
                 accountTable();
                 MyConn.Close();
             }
             catch (Exception ex)
             {
                 MessageBox.Show("" + ex);
             }
         }

         private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
         {
             bool issopen = false;
             foreach (Form g in Application.OpenForms)
             {
                 if (g.Text == "orders")
                 {
                     issopen = true;
                     g.BringToFront();
                     MessageBox.Show("please close the current tab to select new");
                     break;
                 }
             }

             if (issopen == false)
             {
                 orders ord = new orders();
                 ord.Show();

                 try
                 {
                     DataGridViewCell cell = null;
                     foreach (DataGridViewCell selectedCell in dgvqueing.SelectedCells)
                     {
                         cell = selectedCell;
                     }
                     if (cell != null)
                     {
                         DataGridViewRow row = cell.OwningRow;
                         ord.txtordernum.Text = row.Cells["orderno"].Value.ToString();
                         ord.txtorders.Text = row.Cells["orders"].Value.ToString();
                         ord.txttotal.Text = row.Cells["totalamount"].Value.ToString();
                        ord.txtstatus.Text = row.Cells["status"].Value.ToString();

                     }
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show("" + ex);

                 }
             }
         }



         private void queingtable()
         {
             try
             {
                 dgvqueing.AutoResizeColumns();
                 dgvqueing.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                 dgvqueing.DefaultCellStyle.Font = new Font("arial", 12);

                 String Query = "select * from tbqueing;";
                 MySqlConnection MyConn = new MySqlConnection(mycon);
                 MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);

                 MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                 MyAdapter.SelectCommand = MyCommand;
                 DataTable dTable = new DataTable();
                 MyAdapter.Fill(dTable);
                 dgvqueing.DataSource = dTable;
                 dgvqueing.Columns[0].HeaderText = "ORDER NUMBER";
                 dgvqueing.Columns[1].HeaderText = "ORDERS";
                 dgvqueing.Columns[2].HeaderText = "TOTAL AMOUNT";
                 dgvqueing.Columns[3].HeaderText = "STATUS";

             }

             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
         }

         private void button5_Click(object sender, EventArgs e)
         {
             queingtable();
         }

         private void button6_Click(object sender, EventArgs e)
         {
             databooks();
         }

         private void button2_Click(object sender, EventArgs e)
         {

         }

         private void dgvrecords_CellContentClick(object sender, DataGridViewCellEventArgs e)
         {
             bool issopen = false;
             foreach (Form g in Application.OpenForms)
             {
                 if (g.Text == "receipt")
                 {
                     issopen = true;
                     g.BringToFront();
                     MessageBox.Show("please close the current tab to select new");
                     break;
                 }
             }

             if (issopen == false)
             {
                 receipt rt = new receipt();
                 rt.Show();

                 try
                 {
                     DataGridViewCell cell = null;
                     foreach (DataGridViewCell selectedCell in dgvrecords.SelectedCells)
                     {
                         cell = selectedCell;
                     }
                     if (cell != null)
                     {
                         DataGridViewRow row = cell.OwningRow;
                        rt.lbltransac.Text = row.Cells["ordernum"].Value.ToString();
                         rt.lblorders.Text = row.Cells["orders"].Value.ToString();
                         rt.lblstatus.Text = row.Cells["status"].Value.ToString();
                         rt.lbltotal.Text = row.Cells["totalamount"].Value.ToString();
                         rt.lblpayment.Text = row.Cells["payment"].Value.ToString();
                         rt.lblchange.Text = row.Cells["change"].Value.ToString();

                     }
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show("" + ex);

                 }
             }
         }

         private void tablerecords()
         {
             try
             {
                 dgvrecords.AutoResizeColumns();
                 dgvrecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                 dgvrecords.DefaultCellStyle.Font = new Font("Tahoma", 11);

                 String Query = "select * from tbrecords;";
                 MySqlConnection MyConn = new MySqlConnection(mycon);
                 MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);

                 MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                 MyAdapter.SelectCommand = MyCommand;
                 DataTable dTable = new DataTable();
                 MyAdapter.Fill(dTable);
                 dgvrecords.DataSource = dTable;
                 dgvrecords.Columns[0].HeaderText = "TRANSACTION NUMBER";
                 dgvrecords.Columns[1].HeaderText = "ORDERS";
                 dgvrecords.Columns[2].HeaderText = "STATUS";
                 dgvrecords.Columns[3].HeaderText = "TOTAL AMOUNT";
                 dgvrecords.Columns[4].HeaderText = "PAYMENT";
                 dgvrecords.Columns[5].HeaderText = "CHANGE";
                 //dgvrecords.Columns[6].HeaderText = "";



             }

             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
         }

         private void button2_Click_1(object sender, EventArgs e)
         {
             tablerecords();
         }

        

       






































        }

}
      

