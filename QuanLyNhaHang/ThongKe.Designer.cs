
namespace QuanLyNhaHang
{
    partial class ThongKe
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
            this.dtStart = new MetroFramework.Controls.MetroDateTime();
            this.dtEnd = new MetroFramework.Controls.MetroDateTime();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.colMaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDoanhThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colMaHD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGiamGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaBan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGioDen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coltongtien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTrangThai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonCustom3 = new QuanLyNhaHang.ButtonCustom();
            this.buttonCustom1 = new QuanLyNhaHang.ButtonCustom();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtStart
            // 
            this.dtStart.CalendarMonthBackground = System.Drawing.Color.OrangeRed;
            this.dtStart.CalendarTitleBackColor = System.Drawing.Color.OrangeRed;
            this.dtStart.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dtStart.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.dtStart.DisplayFocus = true;
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStart.Location = new System.Drawing.Point(54, 70);
            this.dtStart.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtStart.Name = "dtStart";
            this.dtStart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtStart.Size = new System.Drawing.Size(168, 29);
            this.dtStart.TabIndex = 0;
            this.dtStart.UseCustomBackColor = true;
            this.dtStart.UseCustomForeColor = true;
            this.dtStart.UseStyleColors = true;
            this.dtStart.UseWaitCursor = true;
            // 
            // dtEnd
            // 
            this.dtEnd.CalendarMonthBackground = System.Drawing.Color.OrangeRed;
            this.dtEnd.CalendarTitleBackColor = System.Drawing.Color.OrangeRed;
            this.dtEnd.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dtEnd.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.dtEnd.DisplayFocus = true;
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEnd.Location = new System.Drawing.Point(254, 70);
            this.dtEnd.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(168, 29);
            this.dtEnd.TabIndex = 1;
            this.dtEnd.UseCustomBackColor = true;
            this.dtEnd.UseCustomForeColor = true;
            this.dtEnd.UseStyleColors = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thống kê hóa đơn";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(461, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 49);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(511, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(505, 49);
            this.panel2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thống kê hóa đơn";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(22, 436);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(874, 151);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(681, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 15);
            this.label11.TabIndex = 8;
            this.label11.Text = "Tổng số nhóm món: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(681, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 15);
            this.label10.TabIndex = 7;
            this.label10.Text = "Tổng số món: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(447, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "Tổng số bàn: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(447, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Số lượng món bán được:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(31, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = ".................................................................";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(31, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tổng số tiền thu về: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(31, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tổng tiền giảm giá:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(31, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tổng tiền bán được:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(31, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tổng số hóa đơn: ";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaMon,
            this.colTenMon,
            this.colMaLoai,
            this.colSoLuong,
            this.colDoanhThu});
            this.dataGridView2.Location = new System.Drawing.Point(461, 160);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(435, 270);
            this.dataGridView2.TabIndex = 14;
            // 
            // colMaMon
            // 
            this.colMaMon.HeaderText = "Mã món";
            this.colMaMon.Name = "colMaMon";
            this.colMaMon.Width = 70;
            // 
            // colTenMon
            // 
            this.colTenMon.HeaderText = "Tên món";
            this.colTenMon.Name = "colTenMon";
            this.colTenMon.Width = 80;
            // 
            // colMaLoai
            // 
            this.colMaLoai.HeaderText = "Mã loại";
            this.colMaLoai.Name = "colMaLoai";
            this.colMaLoai.Width = 70;
            // 
            // colSoLuong
            // 
            this.colSoLuong.HeaderText = "Số lượng";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Width = 80;
            // 
            // colDoanhThu
            // 
            this.colDoanhThu.HeaderText = "Doanh thu";
            this.colDoanhThu.Name = "colDoanhThu";
            this.colDoanhThu.Width = 92;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(23, 109);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(435, 49);
            this.panel3.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 16);
            this.label12.TabIndex = 2;
            this.label12.Text = "Thống kê hóa đơn";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel4.Controls.Add(this.label13);
            this.panel4.Location = new System.Drawing.Point(511, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(505, 49);
            this.panel4.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 16);
            this.label13.TabIndex = 2;
            this.label13.Text = "Thống kê hóa đơn";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaHD,
            this.colGiamGia,
            this.colMaBan,
            this.colGioDen,
            this.coltongtien,
            this.colTrangThai,
            this.colMaNV});
            this.listView1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.Black;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(23, 160);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(435, 270);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colMaHD
            // 
            this.colMaHD.Text = "Mã HĐ";
            this.colMaHD.Width = 50;
            // 
            // colGiamGia
            // 
            this.colGiamGia.Text = "Giảm giá";
            this.colGiamGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colGiamGia.Width = 65;
            // 
            // colMaBan
            // 
            this.colMaBan.Text = "Mã bàn";
            this.colMaBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colGioDen
            // 
            this.colGioDen.Text = "Giờ đến";
            this.colGioDen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // coltongtien
            // 
            this.coltongtien.Text = "Tổng tiền";
            this.coltongtien.Width = 65;
            // 
            // colTrangThai
            // 
            this.colTrangThai.Text = "Trạng thái";
            this.colTrangThai.Width = 70;
            // 
            // colMaNV
            // 
            this.colMaNV.Text = "Mã NV";
            // 
            // buttonCustom3
            // 
            this.buttonCustom3.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonCustom3.FlatAppearance.BorderSize = 0;
            this.buttonCustom3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustom3.ForeColor = System.Drawing.Color.White;
            this.buttonCustom3.Location = new System.Drawing.Point(540, 65);
            this.buttonCustom3.Name = "buttonCustom3";
            this.buttonCustom3.Size = new System.Drawing.Size(121, 38);
            this.buttonCustom3.TabIndex = 18;
            this.buttonCustom3.Text = "Thống kê";
            this.buttonCustom3.UseVisualStyleBackColor = false;
            // 
            // buttonCustom1
            // 
            this.buttonCustom1.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonCustom1.FlatAppearance.BorderSize = 0;
            this.buttonCustom1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustom1.ForeColor = System.Drawing.Color.White;
            this.buttonCustom1.Location = new System.Drawing.Point(720, 65);
            this.buttonCustom1.Name = "buttonCustom1";
            this.buttonCustom1.Size = new System.Drawing.Size(121, 38);
            this.buttonCustom1.TabIndex = 19;
            this.buttonCustom1.Text = "Xuất File Excel";
            this.buttonCustom1.UseVisualStyleBackColor = false;
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 614);
            this.Controls.Add(this.buttonCustom1);
            this.Controls.Add(this.buttonCustom3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.dtStart);
            this.Name = "ThongKe";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroDateTime dtStart;
        private MetroFramework.Controls.MetroDateTime dtEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colMaHD;
        private System.Windows.Forms.ColumnHeader colGiamGia;
        private System.Windows.Forms.ColumnHeader colMaBan;
        private System.Windows.Forms.ColumnHeader colGioDen;
        private System.Windows.Forms.ColumnHeader coltongtien;
        private System.Windows.Forms.ColumnHeader colTrangThai;
        private System.Windows.Forms.ColumnHeader colMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDoanhThu;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ButtonCustom buttonCustom3;
        private ButtonCustom buttonCustom1;
    }
}

