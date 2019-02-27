namespace thuctapnhom_quanlinhahang
{
    partial class DSmonan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DSmonan));
            this.data_dsmonan = new System.Windows.Forms.DataGridView();
            this.txt_id_hoadon_dsmonan = new System.Windows.Forms.TextBox();
            this.txt_khachhang_dsmonan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tooltrp_reset_dsmonan = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tooltrp_insert_dsmonan = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tooltrp_update_dsmonan = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_chucnang_dsmonan = new System.Windows.Forms.Button();
            this.btn_huy_dsmonan = new System.Windows.Forms.Button();
            this.cb_loaimonan = new System.Windows.Forms.ComboBox();
            this.loaimonanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlinhahangDataSet6 = new thuctapnhom_quanlinhahang.quanlinhahangDataSet6();
            this.cb_monan = new System.Windows.Forms.ComboBox();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_sobanan = new System.Windows.Forms.TextBox();
            this.txt_thanhtien = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.loai_mon_anTableAdapter = new thuctapnhom_quanlinhahang.quanlinhahangDataSet6TableAdapters.loai_mon_anTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.data_dsmonan)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loaimonanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlinhahangDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // data_dsmonan
            // 
            this.data_dsmonan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_dsmonan.BackgroundColor = System.Drawing.SystemColors.Window;
            this.data_dsmonan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_dsmonan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.data_dsmonan.Location = new System.Drawing.Point(0, 230);
            this.data_dsmonan.Name = "data_dsmonan";
            this.data_dsmonan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_dsmonan.Size = new System.Drawing.Size(800, 220);
            this.data_dsmonan.TabIndex = 0;
            this.data_dsmonan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_dsmonan_CellClick);
            // 
            // txt_id_hoadon_dsmonan
            // 
            this.txt_id_hoadon_dsmonan.Location = new System.Drawing.Point(127, 83);
            this.txt_id_hoadon_dsmonan.Name = "txt_id_hoadon_dsmonan";
            this.txt_id_hoadon_dsmonan.Size = new System.Drawing.Size(143, 20);
            this.txt_id_hoadon_dsmonan.TabIndex = 1;
            // 
            // txt_khachhang_dsmonan
            // 
            this.txt_khachhang_dsmonan.Location = new System.Drawing.Point(413, 83);
            this.txt_khachhang_dsmonan.Name = "txt_khachhang_dsmonan";
            this.txt_khachhang_dsmonan.Size = new System.Drawing.Size(141, 20);
            this.txt_khachhang_dsmonan.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã hóa đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên khách hàng";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator6,
            this.tooltrp_reset_dsmonan,
            this.toolStripSeparator4,
            this.tooltrp_insert_dsmonan,
            this.toolStripSeparator5,
            this.tooltrp_update_dsmonan,
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // tooltrp_reset_dsmonan
            // 
            this.tooltrp_reset_dsmonan.Image = ((System.Drawing.Image)(resources.GetObject("tooltrp_reset_dsmonan.Image")));
            this.tooltrp_reset_dsmonan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tooltrp_reset_dsmonan.Name = "tooltrp_reset_dsmonan";
            this.tooltrp_reset_dsmonan.Size = new System.Drawing.Size(55, 22);
            this.tooltrp_reset_dsmonan.Text = "Reset";
            this.tooltrp_reset_dsmonan.Click += new System.EventHandler(this.tooltrp_reset_dsmonan_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tooltrp_insert_dsmonan
            // 
            this.tooltrp_insert_dsmonan.Image = ((System.Drawing.Image)(resources.GetObject("tooltrp_insert_dsmonan.Image")));
            this.tooltrp_insert_dsmonan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tooltrp_insert_dsmonan.Name = "tooltrp_insert_dsmonan";
            this.tooltrp_insert_dsmonan.Size = new System.Drawing.Size(56, 22);
            this.tooltrp_insert_dsmonan.Text = "Insert";
            this.tooltrp_insert_dsmonan.Click += new System.EventHandler(this.tooltrp_insert_dsmonan_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // tooltrp_update_dsmonan
            // 
            this.tooltrp_update_dsmonan.Image = ((System.Drawing.Image)(resources.GetObject("tooltrp_update_dsmonan.Image")));
            this.tooltrp_update_dsmonan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tooltrp_update_dsmonan.Name = "tooltrp_update_dsmonan";
            this.tooltrp_update_dsmonan.Size = new System.Drawing.Size(65, 22);
            this.tooltrp_update_dsmonan.Text = "Update";
            this.tooltrp_update_dsmonan.Click += new System.EventHandler(this.tooltrp_update_dsmonan_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(60, 22);
            this.toolStripButton1.Text = "Delete";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(264, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 31);
            this.label3.TabIndex = 12;
            this.label3.Text = "Danh sách món ăn ";
            // 
            // btn_chucnang_dsmonan
            // 
            this.btn_chucnang_dsmonan.Location = new System.Drawing.Point(413, 187);
            this.btn_chucnang_dsmonan.Name = "btn_chucnang_dsmonan";
            this.btn_chucnang_dsmonan.Size = new System.Drawing.Size(215, 23);
            this.btn_chucnang_dsmonan.TabIndex = 13;
            this.btn_chucnang_dsmonan.Text = "chucnag";
            this.btn_chucnang_dsmonan.UseVisualStyleBackColor = true;
            this.btn_chucnang_dsmonan.Click += new System.EventHandler(this.btn_chucnang_dsmonan_Click);
            // 
            // btn_huy_dsmonan
            // 
            this.btn_huy_dsmonan.Location = new System.Drawing.Point(644, 187);
            this.btn_huy_dsmonan.Name = "btn_huy_dsmonan";
            this.btn_huy_dsmonan.Size = new System.Drawing.Size(144, 23);
            this.btn_huy_dsmonan.TabIndex = 14;
            this.btn_huy_dsmonan.Text = "Hủy";
            this.btn_huy_dsmonan.UseVisualStyleBackColor = true;
            this.btn_huy_dsmonan.Click += new System.EventHandler(this.btn_huy_dsmonan_Click);
            // 
            // cb_loaimonan
            // 
            this.cb_loaimonan.DataSource = this.loaimonanBindingSource;
            this.cb_loaimonan.DisplayMember = "name_loaimonan";
            this.cb_loaimonan.FormattingEnabled = true;
            this.cb_loaimonan.Location = new System.Drawing.Point(127, 134);
            this.cb_loaimonan.Name = "cb_loaimonan";
            this.cb_loaimonan.Size = new System.Drawing.Size(143, 21);
            this.cb_loaimonan.TabIndex = 15;
            this.cb_loaimonan.ValueMember = "id_loaimonan";
            this.cb_loaimonan.SelectedIndexChanged += new System.EventHandler(this.cb_loaimonan_SelectedIndexChanged);
            // 
            // loaimonanBindingSource
            // 
            this.loaimonanBindingSource.DataMember = "loai_mon_an";
            this.loaimonanBindingSource.DataSource = this.quanlinhahangDataSet6;
            // 
            // quanlinhahangDataSet6
            // 
            this.quanlinhahangDataSet6.DataSetName = "quanlinhahangDataSet6";
            this.quanlinhahangDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cb_monan
            // 
            this.cb_monan.FormattingEnabled = true;
            this.cb_monan.Location = new System.Drawing.Point(413, 134);
            this.cb_monan.Name = "cb_monan";
            this.cb_monan.Size = new System.Drawing.Size(143, 21);
            this.cb_monan.TabIndex = 16;
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(659, 135);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(116, 20);
            this.txt_soluong.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Loại món ăn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(311, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Món ăn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(595, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Số lượng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(595, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Số bàn ăn";
            // 
            // txt_sobanan
            // 
            this.txt_sobanan.Location = new System.Drawing.Point(659, 83);
            this.txt_sobanan.Name = "txt_sobanan";
            this.txt_sobanan.Size = new System.Drawing.Size(116, 20);
            this.txt_sobanan.TabIndex = 22;
            // 
            // txt_thanhtien
            // 
            this.txt_thanhtien.Location = new System.Drawing.Point(127, 187);
            this.txt_thanhtien.Name = "txt_thanhtien";
            this.txt_thanhtien.Size = new System.Drawing.Size(143, 20);
            this.txt_thanhtien.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Thành tiền ";
            // 
            // loai_mon_anTableAdapter
            // 
            this.loai_mon_anTableAdapter.ClearBeforeFill = true;
            // 
            // DSmonan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_thanhtien);
            this.Controls.Add(this.txt_sobanan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_soluong);
            this.Controls.Add(this.cb_monan);
            this.Controls.Add(this.cb_loaimonan);
            this.Controls.Add(this.btn_huy_dsmonan);
            this.Controls.Add(this.btn_chucnang_dsmonan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_khachhang_dsmonan);
            this.Controls.Add(this.txt_id_hoadon_dsmonan);
            this.Controls.Add(this.data_dsmonan);
            this.Name = "DSmonan";
            this.Text = "DSmonan";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DSmonan_FormClosed);
            this.Load += new System.EventHandler(this.DSmonan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_dsmonan)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loaimonanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlinhahangDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_dsmonan;
        private System.Windows.Forms.TextBox txt_id_hoadon_dsmonan;
        private System.Windows.Forms.TextBox txt_khachhang_dsmonan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tooltrp_reset_dsmonan;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tooltrp_insert_dsmonan;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tooltrp_update_dsmonan;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_chucnang_dsmonan;
        private System.Windows.Forms.Button btn_huy_dsmonan;
        private System.Windows.Forms.ComboBox cb_loaimonan;
        private System.Windows.Forms.ComboBox cb_monan;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_sobanan;
        private System.Windows.Forms.TextBox txt_thanhtien;
        private System.Windows.Forms.Label label8;
        private quanlinhahangDataSet6 quanlinhahangDataSet6;
        private System.Windows.Forms.BindingSource loaimonanBindingSource;
        private quanlinhahangDataSet6TableAdapters.loai_mon_anTableAdapter loai_mon_anTableAdapter;
    }
}