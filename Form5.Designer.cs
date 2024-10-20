namespace MangInasal
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.productname = new System.Windows.Forms.Label();
            this.productdesc = new System.Windows.Forms.Label();
            this.productid = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.TextBox();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.price = new System.Windows.Forms.Label();
            this.hide = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(56, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 211);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // productname
            // 
            this.productname.AutoSize = true;
            this.productname.Location = new System.Drawing.Point(127, 297);
            this.productname.Name = "productname";
            this.productname.Size = new System.Drawing.Size(75, 13);
            this.productname.TabIndex = 1;
            this.productname.Text = "Product Name";
            // 
            // productdesc
            // 
            this.productdesc.AutoSize = true;
            this.productdesc.Location = new System.Drawing.Point(521, 91);
            this.productdesc.Name = "productdesc";
            this.productdesc.Size = new System.Drawing.Size(60, 13);
            this.productdesc.TabIndex = 2;
            this.productdesc.Text = "Description";
            // 
            // productid
            // 
            this.productid.AutoSize = true;
            this.productid.Location = new System.Drawing.Point(521, 185);
            this.productid.Name = "productid";
            this.productid.Size = new System.Drawing.Size(51, 13);
            this.productid.TabIndex = 3;
            this.productid.Text = "productid";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(424, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quantity";
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(493, 228);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(100, 20);
            this.quantity.TabIndex = 5;
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(713, 226);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(75, 23);
            this.plus.TabIndex = 6;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.button1_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(621, 226);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(75, 23);
            this.minus.TabIndex = 7;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(558, 297);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(678, 297);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "done";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(521, 151);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(35, 13);
            this.price.TabIndex = 12;
            this.price.Text = "label5";
            this.price.Click += new System.EventHandler(this.pprice_Click);
            // 
            // hide
            // 
            this.hide.AutoSize = true;
            this.hide.Location = new System.Drawing.Point(94, 30);
            this.hide.Name = "hide";
            this.hide.Size = new System.Drawing.Size(35, 13);
            this.hide.TabIndex = 13;
            this.hide.Text = "label1";
            this.hide.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::MangInasal.Properties.Resources.bg;
            this.panel1.Controls.Add(this.hide);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(971, 400);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 397);
            this.Controls.Add(this.price);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.productid);
            this.Controls.Add(this.productdesc);
            this.Controls.Add(this.productname);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.Label productname;
        public System.Windows.Forms.Label productdesc;
        public System.Windows.Forms.Label price;
        public System.Windows.Forms.Label productid;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label hide;
        private System.Windows.Forms.Panel panel1;
    }
}