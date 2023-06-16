namespace bilet_satis
{
    partial class SaleForm
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
            this.dataGridViewTicketList = new System.Windows.Forms.DataGridView();
            this.EventIDTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EventTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CustomerIDTB = new System.Windows.Forms.TextBox();
            this.Fiyat = new System.Windows.Forms.Label();
            this.PriceTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CustomerNameTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.QuantityTB = new System.Windows.Forms.TextBox();
            this.SaveBT = new System.Windows.Forms.Button();
            this.DeleteBT = new System.Windows.Forms.Button();
            this.EtkinlikFormBT = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewEventList = new System.Windows.Forms.DataGridView();
            this.DateTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ClearBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTicketList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTicketList
            // 
            this.dataGridViewTicketList.AllowUserToAddRows = false;
            this.dataGridViewTicketList.AllowUserToDeleteRows = false;
            this.dataGridViewTicketList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTicketList.Location = new System.Drawing.Point(27, 484);
            this.dataGridViewTicketList.Name = "dataGridViewTicketList";
            this.dataGridViewTicketList.Size = new System.Drawing.Size(1080, 233);
            this.dataGridViewTicketList.TabIndex = 100;
            this.dataGridViewTicketList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTicketList_CellContentClick);
            this.dataGridViewTicketList.SelectionChanged += new System.EventHandler(this.dataGridViewTicketList_SelectionChanged);
            // 
            // EventIDTB
            // 
            this.EventIDTB.Location = new System.Drawing.Point(240, 77);
            this.EventIDTB.Name = "EventIDTB";
            this.EventIDTB.Size = new System.Drawing.Size(200, 20);
            this.EventIDTB.TabIndex = 0;
            this.EventIDTB.Leave += new System.EventHandler(this.EventIDTB_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(78, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Etkinlik Kodu :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(121, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Etkinlik :";
            // 
            // EventTB
            // 
            this.EventTB.Location = new System.Drawing.Point(240, 115);
            this.EventTB.Name = "EventTB";
            this.EventTB.ReadOnly = true;
            this.EventTB.Size = new System.Drawing.Size(200, 20);
            this.EventTB.TabIndex = 1;
            this.EventTB.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(78, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Müşteri Kodu :";
            // 
            // CustomerIDTB
            // 
            this.CustomerIDTB.Location = new System.Drawing.Point(240, 273);
            this.CustomerIDTB.Name = "CustomerIDTB";
            this.CustomerIDTB.Size = new System.Drawing.Size(200, 20);
            this.CustomerIDTB.TabIndex = 10;
            this.CustomerIDTB.TextChanged += new System.EventHandler(this.CustomerIDTB_TextChanged);
            this.CustomerIDTB.Leave += new System.EventHandler(this.CustomerIDTB_Leave);
            // 
            // Fiyat
            // 
            this.Fiyat.AutoSize = true;
            this.Fiyat.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Fiyat.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Fiyat.Location = new System.Drawing.Point(141, 187);
            this.Fiyat.Name = "Fiyat";
            this.Fiyat.Size = new System.Drawing.Size(54, 20);
            this.Fiyat.TabIndex = 11;
            this.Fiyat.Text = "Fiyat :";
            // 
            // PriceTB
            // 
            this.PriceTB.Location = new System.Drawing.Point(240, 187);
            this.PriceTB.Name = "PriceTB";
            this.PriceTB.ReadOnly = true;
            this.PriceTB.Size = new System.Drawing.Size(200, 20);
            this.PriceTB.TabIndex = 3;
            this.PriceTB.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(34, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Müşteri Adı-Soyadı :";
            // 
            // CustomerNameTB
            // 
            this.CustomerNameTB.Location = new System.Drawing.Point(240, 308);
            this.CustomerNameTB.Name = "CustomerNameTB";
            this.CustomerNameTB.Size = new System.Drawing.Size(200, 20);
            this.CustomerNameTB.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label6.Location = new System.Drawing.Point(143, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Adet :";
            // 
            // QuantityTB
            // 
            this.QuantityTB.Location = new System.Drawing.Point(240, 345);
            this.QuantityTB.Name = "QuantityTB";
            this.QuantityTB.Size = new System.Drawing.Size(200, 20);
            this.QuantityTB.TabIndex = 12;
            // 
            // SaveBT
            // 
            this.SaveBT.BackColor = System.Drawing.Color.Salmon;
            this.SaveBT.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SaveBT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SaveBT.Location = new System.Drawing.Point(343, 385);
            this.SaveBT.Name = "SaveBT";
            this.SaveBT.Size = new System.Drawing.Size(100, 60);
            this.SaveBT.TabIndex = 14;
            this.SaveBT.Text = "Kayıt";
            this.SaveBT.UseVisualStyleBackColor = false;
            this.SaveBT.Click += new System.EventHandler(this.SaveBT_Click);
            // 
            // DeleteBT
            // 
            this.DeleteBT.BackColor = System.Drawing.Color.Salmon;
            this.DeleteBT.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DeleteBT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteBT.Location = new System.Drawing.Point(131, 385);
            this.DeleteBT.Name = "DeleteBT";
            this.DeleteBT.Size = new System.Drawing.Size(100, 60);
            this.DeleteBT.TabIndex = 13;
            this.DeleteBT.Text = "Sil";
            this.DeleteBT.UseVisualStyleBackColor = false;
            this.DeleteBT.Click += new System.EventHandler(this.DeleteBT_Click);
            // 
            // EtkinlikFormBT
            // 
            this.EtkinlikFormBT.BackColor = System.Drawing.Color.IndianRed;
            this.EtkinlikFormBT.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EtkinlikFormBT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EtkinlikFormBT.Location = new System.Drawing.Point(482, 36);
            this.EtkinlikFormBT.Name = "EtkinlikFormBT";
            this.EtkinlikFormBT.Size = new System.Drawing.Size(355, 34);
            this.EtkinlikFormBT.TabIndex = 21;
            this.EtkinlikFormBT.Text = "Yeni Etkinlik";
            this.EtkinlikFormBT.UseVisualStyleBackColor = false;
            this.EtkinlikFormBT.Click += new System.EventHandler(this.EtkinlikFormBT_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(859, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 369);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewEventList
            // 
            this.dataGridViewEventList.AllowUserToAddRows = false;
            this.dataGridViewEventList.AllowUserToDeleteRows = false;
            this.dataGridViewEventList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEventList.Location = new System.Drawing.Point(482, 77);
            this.dataGridViewEventList.Name = "dataGridViewEventList";
            this.dataGridViewEventList.Size = new System.Drawing.Size(355, 368);
            this.dataGridViewEventList.TabIndex = 26;
            this.dataGridViewEventList.SelectionChanged += new System.EventHandler(this.dataGridViewEventList_SelectionChanged);
            // 
            // DateTB
            // 
            this.DateTB.Location = new System.Drawing.Point(240, 152);
            this.DateTB.Name = "DateTB";
            this.DateTB.ReadOnly = true;
            this.DateTB.Size = new System.Drawing.Size(200, 20);
            this.DateTB.TabIndex = 2;
            this.DateTB.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Location = new System.Drawing.Point(138, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tarih :";
            // 
            // ClearBT
            // 
            this.ClearBT.BackColor = System.Drawing.Color.Salmon;
            this.ClearBT.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ClearBT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClearBT.Location = new System.Drawing.Point(237, 385);
            this.ClearBT.Name = "ClearBT";
            this.ClearBT.Size = new System.Drawing.Size(100, 60);
            this.ClearBT.TabIndex = 101;
            this.ClearBT.Text = "Yenile";
            this.ClearBT.UseVisualStyleBackColor = false;
            this.ClearBT.Click += new System.EventHandler(this.ClearBT_Click);
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1153, 791);
            this.Controls.Add(this.ClearBT);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridViewEventList);
            this.Controls.Add(this.EtkinlikFormBT);
            this.Controls.Add(this.DeleteBT);
            this.Controls.Add(this.SaveBT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.QuantityTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CustomerNameTB);
            this.Controls.Add(this.Fiyat);
            this.Controls.Add(this.PriceTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DateTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CustomerIDTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EventTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EventIDTB);
            this.Controls.Add(this.dataGridViewTicketList);
            this.Name = "SaleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilet Satış Formu";
            this.Load += new System.EventHandler(this.SaleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTicketList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTicketList;
        private System.Windows.Forms.TextBox EventIDTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EventTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CustomerIDTB;
        private System.Windows.Forms.Label Fiyat;
        private System.Windows.Forms.TextBox PriceTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CustomerNameTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox QuantityTB;
        private System.Windows.Forms.Button SaveBT;
        private System.Windows.Forms.Button DeleteBT;
        private System.Windows.Forms.Button EtkinlikFormBT;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewEventList;
        private System.Windows.Forms.TextBox DateTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ClearBT;
    }
}