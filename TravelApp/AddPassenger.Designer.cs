namespace TravelApp
{
    partial class AddPassenger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPassenger));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NationalityCb = new System.Windows.Forms.ComboBox();
            this.PassName = new System.Windows.Forms.TextBox();
            this.PhoneTb = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PassId = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.PassportTb = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.PassAd = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GenderCb = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.AliceBlue;
            this.button2.Location = new System.Drawing.Point(372, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 28);
            this.button2.TabIndex = 36;
            this.button2.Text = "Lihat Penumpang";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.AliceBlue;
            this.button1.Location = new System.Drawing.Point(103, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 28);
            this.button1.TabIndex = 35;
            this.button1.Text = "Tambah";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Airbnb Cereal App Book", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(53, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 16);
            this.label7.TabIndex = 34;
            this.label7.Text = "Clear";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(433, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 308);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // NationalityCb
            // 
            this.NationalityCb.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NationalityCb.ForeColor = System.Drawing.Color.MidnightBlue;
            this.NationalityCb.FormattingEnabled = true;
            this.NationalityCb.Items.AddRange(new object[] {
            "INDONESIA",
            "CHINA",
            "JEPANG",
            "MALAYSIA",
            "SINGAPURA",
            "VIETNAM",
            "FILIPINA",
            "THAILAND",
            " "});
            this.NationalityCb.Location = new System.Drawing.Point(242, 231);
            this.NationalityCb.Name = "NationalityCb";
            this.NationalityCb.Size = new System.Drawing.Size(158, 22);
            this.NationalityCb.TabIndex = 32;
            // 
            // PassName
            // 
            this.PassName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PassName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PassName.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.PassName.Location = new System.Drawing.Point(245, 111);
            this.PassName.Name = "PassName";
            this.PassName.Size = new System.Drawing.Size(163, 20);
            this.PassName.TabIndex = 30;
            // 
            // PhoneTb
            // 
            this.PhoneTb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PhoneTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PhoneTb.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneTb.ForeColor = System.Drawing.Color.MidnightBlue;
            this.PhoneTb.Location = new System.Drawing.Point(243, 310);
            this.PhoneTb.Name = "PhoneTb";
            this.PhoneTb.Size = new System.Drawing.Size(163, 20);
            this.PhoneTb.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Location = new System.Drawing.Point(243, 333);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 1);
            this.panel1.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Location = new System.Drawing.Point(245, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(163, 1);
            this.panel2.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Airbnb Cereal App Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label6.Location = new System.Drawing.Point(50, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 21);
            this.label6.TabIndex = 26;
            this.label6.Text = "Nomor Telepon            :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Airbnb Cereal App Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Location = new System.Drawing.Point(51, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 21);
            this.label3.TabIndex = 24;
            this.label3.Text = "Negara Asal                  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Airbnb Cereal App Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label5.Location = new System.Drawing.Point(51, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 21);
            this.label5.TabIndex = 22;
            this.label5.Text = "Nama Penumpang       :";
            // 
            // PassId
            // 
            this.PassId.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PassId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PassId.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassId.ForeColor = System.Drawing.Color.MidnightBlue;
            this.PassId.Location = new System.Drawing.Point(246, 75);
            this.PassId.Name = "PassId";
            this.PassId.Size = new System.Drawing.Size(163, 20);
            this.PassId.TabIndex = 41;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Location = new System.Drawing.Point(246, 98);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(163, 1);
            this.panel3.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Airbnb Cereal App Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label8.Location = new System.Drawing.Point(52, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 21);
            this.label8.TabIndex = 39;
            this.label8.Text = "Id Penumpang              :";
            // 
            // PassportTb
            // 
            this.PassportTb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PassportTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PassportTb.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassportTb.ForeColor = System.Drawing.Color.MidnightBlue;
            this.PassportTb.Location = new System.Drawing.Point(244, 148);
            this.PassportTb.Name = "PassportTb";
            this.PassportTb.Size = new System.Drawing.Size(163, 20);
            this.PassportTb.TabIndex = 44;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel4.Location = new System.Drawing.Point(244, 171);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(163, 1);
            this.panel4.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Airbnb Cereal App Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label4.Location = new System.Drawing.Point(50, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 21);
            this.label4.TabIndex = 42;
            this.label4.Text = "Nomor Passport           :";
            // 
            // PassAd
            // 
            this.PassAd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PassAd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PassAd.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassAd.ForeColor = System.Drawing.Color.MidnightBlue;
            this.PassAd.Location = new System.Drawing.Point(243, 187);
            this.PassAd.Name = "PassAd";
            this.PassAd.Size = new System.Drawing.Size(163, 20);
            this.PassAd.TabIndex = 47;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel5.Location = new System.Drawing.Point(243, 210);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(163, 1);
            this.panel5.TabIndex = 46;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Airbnb Cereal App Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label9.Location = new System.Drawing.Point(48, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(180, 21);
            this.label9.TabIndex = 45;
            this.label9.Text = "Alamat Penumpang     :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Airbnb Cereal App Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(48, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 21);
            this.label2.TabIndex = 48;
            this.label2.Text = "Jenis Kelamin                :";
            // 
            // GenderCb
            // 
            this.GenderCb.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderCb.ForeColor = System.Drawing.Color.MidnightBlue;
            this.GenderCb.FormattingEnabled = true;
            this.GenderCb.Items.AddRange(new object[] {
            "PRIA",
            "WANITA",
            " "});
            this.GenderCb.Location = new System.Drawing.Point(242, 270);
            this.GenderCb.Name = "GenderCb";
            this.GenderCb.Size = new System.Drawing.Size(158, 22);
            this.GenderCb.TabIndex = 49;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Airbnb Cereal App", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.AliceBlue;
            this.label10.Location = new System.Drawing.Point(234, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 19);
            this.label10.TabIndex = 50;
            this.label10.Text = "-Tambah Penumpang-";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel6.Controls.Add(this.pictureBox2);
            this.panel6.Controls.Add(this.pictureBox5);
            this.panel6.Controls.Add(this.pictureBox4);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(633, 32);
            this.panel6.TabIndex = 51;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(17, 17);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 54;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(581, 13);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(17, 17);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 52;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(604, 8);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(17, 17);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 52;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // AddPassenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(633, 460);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.GenderCb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PassAd);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PassportTb);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PassId);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NationalityCb);
            this.Controls.Add(this.PassName);
            this.Controls.Add(this.PhoneTb);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddPassenger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPassenger";
            this.Load += new System.EventHandler(this.AddPassenger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox NationalityCb;
        private System.Windows.Forms.TextBox PassName;
        private System.Windows.Forms.TextBox PhoneTb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PassId;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PassportTb;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PassAd;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox GenderCb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}