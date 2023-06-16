namespace bilet_satis
{
    partial class EventForm
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
            this.LimitL = new System.Windows.Forms.Label();
            this.KontenjanTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IdTB = new System.Windows.Forms.TextBox();
            this.DeleteBT = new System.Windows.Forms.Button();
            this.SaveBT = new System.Windows.Forms.Button();
            this.dataGridViewEventList = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PictureSelectBT = new System.Windows.Forms.Button();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.DescriptionTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PriceTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.imagePathTB = new System.Windows.Forms.TextBox();
            this.NewEventBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LimitL
            // 
            this.LimitL.AutoSize = true;
            this.LimitL.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LimitL.ForeColor = System.Drawing.Color.SaddleBrown;
            this.LimitL.Location = new System.Drawing.Point(65, 206);
            this.LimitL.Name = "LimitL";
            this.LimitL.Size = new System.Drawing.Size(100, 21);
            this.LimitL.TabIndex = 19;
            this.LimitL.Text = "Kontenjan :";
            // 
            // KontenjanTB
            // 
            this.KontenjanTB.Location = new System.Drawing.Point(216, 209);
            this.KontenjanTB.Name = "KontenjanTB";
            this.KontenjanTB.Size = new System.Drawing.Size(200, 20);
            this.KontenjanTB.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Location = new System.Drawing.Point(105, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tarih :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(87, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Etkinlik :";
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(216, 92);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(200, 20);
            this.NameTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(42, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Etkinlik Kodu :";
            // 
            // IdTB
            // 
            this.IdTB.Location = new System.Drawing.Point(216, 50);
            this.IdTB.Name = "IdTB";
            this.IdTB.Size = new System.Drawing.Size(200, 20);
            this.IdTB.TabIndex = 0;
            // 
            // DeleteBT
            // 
            this.DeleteBT.BackColor = System.Drawing.Color.IndianRed;
            this.DeleteBT.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DeleteBT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteBT.Location = new System.Drawing.Point(58, 359);
            this.DeleteBT.Name = "DeleteBT";
            this.DeleteBT.Size = new System.Drawing.Size(104, 54);
            this.DeleteBT.TabIndex = 9;
            this.DeleteBT.Text = "Sil";
            this.DeleteBT.UseVisualStyleBackColor = false;
            this.DeleteBT.Click += new System.EventHandler(this.DeleteBT_Click);
            // 
            // SaveBT
            // 
            this.SaveBT.BackColor = System.Drawing.Color.IndianRed;
            this.SaveBT.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SaveBT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SaveBT.Location = new System.Drawing.Point(179, 359);
            this.SaveBT.Name = "SaveBT";
            this.SaveBT.Size = new System.Drawing.Size(104, 54);
            this.SaveBT.TabIndex = 11;
            this.SaveBT.Text = "Kayıt";
            this.SaveBT.UseVisualStyleBackColor = false;
            this.SaveBT.Click += new System.EventHandler(this.SaveBT_Click);
            // 
            // dataGridViewEventList
            // 
            this.dataGridViewEventList.AllowUserToAddRows = false;
            this.dataGridViewEventList.AllowUserToDeleteRows = false;
            this.dataGridViewEventList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEventList.Location = new System.Drawing.Point(25, 434);
            this.dataGridViewEventList.Name = "dataGridViewEventList";
            this.dataGridViewEventList.Size = new System.Drawing.Size(696, 171);
            this.dataGridViewEventList.TabIndex = 22;
            this.dataGridViewEventList.SelectionChanged += new System.EventHandler(this.dataGridViewEventList_SelectionChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(500, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 333);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // PictureSelectBT
            // 
            this.PictureSelectBT.BackColor = System.Drawing.Color.Salmon;
            this.PictureSelectBT.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PictureSelectBT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PictureSelectBT.Location = new System.Drawing.Point(522, 367);
            this.PictureSelectBT.Name = "PictureSelectBT";
            this.PictureSelectBT.Size = new System.Drawing.Size(177, 46);
            this.PictureSelectBT.TabIndex = 8;
            this.PictureSelectBT.Text = "Görsel Ekle";
            this.PictureSelectBT.UseVisualStyleBackColor = false;
            this.PictureSelectBT.Click += new System.EventHandler(this.PictureSelectBT_Click);
            // 
            // StartDate
            // 
            this.StartDate.CustomFormat = "dd.MM.yyyy";
            this.StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartDate.Location = new System.Drawing.Point(216, 168);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(89, 20);
            this.StartDate.TabIndex = 2;
            // 
            // EndDate
            // 
            this.EndDate.CustomFormat = "dd.MM.yyyy";
            this.EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndDate.Location = new System.Drawing.Point(327, 168);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(89, 20);
            this.EndDate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(74, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 28;
            this.label3.Text = "Açıklama :";
            // 
            // DescriptionTB
            // 
            this.DescriptionTB.Location = new System.Drawing.Point(216, 131);
            this.DescriptionTB.Name = "DescriptionTB";
            this.DescriptionTB.Size = new System.Drawing.Size(200, 20);
            this.DescriptionTB.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(107, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 30;
            this.label5.Text = "Fiyat :";
            // 
            // PriceTB
            // 
            this.PriceTB.Location = new System.Drawing.Point(216, 244);
            this.PriceTB.Name = "PriceTB";
            this.PriceTB.Size = new System.Drawing.Size(200, 20);
            this.PriceTB.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label6.Location = new System.Drawing.Point(95, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 21);
            this.label6.TabIndex = 32;
            this.label6.Text = "Görsel :";
            // 
            // imagePathTB
            // 
            this.imagePathTB.Location = new System.Drawing.Point(216, 284);
            this.imagePathTB.Name = "imagePathTB";
            this.imagePathTB.Size = new System.Drawing.Size(200, 20);
            this.imagePathTB.TabIndex = 7;
            // 
            // NewEventBT
            // 
            this.NewEventBT.BackColor = System.Drawing.Color.IndianRed;
            this.NewEventBT.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NewEventBT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NewEventBT.Location = new System.Drawing.Point(298, 359);
            this.NewEventBT.Name = "NewEventBT";
            this.NewEventBT.Size = new System.Drawing.Size(104, 54);
            this.NewEventBT.TabIndex = 10;
            this.NewEventBT.Text = "Yeni Kayıt";
            this.NewEventBT.UseVisualStyleBackColor = false;
            this.NewEventBT.Click += new System.EventHandler(this.NewEventBT_Click);
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(772, 632);
            this.Controls.Add(this.NewEventBT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.imagePathTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PriceTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DescriptionTB);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.PictureSelectBT);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridViewEventList);
            this.Controls.Add(this.DeleteBT);
            this.Controls.Add(this.SaveBT);
            this.Controls.Add(this.LimitL);
            this.Controls.Add(this.KontenjanTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IdTB);
            this.Name = "EventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Etkinlik Formu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LimitL;
        private System.Windows.Forms.TextBox KontenjanTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IdTB;
        private System.Windows.Forms.Button DeleteBT;
        private System.Windows.Forms.Button SaveBT;
        private System.Windows.Forms.DataGridView dataGridViewEventList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button PictureSelectBT;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.DateTimePicker EndDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DescriptionTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PriceTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox imagePathTB;
        private System.Windows.Forms.Button NewEventBT;
    }
}