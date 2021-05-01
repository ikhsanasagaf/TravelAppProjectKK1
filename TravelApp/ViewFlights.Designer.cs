namespace TravelApp
{
    partial class ViewFlights
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewFlights));
            this.FDate = new System.Windows.Forms.DateTimePicker();
            this.FcodeTb = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Seatnum = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.FlightDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DstCb = new System.Windows.Forms.ComboBox();
            this.SrcCb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.FlightDGV)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // FDate
            // 
            this.FDate.CalendarFont = new System.Drawing.Font("Airbnb Cereal App Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FDate.Font = new System.Drawing.Font("Airbnb Cereal App Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FDate.Location = new System.Drawing.Point(324, 182);
            this.FDate.Name = "FDate";
            this.FDate.Size = new System.Drawing.Size(137, 27);
            this.FDate.TabIndex = 33;
            // 
            // FcodeTb
            // 
            this.FcodeTb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FcodeTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FcodeTb.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FcodeTb.ForeColor = System.Drawing.Color.MidnightBlue;
            this.FcodeTb.Location = new System.Drawing.Point(191, 86);
            this.FcodeTb.Name = "FcodeTb";
            this.FcodeTb.Size = new System.Drawing.Size(127, 20);
            this.FcodeTb.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Location = new System.Drawing.Point(191, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(127, 1);
            this.panel2.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Airbnb Cereal App Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label4.Location = new System.Drawing.Point(369, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 21);
            this.label4.TabIndex = 25;
            this.label4.Text = "Asal      :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Airbnb Cereal App Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Location = new System.Drawing.Point(367, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 24;
            this.label3.Text = "Tujuan  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Airbnb Cereal App Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(125, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "Jadwal Keberangkatan  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Airbnb Cereal App Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label5.Location = new System.Drawing.Point(12, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 21);
            this.label5.TabIndex = 22;
            this.label5.Text = "Kode Penerbangan    :";
            // 
            // Seatnum
            // 
            this.Seatnum.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Seatnum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Seatnum.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seatnum.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Seatnum.Location = new System.Drawing.Point(191, 133);
            this.Seatnum.Name = "Seatnum";
            this.Seatnum.Size = new System.Drawing.Size(127, 20);
            this.Seatnum.TabIndex = 36;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Location = new System.Drawing.Point(191, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(127, 1);
            this.panel1.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Airbnb Cereal App Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label6.Location = new System.Drawing.Point(14, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 21);
            this.label6.TabIndex = 34;
            this.label6.Text = "Jumlah Kursi               :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.AliceBlue;
            this.button1.Location = new System.Drawing.Point(52, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 28);
            this.button1.TabIndex = 38;
            this.button1.Text = "Ubah";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.AliceBlue;
            this.button2.Location = new System.Drawing.Point(456, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 28);
            this.button2.TabIndex = 39;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.ForeColor = System.Drawing.Color.AliceBlue;
            this.button3.Location = new System.Drawing.Point(255, 235);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 28);
            this.button3.TabIndex = 40;
            this.button3.Text = "Hapus";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FlightDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.FlightDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.FlightDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FlightDGV.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.FlightDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FlightDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.FlightDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Airbnb Cereal App Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FlightDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.FlightDGV.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Airbnb Cereal App Book", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FlightDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.FlightDGV.EnableHeadersVisualStyles = false;
            this.FlightDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.FlightDGV.Location = new System.Drawing.Point(12, 290);
            this.FlightDGV.Name = "FlightDGV";
            this.FlightDGV.RowHeadersVisible = false;
            this.FlightDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FlightDGV.Size = new System.Drawing.Size(609, 202);
            this.FlightDGV.TabIndex = 73;
            this.FlightDGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.FlightDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.FlightDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.FlightDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.FlightDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.FlightDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.FlightDGV.ThemeStyle.BackColor = System.Drawing.Color.AliceBlue;
            this.FlightDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.FlightDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.RoyalBlue;
            this.FlightDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.FlightDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Airbnb Cereal App Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FlightDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.FlightDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.FlightDGV.ThemeStyle.HeaderStyle.Height = 25;
            this.FlightDGV.ThemeStyle.ReadOnly = false;
            this.FlightDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.FlightDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.FlightDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Airbnb Cereal App Book", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FlightDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.FlightDGV.ThemeStyle.RowsStyle.Height = 22;
            this.FlightDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.FlightDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.FlightDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FlightDGV_CellContentClick);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel6.Controls.Add(this.pictureBox3);
            this.panel6.Controls.Add(this.pictureBox2);
            this.panel6.Controls.Add(this.pictureBox6);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(633, 32);
            this.panel6.TabIndex = 76;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(584, 13);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(17, 17);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 76;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
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
            this.pictureBox2.TabIndex = 55;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(607, 8);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(17, 17);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 77;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Airbnb Cereal App", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.AliceBlue;
            this.label8.Location = new System.Drawing.Point(242, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 19);
            this.label8.TabIndex = 50;
            this.label8.Text = "-Daftar Penerbangan-";
            // 
            // DstCb
            // 
            this.DstCb.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DstCb.ForeColor = System.Drawing.Color.MidnightBlue;
            this.DstCb.FormattingEnabled = true;
            this.DstCb.Items.AddRange(new object[] {
            "JAKARTA",
            "BALI",
            "DUBAI",
            "MUMBAI",
            "BANGKOK",
            "MANILA",
            "KUALA LUMPUR",
            "SINGAPURA",
            " "});
            this.DstCb.Location = new System.Drawing.Point(444, 134);
            this.DstCb.Name = "DstCb";
            this.DstCb.Size = new System.Drawing.Size(137, 22);
            this.DstCb.TabIndex = 81;
            // 
            // SrcCb
            // 
            this.SrcCb.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SrcCb.ForeColor = System.Drawing.Color.MidnightBlue;
            this.SrcCb.FormattingEnabled = true;
            this.SrcCb.Items.AddRange(new object[] {
            "JAKARTA",
            "BALI",
            "DUBAI",
            "MUMBAI",
            "BANGKOK",
            "MANILA",
            "KUALA LUMPUR",
            "SINGAPURA",
            " "});
            this.SrcCb.Location = new System.Drawing.Point(444, 88);
            this.SrcCb.Name = "SrcCb";
            this.SrcCb.Size = new System.Drawing.Size(137, 22);
            this.SrcCb.TabIndex = 80;
            // 
            // ViewFlights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(633, 504);
            this.Controls.Add(this.DstCb);
            this.Controls.Add(this.SrcCb);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.FlightDGV);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Seatnum);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FDate);
            this.Controls.Add(this.FcodeTb);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewFlights";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewFlights";
            this.Load += new System.EventHandler(this.ViewFlights_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FlightDGV)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker FDate;
        private System.Windows.Forms.TextBox FcodeTb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Seatnum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private Guna.UI2.WinForms.Guna2DataGridView FlightDGV;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox DstCb;
        private System.Windows.Forms.ComboBox SrcCb;
    }
}