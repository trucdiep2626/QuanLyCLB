namespace QuanLyCLB
{
    partial class QLHocSinh
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
            this.dGVDSHocSinh = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMaLop = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btSua = new System.Windows.Forms.Button();
            this.btHienThi = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.cbML = new System.Windows.Forms.ComboBox();
            this.txtTenL = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDSHocSinh)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVDSHocSinh
            // 
            this.dGVDSHocSinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGVDSHocSinh.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGVDSHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDSHocSinh.Location = new System.Drawing.Point(464, 37);
            this.dGVDSHocSinh.Name = "dGVDSHocSinh";
            this.dGVDSHocSinh.RowHeadersVisible = false;
            this.dGVDSHocSinh.RowHeadersWidth = 62;
            this.dGVDSHocSinh.RowTemplate.Height = 28;
            this.dGVDSHocSinh.Size = new System.Drawing.Size(527, 372);
            this.dGVDSHocSinh.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Chức vụ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mã SV :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên lớp :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã lớp :";
            // 
            // cbMaLop
            // 
            this.cbMaLop.FormattingEnabled = true;
            this.cbMaLop.Location = new System.Drawing.Point(147, 40);
            this.cbMaLop.Name = "cbMaLop";
            this.cbMaLop.Size = new System.Drawing.Size(151, 28);
            this.cbMaLop.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(459, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Danh sách :";
            // 
            // btSua
            // 
            this.btSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Location = new System.Drawing.Point(131, 297);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 45);
            this.btSua.TabIndex = 25;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btHienThi
            // 
            this.btHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHienThi.Location = new System.Drawing.Point(331, 297);
            this.btHienThi.Name = "btHienThi";
            this.btHienThi.Size = new System.Drawing.Size(105, 45);
            this.btHienThi.TabIndex = 24;
            this.btHienThi.Text = "Hiển Thị";
            this.btHienThi.UseVisualStyleBackColor = true;
            this.btHienThi.Click += new System.EventHandler(this.btHienThi_Click);
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(231, 297);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 45);
            this.btXoa.TabIndex = 23;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(31, 297);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 45);
            this.btThem.TabIndex = 22;
            this.btThem.Text = "Thêm ";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // txtTenLop
            // 
            this.txtTenLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLop.Location = new System.Drawing.Point(147, 90);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(262, 30);
            this.txtTenLop.TabIndex = 26;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSV.Location = new System.Drawing.Point(147, 140);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(262, 30);
            this.txtMaSV.TabIndex = 27;
            // 
            // txtChucVu
            // 
            this.txtChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChucVu.Location = new System.Drawing.Point(147, 190);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(262, 30);
            this.txtChucVu.TabIndex = 28;
            // 
            // cbML
            // 
            this.cbML.FormattingEnabled = true;
            this.cbML.Location = new System.Drawing.Point(147, 41);
            this.cbML.Name = "cbML";
            this.cbML.Size = new System.Drawing.Size(151, 28);
            this.cbML.TabIndex = 9;
            this.cbML.SelectedIndexChanged += new System.EventHandler(this.cbML_SelectedIndexChanged);
            // 
            // txtTenL
            // 
            this.txtTenL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenL.Location = new System.Drawing.Point(147, 91);
            this.txtTenL.Name = "txtTenL";
            this.txtTenL.Size = new System.Drawing.Size(262, 30);
            this.txtTenL.TabIndex = 26;
            // 
            // QLHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 441);
            this.Controls.Add(this.txtChucVu);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.txtTenL);
            this.Controls.Add(this.txtTenLop);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btHienThi);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbML);
            this.Controls.Add(this.cbMaLop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dGVDSHocSinh);
            this.Name = "QLHocSinh";
            this.Text = "QLHocSinh";
            this.Load += new System.EventHandler(this.QLHocSinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVDSHocSinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVDSHocSinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMaLop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btHienThi;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.ComboBox cbML;
        private System.Windows.Forms.TextBox txtTenL;
    }
}