namespace BTLINQ
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.txt_XuatXu = new System.Windows.Forms.TextBox();
            this.txt_DonGia = new System.Windows.Forms.TextBox();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.txt_TenSp = new System.Windows.Forms.TextBox();
            this.txt_MaSP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.data_TimKiem = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XuatXu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayHetHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_B = new System.Windows.Forms.TextBox();
            this.txt_A = new System.Windows.Forms.TextBox();
            this.btn_SP_A_B = new System.Windows.Forms.Button();
            this.btn_SP_QH = new System.Windows.Forms.Button();
            this.btn_SP_NB = new System.Windows.Forms.Button();
            this.btn_SP_DG = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.data_dsSP = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_Xoa_SP_QH = new System.Windows.Forms.Button();
            this.btn_Xoa_All_SP = new System.Windows.Forms.Button();
            this.btn_Check_QH = new System.Windows.Forms.Button();
            this.txt_XX_Xoa = new System.Windows.Forms.TextBox();
            this.btn_Xoa_XX = new System.Windows.Forms.Button();
            this.dt_NgayHetHan = new System.Windows.Forms.DateTimePicker();
            this.maSPCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSPCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xuatXuCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayHetHanCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_TimKiem)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_dsSP)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.dt_NgayHetHan);
            this.groupBox1.Controls.Add(this.btn_Xoa);
            this.groupBox1.Controls.Add(this.btn_Luu);
            this.groupBox1.Controls.Add(this.txt_XuatXu);
            this.groupBox1.Controls.Add(this.txt_DonGia);
            this.groupBox1.Controls.Add(this.txt_SoLuong);
            this.groupBox1.Controls.Add(this.txt_TenSp);
            this.groupBox1.Controls.Add(this.txt_MaSP);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 323);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin sản phẩm";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.SystemColors.Info;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(168, 260);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(93, 47);
            this.btn_Xoa.TabIndex = 12;
            this.btn_Xoa.Text = "Xóa SP";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.BackColor = System.Drawing.SystemColors.Info;
            this.btn_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.Location = new System.Drawing.Point(59, 260);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(93, 47);
            this.btn_Luu.TabIndex = 11;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = false;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // txt_XuatXu
            // 
            this.txt_XuatXu.Location = new System.Drawing.Point(126, 174);
            this.txt_XuatXu.Name = "txt_XuatXu";
            this.txt_XuatXu.Size = new System.Drawing.Size(207, 27);
            this.txt_XuatXu.TabIndex = 10;
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.Location = new System.Drawing.Point(126, 138);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Size = new System.Drawing.Size(207, 27);
            this.txt_DonGia.TabIndex = 10;
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Location = new System.Drawing.Point(126, 103);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(207, 27);
            this.txt_SoLuong.TabIndex = 9;
            // 
            // txt_TenSp
            // 
            this.txt_TenSp.Location = new System.Drawing.Point(126, 68);
            this.txt_TenSp.Name = "txt_TenSp";
            this.txt_TenSp.Size = new System.Drawing.Size(207, 27);
            this.txt_TenSp.TabIndex = 8;
            // 
            // txt_MaSP
            // 
            this.txt_MaSP.Location = new System.Drawing.Point(126, 32);
            this.txt_MaSP.Name = "txt_MaSP";
            this.txt_MaSP.Size = new System.Drawing.Size(207, 27);
            this.txt_MaSP.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ngày hết hạn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Xuất xứ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Đơn giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên SP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã SP";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.data_TimKiem);
            this.groupBox2.Controls.Add(this.txt_B);
            this.groupBox2.Controls.Add(this.txt_A);
            this.groupBox2.Controls.Add(this.btn_SP_A_B);
            this.groupBox2.Controls.Add(this.btn_SP_QH);
            this.groupBox2.Controls.Add(this.btn_SP_NB);
            this.groupBox2.Controls.Add(this.btn_SP_DG);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(418, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(686, 323);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn chức năng tìm kiếm";
            // 
            // data_TimKiem
            // 
            this.data_TimKiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_TimKiem.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_TimKiem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.data_TimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_TimKiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.SoLuong,
            this.DonGia,
            this.XuatXu,
            this.NgayHetHan});
            this.data_TimKiem.Location = new System.Drawing.Point(23, 109);
            this.data_TimKiem.Name = "data_TimKiem";
            this.data_TimKiem.RowHeadersVisible = false;
            this.data_TimKiem.RowHeadersWidth = 57;
            this.data_TimKiem.RowTemplate.Height = 24;
            this.data_TimKiem.Size = new System.Drawing.Size(657, 198);
            this.data_TimKiem.TabIndex = 6;
            // 
            // MaSP
            // 
            this.MaSP.HeaderText = "Mã SP";
            this.MaSP.MinimumWidth = 7;
            this.MaSP.Name = "MaSP";
            // 
            // TenSP
            // 
            this.TenSP.HeaderText = "Tên SP";
            this.TenSP.MinimumWidth = 7;
            this.TenSP.Name = "TenSP";
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 7;
            this.SoLuong.Name = "SoLuong";
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.MinimumWidth = 7;
            this.DonGia.Name = "DonGia";
            // 
            // XuatXu
            // 
            this.XuatXu.HeaderText = "Xuất xứ";
            this.XuatXu.MinimumWidth = 7;
            this.XuatXu.Name = "XuatXu";
            // 
            // NgayHetHan
            // 
            this.NgayHetHan.HeaderText = "Ngày hết hạn";
            this.NgayHetHan.MinimumWidth = 7;
            this.NgayHetHan.Name = "NgayHetHan";
            // 
            // txt_B
            // 
            this.txt_B.Location = new System.Drawing.Point(625, 51);
            this.txt_B.Name = "txt_B";
            this.txt_B.Size = new System.Drawing.Size(55, 27);
            this.txt_B.TabIndex = 5;
            // 
            // txt_A
            // 
            this.txt_A.Location = new System.Drawing.Point(562, 51);
            this.txt_A.Name = "txt_A";
            this.txt_A.Size = new System.Drawing.Size(57, 27);
            this.txt_A.TabIndex = 4;
            // 
            // btn_SP_A_B
            // 
            this.btn_SP_A_B.BackColor = System.Drawing.SystemColors.Info;
            this.btn_SP_A_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SP_A_B.Location = new System.Drawing.Point(390, 38);
            this.btn_SP_A_B.Name = "btn_SP_A_B";
            this.btn_SP_A_B.Size = new System.Drawing.Size(166, 59);
            this.btn_SP_A_B.TabIndex = 3;
            this.btn_SP_A_B.Text = "Xuất các sản phẩm có ĐG từ [a...b]";
            this.btn_SP_A_B.UseVisualStyleBackColor = false;
            this.btn_SP_A_B.Click += new System.EventHandler(this.btn_SP_A_B_Click);
            // 
            // btn_SP_QH
            // 
            this.btn_SP_QH.BackColor = System.Drawing.SystemColors.Info;
            this.btn_SP_QH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SP_QH.Location = new System.Drawing.Point(235, 38);
            this.btn_SP_QH.Name = "btn_SP_QH";
            this.btn_SP_QH.Size = new System.Drawing.Size(125, 59);
            this.btn_SP_QH.TabIndex = 2;
            this.btn_SP_QH.Text = "Xuất toàn bộ SP quá hạn";
            this.btn_SP_QH.UseVisualStyleBackColor = false;
            this.btn_SP_QH.Click += new System.EventHandler(this.btn_SP_QH_Click);
            // 
            // btn_SP_NB
            // 
            this.btn_SP_NB.BackColor = System.Drawing.SystemColors.Info;
            this.btn_SP_NB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SP_NB.Location = new System.Drawing.Point(136, 38);
            this.btn_SP_NB.Name = "btn_SP_NB";
            this.btn_SP_NB.Size = new System.Drawing.Size(93, 59);
            this.btn_SP_NB.TabIndex = 1;
            this.btn_SP_NB.Text = "1 SP đến từ NB";
            this.btn_SP_NB.UseVisualStyleBackColor = false;
            this.btn_SP_NB.Click += new System.EventHandler(this.btn_SP_NB_Click);
            // 
            // btn_SP_DG
            // 
            this.btn_SP_DG.BackColor = System.Drawing.SystemColors.Info;
            this.btn_SP_DG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SP_DG.Location = new System.Drawing.Point(23, 38);
            this.btn_SP_DG.Name = "btn_SP_DG";
            this.btn_SP_DG.Size = new System.Drawing.Size(107, 59);
            this.btn_SP_DG.TabIndex = 0;
            this.btn_SP_DG.Text = "1 SP có ĐG cao nhất";
            this.btn_SP_DG.UseVisualStyleBackColor = false;
            this.btn_SP_DG.Click += new System.EventHandler(this.btn_SP_DG_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox3.Controls.Add(this.data_dsSP);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(33, 406);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(677, 284);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách sản phẩm sau khi nhập";
            // 
            // data_dsSP
            // 
            this.data_dsSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_dsSP.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_dsSP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.data_dsSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_dsSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSPCol,
            this.tenSPCol,
            this.soLuongCol,
            this.donGiaCol,
            this.xuatXuCol,
            this.ngayHetHanCol});
            this.data_dsSP.Location = new System.Drawing.Point(10, 38);
            this.data_dsSP.Name = "data_dsSP";
            this.data_dsSP.RowHeadersVisible = false;
            this.data_dsSP.RowHeadersWidth = 57;
            this.data_dsSP.RowTemplate.Height = 24;
            this.data_dsSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_dsSP.Size = new System.Drawing.Size(646, 226);
            this.data_dsSP.TabIndex = 7;
            this.data_dsSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_dsSP_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox4.Controls.Add(this.btn_Xoa_SP_QH);
            this.groupBox4.Controls.Add(this.btn_Xoa_All_SP);
            this.groupBox4.Controls.Add(this.btn_Check_QH);
            this.groupBox4.Controls.Add(this.txt_XX_Xoa);
            this.groupBox4.Controls.Add(this.btn_Xoa_XX);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(716, 406);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(371, 284);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chọn thao tác";
            // 
            // btn_Xoa_SP_QH
            // 
            this.btn_Xoa_SP_QH.BackColor = System.Drawing.SystemColors.Info;
            this.btn_Xoa_SP_QH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa_SP_QH.Location = new System.Drawing.Point(181, 181);
            this.btn_Xoa_SP_QH.Name = "btn_Xoa_SP_QH";
            this.btn_Xoa_SP_QH.Size = new System.Drawing.Size(140, 61);
            this.btn_Xoa_SP_QH.TabIndex = 14;
            this.btn_Xoa_SP_QH.Text = "Xóa toàn bộ sản phẩm quá hạn";
            this.btn_Xoa_SP_QH.UseVisualStyleBackColor = false;
            this.btn_Xoa_SP_QH.Click += new System.EventHandler(this.btn_Xoa_SP_QH_Click);
            // 
            // btn_Xoa_All_SP
            // 
            this.btn_Xoa_All_SP.BackColor = System.Drawing.SystemColors.Info;
            this.btn_Xoa_All_SP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa_All_SP.Location = new System.Drawing.Point(33, 181);
            this.btn_Xoa_All_SP.Name = "btn_Xoa_All_SP";
            this.btn_Xoa_All_SP.Size = new System.Drawing.Size(140, 61);
            this.btn_Xoa_All_SP.TabIndex = 13;
            this.btn_Xoa_All_SP.Text = "Xóa toàn bộ SP trong kho";
            this.btn_Xoa_All_SP.UseVisualStyleBackColor = false;
            this.btn_Xoa_All_SP.Click += new System.EventHandler(this.btn_Xoa_All_SP_Click);
            // 
            // btn_Check_QH
            // 
            this.btn_Check_QH.BackColor = System.Drawing.SystemColors.Info;
            this.btn_Check_QH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Check_QH.Location = new System.Drawing.Point(66, 105);
            this.btn_Check_QH.Name = "btn_Check_QH";
            this.btn_Check_QH.Size = new System.Drawing.Size(223, 61);
            this.btn_Check_QH.TabIndex = 12;
            this.btn_Check_QH.Text = "Kiểm tra trong kho có sản phẩm quá hạn hay không";
            this.btn_Check_QH.UseVisualStyleBackColor = false;
            this.btn_Check_QH.Click += new System.EventHandler(this.btn_Check_QH_Click);
            // 
            // txt_XX_Xoa
            // 
            this.txt_XX_Xoa.Location = new System.Drawing.Point(176, 52);
            this.txt_XX_Xoa.Name = "txt_XX_Xoa";
            this.txt_XX_Xoa.Size = new System.Drawing.Size(113, 27);
            this.txt_XX_Xoa.TabIndex = 11;
            // 
            // btn_Xoa_XX
            // 
            this.btn_Xoa_XX.BackColor = System.Drawing.SystemColors.Info;
            this.btn_Xoa_XX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa_XX.Location = new System.Drawing.Point(20, 38);
            this.btn_Xoa_XX.Name = "btn_Xoa_XX";
            this.btn_Xoa_XX.Size = new System.Drawing.Size(140, 61);
            this.btn_Xoa_XX.TabIndex = 3;
            this.btn_Xoa_XX.Text = "Xóa SP theo xuất xứ bất kỳ:";
            this.btn_Xoa_XX.UseVisualStyleBackColor = false;
            this.btn_Xoa_XX.Click += new System.EventHandler(this.btn_Xoa_XX_Click);
            // 
            // dt_NgayHetHan
            // 
            this.dt_NgayHetHan.CustomFormat = "";
            this.dt_NgayHetHan.Location = new System.Drawing.Point(126, 216);
            this.dt_NgayHetHan.Name = "dt_NgayHetHan";
            this.dt_NgayHetHan.Size = new System.Drawing.Size(200, 27);
            this.dt_NgayHetHan.TabIndex = 13;
            // 
            // maSPCol
            // 
            this.maSPCol.HeaderText = "Mã SP";
            this.maSPCol.MinimumWidth = 7;
            this.maSPCol.Name = "maSPCol";
            // 
            // tenSPCol
            // 
            this.tenSPCol.HeaderText = "Tên SP";
            this.tenSPCol.MinimumWidth = 7;
            this.tenSPCol.Name = "tenSPCol";
            // 
            // soLuongCol
            // 
            this.soLuongCol.HeaderText = "Số Lượng";
            this.soLuongCol.MinimumWidth = 7;
            this.soLuongCol.Name = "soLuongCol";
            // 
            // donGiaCol
            // 
            this.donGiaCol.HeaderText = "Đơn giá";
            this.donGiaCol.MinimumWidth = 7;
            this.donGiaCol.Name = "donGiaCol";
            // 
            // xuatXuCol
            // 
            this.xuatXuCol.HeaderText = "Xuất xứ";
            this.xuatXuCol.MinimumWidth = 7;
            this.xuatXuCol.Name = "xuatXuCol";
            // 
            // ngayHetHanCol
            // 
            this.ngayHetHanCol.HeaderText = "Ngày hết hạn";
            this.ngayHetHanCol.MinimumWidth = 7;
            this.ngayHetHanCol.Name = "ngayHetHanCol";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(1116, 722);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "LINQ to OBJECT - Quản lý sản phẩm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_TimKiem)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_dsSP)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MaSP;
        private System.Windows.Forms.TextBox txt_XuatXu;
        private System.Windows.Forms.TextBox txt_DonGia;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.TextBox txt_TenSp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_SP_DG;
        private System.Windows.Forms.Button btn_SP_NB;
        private System.Windows.Forms.Button btn_SP_QH;
        private System.Windows.Forms.Button btn_SP_A_B;
        private System.Windows.Forms.TextBox txt_B;
        private System.Windows.Forms.TextBox txt_A;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.DataGridView data_TimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn XuatXu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayHetHan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView data_dsSP;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_Xoa_XX;
        private System.Windows.Forms.TextBox txt_XX_Xoa;
        private System.Windows.Forms.Button btn_Check_QH;
        private System.Windows.Forms.Button btn_Xoa_SP_QH;
        private System.Windows.Forms.Button btn_Xoa_All_SP;
        private System.Windows.Forms.DateTimePicker dt_NgayHetHan;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSPCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSPCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn xuatXuCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayHetHanCol;
    }
}

