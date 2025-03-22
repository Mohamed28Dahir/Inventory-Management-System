namespace Inventory_Management_System
{
    partial class ROrders
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
            System.Windows.Forms.Label label16;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ROrders));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataview = new System.Windows.Forms.DataGridView();
            this.dataGridViewCus = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearchPRO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearchCUS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCusN = new System.Windows.Forms.TextBox();
            this.txtCusID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtProName = new System.Windows.Forms.TextBox();
            this.txtProID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txt_ID = new System.Windows.Forms.TextBox();
            label16 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCus)).BeginInit();
            this.SuspendLayout();
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = System.Drawing.Color.White;
            label16.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            label16.Location = new System.Drawing.Point(114, 461);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(114, 27);
            label16.TabIndex = 44;
            label16.Text = "Orders ID:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.pictureBoxBack);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-3, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1371, 102);
            this.panel2.TabIndex = 8;
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBack.Image")));
            this.pictureBoxBack.Location = new System.Drawing.Point(15, 14);
            this.pictureBoxBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(68, 54);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBack.TabIndex = 9;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(476, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "Orders Registration ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(-3, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1371, 78);
            this.panel1.TabIndex = 7;
            // 
            // dataview
            // 
            this.dataview.BackgroundColor = System.Drawing.Color.White;
            this.dataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataview.Location = new System.Drawing.Point(481, 203);
            this.dataview.Name = "dataview";
            this.dataview.RowHeadersWidth = 62;
            this.dataview.RowTemplate.Height = 28;
            this.dataview.Size = new System.Drawing.Size(867, 194);
            this.dataview.TabIndex = 9;
            // 
            // dataGridViewCus
            // 
            this.dataGridViewCus.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCus.Location = new System.Drawing.Point(12, 203);
            this.dataGridViewCus.Name = "dataGridViewCus";
            this.dataGridViewCus.RowHeadersWidth = 62;
            this.dataGridViewCus.RowTemplate.Height = 28;
            this.dataGridViewCus.Size = new System.Drawing.Size(440, 194);
            this.dataGridViewCus.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(22, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Customers Info:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(492, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "Prodects Info:";
            // 
            // txtSearchPRO
            // 
            this.txtSearchPRO.Location = new System.Drawing.Point(983, 410);
            this.txtSearchPRO.Multiline = true;
            this.txtSearchPRO.Name = "txtSearchPRO";
            this.txtSearchPRO.Size = new System.Drawing.Size(329, 32);
            this.txtSearchPRO.TabIndex = 15;
            this.txtSearchPRO.TextChanged += new System.EventHandler(this.txtSearchPRO_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(882, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 29);
            this.label5.TabIndex = 16;
            this.label5.Text = "Search";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtSearchCUS
            // 
            this.txtSearchCUS.Location = new System.Drawing.Point(229, 410);
            this.txtSearchCUS.Multiline = true;
            this.txtSearchCUS.Name = "txtSearchCUS";
            this.txtSearchCUS.Size = new System.Drawing.Size(194, 32);
            this.txtSearchCUS.TabIndex = 17;
            this.txtSearchCUS.TextChanged += new System.EventHandler(this.txtSearchCUS_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(122, 410);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 29);
            this.label6.TabIndex = 18;
            this.label6.Text = "Search";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtCusN
            // 
            this.txtCusN.Location = new System.Drawing.Point(120, 714);
            this.txtCusN.Multiline = true;
            this.txtCusN.Name = "txtCusN";
            this.txtCusN.Size = new System.Drawing.Size(274, 32);
            this.txtCusN.TabIndex = 3;
            // 
            // txtCusID
            // 
            this.txtCusID.Location = new System.Drawing.Point(120, 606);
            this.txtCusID.Multiline = true;
            this.txtCusID.Name = "txtCusID";
            this.txtCusID.Size = new System.Drawing.Size(274, 32);
            this.txtCusID.TabIndex = 27;
            this.txtCusID.Text = "  ";
            this.txtCusID.TextChanged += new System.EventHandler(this.txtCusID_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(115, 665);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(208, 29);
            this.label9.TabIndex = 26;
            this.label9.Text = "Customer Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(115, 562);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 29);
            this.label10.TabIndex = 25;
            this.label10.Text = "Customer Id:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(70, 524);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 29);
            this.label11.TabIndex = 24;
            this.label11.Text = "CUSTOMER";
            // 
            // txtProName
            // 
            this.txtProName.AcceptsReturn = true;
            this.txtProName.Location = new System.Drawing.Point(529, 714);
            this.txtProName.Multiline = true;
            this.txtProName.Name = "txtProName";
            this.txtProName.Size = new System.Drawing.Size(274, 32);
            this.txtProName.TabIndex = 33;
            // 
            // txtProID
            // 
            this.txtProID.Location = new System.Drawing.Point(529, 606);
            this.txtProID.Multiline = true;
            this.txtProID.Name = "txtProID";
            this.txtProID.Size = new System.Drawing.Size(274, 32);
            this.txtProID.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(524, 665);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 29);
            this.label4.TabIndex = 31;
            this.label4.Text = "Prodect Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(524, 562);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 29);
            this.label7.TabIndex = 30;
            this.label7.Text = "Prodect Id:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(479, 524);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 29);
            this.label8.TabIndex = 29;
            this.label8.Text = "PRODECT";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(529, 811);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(274, 26);
            this.dateTimePicker.TabIndex = 34;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(524, 760);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 29);
            this.label12.TabIndex = 35;
            this.label12.Text = "Oder Date:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1023, 578);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 26);
            this.label13.TabIndex = 36;
            this.label13.Text = "Price:";
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(1103, 580);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(162, 26);
            this.txtprice.TabIndex = 37;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(1103, 633);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(162, 26);
            this.txtQty.TabIndex = 39;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1023, 631);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 26);
            this.label14.TabIndex = 38;
            this.label14.Text = "Qty:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1103, 688);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(162, 26);
            this.textBox3.TabIndex = 41;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1023, 686);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 26);
            this.label15.TabIndex = 40;
            this.label15.Text = "Total:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(1193, 777);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(146, 55);
            this.btnUpdate.TabIndex = 43;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(983, 777);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(146, 55);
            this.btnSave.TabIndex = 42;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txt_ID
            // 
            this.txt_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ID.Location = new System.Drawing.Point(229, 453);
            this.txt_ID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ID.Multiline = true;
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(194, 35);
            this.txt_ID.TabIndex = 45;
            this.txt_ID.TextChanged += new System.EventHandler(this.txt_ID_TextChanged);
            // 
            // ROrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 893);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(label16);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.txtProName);
            this.Controls.Add(this.txtProID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCusN);
            this.Controls.Add(this.txtCusID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtSearchCUS);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSearchPRO);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewCus);
            this.Controls.Add(this.dataview);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ROrders";
            this.Text = "ROrders";
            this.Load += new System.EventHandler(this.ROrders_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataview;
        private System.Windows.Forms.DataGridView dataGridViewCus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_ID;
        public System.Windows.Forms.TextBox txtSearchPRO;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtSearchCUS;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtCusN;
        public System.Windows.Forms.TextBox txtCusID;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtProName;
        public System.Windows.Forms.TextBox txtProID;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.DateTimePicker dateTimePicker;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox txtprice;
        public System.Windows.Forms.TextBox txtQty;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnSave;
    }
}