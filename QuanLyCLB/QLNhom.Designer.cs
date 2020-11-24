namespace QuanLyCLB
{
    partial class QLNhom
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
            this.btSua = new System.Windows.Forms.Button();
            this.btHienThi = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dGVDSNhom = new System.Windows.Forms.DataGridView();
            this.txtTruongNhom = new System.Windows.Forms.TextBox();
            this.txtSLTV = new System.Windows.Forms.TextBox();
            this.txtTenNhom = new System.Windows.Forms.TextBox();
            this.cbMaNhom = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDSNhom)).BeginInit();
            this.SuspendLayout();
            // 
            // btSua
            // 
            this.btSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Location = new System.Drawing.Point(127, 298);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 45);
            this.btSua.TabIndex = 31;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            // 
            // btHienThi
            // 
            this.btHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHienThi.Location = new System.Drawing.Point(327, 298);
            this.btHienThi.Name = "btHienThi";
            this.btHienThi.Size = new System.Drawing.Size(105, 45);
            this.btHienThi.TabIndex = 30;
            this.btHienThi.Text = "Hiển Thị";
            this.btHienThi.UseVisualStyleBackColor = true;
            this.btHienThi.Click += new System.EventHandler(this.btHienThi_Click);
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(227, 298);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 45);
            this.btXoa.TabIndex = 29;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(27, 298);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 45);
            this.btThem.TabIndex = 28;
            this.btThem.Text = "Thêm ";
            this.btThem.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(471, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "Danh sách :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Trưởng nhóm :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Số lượng thành viên  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tên nhóm :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Mã nhóm :";
            // 
            // dGVDSNhom
            // 
            this.dGVDSNhom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDSNhom.Location = new System.Drawing.Point(463, 48);
            this.dGVDSNhom.Name = "dGVDSNhom";
            this.dGVDSNhom.RowHeadersWidth = 62;
            this.dGVDSNhom.RowTemplate.Height = 28;
            this.dGVDSNhom.Size = new System.Drawing.Size(527, 372);
            this.dGVDSNhom.TabIndex = 22;
            // 
            // txtTruongNhom
            // 
            this.txtTruongNhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTruongNhom.Location = new System.Drawing.Point(170, 200);
            this.txtTruongNhom.Name = "txtTruongNhom";
            this.txtTruongNhom.Size = new System.Drawing.Size(262, 30);
            this.txtTruongNhom.TabIndex = 35;
            // 
            // txtSLTV
            // 
            this.txtSLTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLTV.Location = new System.Drawing.Point(254, 150);
            this.txtSLTV.Name = "txtSLTV";
            this.txtSLTV.Size = new System.Drawing.Size(178, 30);
            this.txtSLTV.TabIndex = 34;
            // 
            // txtTenNhom
            // 
            this.txtTenNhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNhom.Location = new System.Drawing.Point(170, 101);
            this.txtTenNhom.Name = "txtTenNhom";
            this.txtTenNhom.Size = new System.Drawing.Size(262, 30);
            this.txtTenNhom.TabIndex = 33;
            // 
            // cbMaNhom
            // 
            this.cbMaNhom.FormattingEnabled = true;
            this.cbMaNhom.Location = new System.Drawing.Point(281, 52);
            this.cbMaNhom.Name = "cbMaNhom";
            this.cbMaNhom.Size = new System.Drawing.Size(151, 28);
            this.cbMaNhom.TabIndex = 32;
            // 
            // QLNhom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 441);
            this.Controls.Add(this.txtTruongNhom);
            this.Controls.Add(this.txtSLTV);
            this.Controls.Add(this.txtTenNhom);
            this.Controls.Add(this.cbMaNhom);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btHienThi);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dGVDSNhom);
            this.Name = "QLNhom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLNhom";
            ((System.ComponentModel.ISupportInitialize)(this.dGVDSNhom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btHienThi;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGVDSNhom;
        private System.Windows.Forms.TextBox txtTruongNhom;
        private System.Windows.Forms.TextBox txtSLTV;
        private System.Windows.Forms.TextBox txtTenNhom;
        private System.Windows.Forms.ComboBox cbMaNhom;
    }
}