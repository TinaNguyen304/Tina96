namespace QLDANGKIMH
{
    partial class frmMonHoc
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.txtSoTiet = new System.Windows.Forms.TextBox();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.cbLoaiMon = new System.Windows.Forms.ComboBox();
            this.btThem = new System.Windows.Forms.Button();
            this.btHuy = new System.Windows.Forms.Button();
            this.dgvMonHoc = new System.Windows.Forms.DataGridView();
            this.btLuu = new System.Windows.Forms.Button();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaimon = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colSotiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã môn học:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loại môn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên môn học:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số tiết: ";
            // 
            // txtMaMH
            // 
            this.txtMaMH.Location = new System.Drawing.Point(87, 39);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(127, 20);
            this.txtMaMH.TabIndex = 4;
            // 
            // txtSoTiet
            // 
            this.txtSoTiet.Location = new System.Drawing.Point(347, 75);
            this.txtSoTiet.Name = "txtSoTiet";
            this.txtSoTiet.Size = new System.Drawing.Size(84, 20);
            this.txtSoTiet.TabIndex = 5;
            // 
            // txtTenMH
            // 
            this.txtTenMH.Location = new System.Drawing.Point(347, 39);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(246, 20);
            this.txtTenMH.TabIndex = 6;
            this.txtTenMH.TextChanged += new System.EventHandler(this.txtTenMH_TextChanged);
            // 
            // cbLoaiMon
            // 
            this.cbLoaiMon.FormattingEnabled = true;
            this.cbLoaiMon.Location = new System.Drawing.Point(87, 73);
            this.cbLoaiMon.Name = "cbLoaiMon";
            this.cbLoaiMon.Size = new System.Drawing.Size(89, 21);
            this.cbLoaiMon.TabIndex = 7;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(518, 75);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 23);
            this.btThem.TabIndex = 8;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btHuy
            // 
            this.btHuy.Location = new System.Drawing.Point(502, 284);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(91, 27);
            this.btHuy.TabIndex = 9;
            this.btHuy.Text = "Hủy";
            this.btHuy.UseVisualStyleBackColor = true;
            // 
            // dgvMonHoc
            // 
            this.dgvMonHoc.BackgroundColor = System.Drawing.Color.White;
            this.dgvMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colMaMH,
            this.colTenMH,
            this.colLoaimon,
            this.colSotiet});
            this.dgvMonHoc.Location = new System.Drawing.Point(31, 104);
            this.dgvMonHoc.Name = "dgvMonHoc";
            this.dgvMonHoc.Size = new System.Drawing.Size(562, 154);
            this.dgvMonHoc.TabIndex = 10;
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(397, 284);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(91, 27);
            this.btLuu.TabIndex = 11;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // colSTT
            // 
            this.colSTT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSTT.DataPropertyName = "stt";
            this.colSTT.HeaderText = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.Width = 53;
            // 
            // colMaMH
            // 
            this.colMaMH.DataPropertyName = "mamh";
            this.colMaMH.HeaderText = "Ma Mon Hoc";
            this.colMaMH.Name = "colMaMH";
            // 
            // colTenMH
            // 
            this.colTenMH.DataPropertyName = "tenmh";
            this.colTenMH.HeaderText = "Ten Mon hoc";
            this.colTenMH.Name = "colTenMH";
            this.colTenMH.Width = 200;
            // 
            // colLoaimon
            // 
            this.colLoaimon.DataPropertyName = "loaimon";
            this.colLoaimon.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colLoaimon.HeaderText = "Loai mon";
            this.colLoaimon.Name = "colLoaimon";
            this.colLoaimon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colLoaimon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colSotiet
            // 
            this.colSotiet.DataPropertyName = "sotiet";
            this.colSotiet.HeaderText = "So tiet";
            this.colSotiet.Name = "colSotiet";
            this.colSotiet.Width = 75;
            // 
            // frmMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 323);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.dgvMonHoc);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.cbLoaiMon);
            this.Controls.Add(this.txtTenMH);
            this.Controls.Add(this.txtSoTiet);
            this.Controls.Add(this.txtMaMH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMonHoc";
            this.Text = "DANH SÁCH MÔN HỌC";
            this.Load += new System.EventHandler(this.frmMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.TextBox txtSoTiet;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.ComboBox cbLoaiMon;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.DataGridView dgvMonHoc;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenMH;
        private System.Windows.Forms.DataGridViewComboBoxColumn colLoaimon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSotiet;

    }
}