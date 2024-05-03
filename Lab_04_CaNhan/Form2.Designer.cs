using System.Drawing;
using System.Windows.Forms;

namespace Lab_04_CaNhan
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mANVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hOTENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lUONGDataGridViewImageColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPSELENCRYPTNHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSVDataSet1 = new Lab_04_CaNhan.QLSVDataSet1();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSVDataSet = new Lab_04_CaNhan.QLSVDataSet();
            this.nHANVIENTableAdapter = new Lab_04_CaNhan.QLSVDataSetTableAdapters.NHANVIENTableAdapter();
            this.button_Them = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_Sua = new System.Windows.Forms.Button();
            this.button_Ghi = new System.Windows.Forms.Button();
            this.button_Thoat = new System.Windows.Forms.Button();
            this.sP_SEL_ENCRYPT_NHANVIENTableAdapter = new Lab_04_CaNhan.QLSVDataSet1TableAdapters.SP_SEL_ENCRYPT_NHANVIENTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPSELENCRYPTNHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH MỤC NHÂN VIÊN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(69, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã nhân viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(69, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(69, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên đăng nhập:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(411, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Họ tên:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(411, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Lương:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label8.Location = new System.Drawing.Point(411, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Mật khẩu: ";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(168, 34);
            this.txtMa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(214, 20);
            this.txtMa.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(168, 65);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(214, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // txtTenDN
            // 
            this.txtTenDN.Location = new System.Drawing.Point(168, 94);
            this.txtTenDN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(214, 20);
            this.txtTenDN.TabIndex = 12;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(477, 34);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(214, 20);
            this.txtHoTen.TabIndex = 9;
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(477, 65);
            this.txtLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(214, 20);
            this.txtLuong.TabIndex = 11;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(477, 94);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(214, 20);
            this.txtMatKhau.TabIndex = 13;
            this.txtMatKhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatKhau_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMa);
            this.groupBox1.Controls.Add(this.txtMatKhau);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtLuong);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTenDN);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(89, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(831, 144);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(89, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(831, 161);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mANVDataGridViewTextBoxColumn,
            this.hOTENDataGridViewTextBoxColumn,
            this.eMAILDataGridViewTextBoxColumn,
            this.lUONGDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.sPSELENCRYPTNHANVIENBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(825, 142);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // mANVDataGridViewTextBoxColumn
            // 
            this.mANVDataGridViewTextBoxColumn.DataPropertyName = "MANV";
            this.mANVDataGridViewTextBoxColumn.HeaderText = "MANV";
            this.mANVDataGridViewTextBoxColumn.Name = "mANVDataGridViewTextBoxColumn";
            this.mANVDataGridViewTextBoxColumn.Width = 120;
            // 
            // hOTENDataGridViewTextBoxColumn
            // 
            this.hOTENDataGridViewTextBoxColumn.DataPropertyName = "HOTEN";
            this.hOTENDataGridViewTextBoxColumn.HeaderText = "HOTEN";
            this.hOTENDataGridViewTextBoxColumn.Name = "hOTENDataGridViewTextBoxColumn";
            this.hOTENDataGridViewTextBoxColumn.Width = 200;
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            this.eMAILDataGridViewTextBoxColumn.Width = 200;
            // 
            // lUONGDataGridViewImageColumn
            // 
            this.lUONGDataGridViewImageColumn.DataPropertyName = "LUONG";
            this.lUONGDataGridViewImageColumn.HeaderText = "LUONG";
            this.lUONGDataGridViewImageColumn.Name = "lUONGDataGridViewImageColumn";
            this.lUONGDataGridViewImageColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.lUONGDataGridViewImageColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.lUONGDataGridViewImageColumn.Width = 270;
            // 
            // sPSELENCRYPTNHANVIENBindingSource
            // 
            this.sPSELENCRYPTNHANVIENBindingSource.DataMember = "SP_SEL_ENCRYPT_NHANVIEN";
            this.sPSELENCRYPTNHANVIENBindingSource.DataSource = this.qLSVDataSet1;
            // 
            // qLSVDataSet1
            // 
            this.qLSVDataSet1.DataSetName = "QLSVDataSet1";
            this.qLSVDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource.DataSource = this.qLSVDataSet;
            // 
            // qLSVDataSet
            // 
            this.qLSVDataSet.DataSetName = "QLSVDataSet";
            this.qLSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // button_Them
            // 
            this.button_Them.Location = new System.Drawing.Point(143, 404);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(90, 24);
            this.button_Them.TabIndex = 16;
            this.button_Them.Text = "Thêm";
            this.button_Them.UseVisualStyleBackColor = true;
            this.button_Them.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Xoa
            // 
            this.button_Xoa.Location = new System.Drawing.Point(320, 405);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(75, 23);
            this.button_Xoa.TabIndex = 17;
            this.button_Xoa.Text = "Xoá";
            this.button_Xoa.UseVisualStyleBackColor = true;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // button_Sua
            // 
            this.button_Sua.Location = new System.Drawing.Point(483, 404);
            this.button_Sua.Name = "button_Sua";
            this.button_Sua.Size = new System.Drawing.Size(75, 23);
            this.button_Sua.TabIndex = 19;
            this.button_Sua.Text = "Sửa";
            this.button_Sua.UseVisualStyleBackColor = true;
            // 
            // button_Ghi
            // 
            this.button_Ghi.Location = new System.Drawing.Point(663, 405);
            this.button_Ghi.Name = "button_Ghi";
            this.button_Ghi.Size = new System.Drawing.Size(75, 23);
            this.button_Ghi.TabIndex = 20;
            this.button_Ghi.Text = "Ghi/Lưu";
            this.button_Ghi.UseVisualStyleBackColor = true;
            this.button_Ghi.Click += new System.EventHandler(this.button_Ghi_Click);
            // 
            // button_Thoat
            // 
            this.button_Thoat.Location = new System.Drawing.Point(819, 405);
            this.button_Thoat.Name = "button_Thoat";
            this.button_Thoat.Size = new System.Drawing.Size(75, 23);
            this.button_Thoat.TabIndex = 21;
            this.button_Thoat.Text = "Thoát";
            this.button_Thoat.UseVisualStyleBackColor = true;
            this.button_Thoat.Click += new System.EventHandler(this.button_Thoat_Click);
            // 
            // sP_SEL_ENCRYPT_NHANVIENTableAdapter
            // 
            this.sP_SEL_ENCRYPT_NHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 489);
            this.Controls.Add(this.button_Thoat);
            this.Controls.Add(this.button_Ghi);
            this.Controls.Add(this.button_Sua);
            this.Controls.Add(this.button_Xoa);
            this.Controls.Add(this.button_Them);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPSELENCRYPTNHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtMa;
        private TextBox txtEmail;
        private TextBox txtTenDN;
        private TextBox txtHoTen;
        private TextBox txtLuong;
        private TextBox txtMatKhau;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private QLSVDataSet qLSVDataSet;
        private BindingSource nHANVIENBindingSource;
        private QLSVDataSetTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private Button button_Them;
        private Button button_Xoa;
        private Button button_Sua;
        private Button button_Ghi;
        private Button button_Thoat;
        private QLSVDataSet1 qLSVDataSet1;
        private BindingSource sPSELENCRYPTNHANVIENBindingSource;
        private QLSVDataSet1TableAdapters.SP_SEL_ENCRYPT_NHANVIENTableAdapter sP_SEL_ENCRYPT_NHANVIENTableAdapter;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn mANVDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hOTENDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lUONGDataGridViewImageColumn;
    }
}