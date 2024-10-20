namespace manginasal
{
    partial class editForm
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.browse = new System.Windows.Forms.Button();
            this.prodname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtproddes = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.savebtn = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.category = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.stockk = new System.Windows.Forms.TextBox();
            this.productid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::manginasal.Properties.Resources.bg1;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.browse);
            this.panel1.Controls.Add(this.prodname);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtproddes);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.savebtn);
            this.panel1.Controls.Add(this.bt2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.category);
            this.panel1.Controls.Add(this.price);
            this.panel1.Controls.Add(this.stockk);
            this.panel1.Controls.Add(this.productid);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1180, 743);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // browse
            // 
            this.browse.BackColor = System.Drawing.Color.White;
            this.browse.Location = new System.Drawing.Point(197, 479);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(218, 48);
            this.browse.TabIndex = 24;
            this.browse.Text = "BROWSE IMAGE";
            this.browse.UseVisualStyleBackColor = false;
            this.browse.Visible = false;
            this.browse.Click += new System.EventHandler(this.button2_Click);
            // 
            // prodname
            // 
            this.prodname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prodname.Enabled = false;
            this.prodname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodname.Location = new System.Drawing.Point(806, 177);
            this.prodname.Multiline = true;
            this.prodname.Name = "prodname";
            this.prodname.Size = new System.Drawing.Size(346, 40);
            this.prodname.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(486, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "stock";
            // 
            // txtproddes
            // 
            this.txtproddes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtproddes.Enabled = false;
            this.txtproddes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproddes.Location = new System.Drawing.Point(806, 260);
            this.txtproddes.Multiline = true;
            this.txtproddes.Name = "txtproddes";
            this.txtproddes.Size = new System.Drawing.Size(346, 117);
            this.txtproddes.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(801, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "product description";
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.Color.White;
            this.savebtn.Location = new System.Drawing.Point(768, 602);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(132, 58);
            this.savebtn.TabIndex = 14;
            this.savebtn.Text = "save";
            this.savebtn.UseVisualStyleBackColor = false;
            this.savebtn.Visible = false;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // bt2
            // 
            this.bt2.BackColor = System.Drawing.Color.White;
            this.bt2.Location = new System.Drawing.Point(630, 602);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(132, 58);
            this.bt2.TabIndex = 12;
            this.bt2.Text = "DELETE";
            this.bt2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(491, 602);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 58);
            this.button1.TabIndex = 11;
            this.button1.Text = "EDIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::manginasal.Properties.Resources.logo2;
            this.panel3.Location = new System.Drawing.Point(10, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 10;
            // 
            // category
            // 
            this.category.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.category.Enabled = false;
            this.category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.Location = new System.Drawing.Point(491, 430);
            this.category.Multiline = true;
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(253, 40);
            this.category.TabIndex = 8;
            // 
            // price
            // 
            this.price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.price.Enabled = false;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(491, 337);
            this.price.Multiline = true;
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(253, 40);
            this.price.TabIndex = 7;
            // 
            // stockk
            // 
            this.stockk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stockk.Enabled = false;
            this.stockk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockk.Location = new System.Drawing.Point(491, 263);
            this.stockk.Multiline = true;
            this.stockk.Name = "stockk";
            this.stockk.Size = new System.Drawing.Size(253, 40);
            this.stockk.TabIndex = 0;
            // 
            // productid
            // 
            this.productid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productid.Enabled = false;
            this.productid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productid.Location = new System.Drawing.Point(491, 177);
            this.productid.Multiline = true;
            this.productid.Name = "productid";
            this.productid.Size = new System.Drawing.Size(253, 40);
            this.productid.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(801, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "product name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(486, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(486, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(486, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "product id";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(155, 177);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 296);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // editForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 743);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "editForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "editForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.TextBox category;
        public System.Windows.Forms.TextBox price;
        public System.Windows.Forms.TextBox stockk;
        public System.Windows.Forms.TextBox productid;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button savebtn;
        public System.Windows.Forms.TextBox txtproddes;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox prodname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}