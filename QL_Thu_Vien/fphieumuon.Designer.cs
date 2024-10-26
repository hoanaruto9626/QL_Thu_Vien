namespace QL_Thu_Vien
{
    partial class fphieumuon
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
            groupBox1 = new GroupBox();
            rbPhieuTra = new RadioButton();
            rbPhieuMuon = new RadioButton();
            cbMaSach = new ComboBox();
            cbMaSV = new ComboBox();
            btnTimKiem = new Button();
            textBox1 = new TextBox();
            dateNgayTra = new DateTimePicker();
            dateNgayMuon = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            txtSL = new TextBox();
            label3 = new Label();
            txtMaPhieu = new TextBox();
            label8 = new Label();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            btnExit = new Button();
            btnSave = new Button();
            btnSkip = new Button();
            btnDel = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            dgvMuon = new DataGridView();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMuon).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbPhieuTra);
            groupBox1.Controls.Add(rbPhieuMuon);
            groupBox1.Controls.Add(cbMaSach);
            groupBox1.Controls.Add(cbMaSV);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(dateNgayTra);
            groupBox1.Controls.Add(dateNgayMuon);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtSL);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtMaPhieu);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(69, 102);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1273, 206);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // rbPhieuTra
            // 
            rbPhieuTra.AutoSize = true;
            rbPhieuTra.Location = new Point(514, 151);
            rbPhieuTra.Name = "rbPhieuTra";
            rbPhieuTra.Size = new Size(88, 24);
            rbPhieuTra.TabIndex = 60;
            rbPhieuTra.TabStop = true;
            rbPhieuTra.Text = "Phiếu trả";
            rbPhieuTra.UseVisualStyleBackColor = true;
            // 
            // rbPhieuMuon
            // 
            rbPhieuMuon.AutoSize = true;
            rbPhieuMuon.Location = new Point(283, 151);
            rbPhieuMuon.Name = "rbPhieuMuon";
            rbPhieuMuon.Size = new Size(109, 24);
            rbPhieuMuon.TabIndex = 59;
            rbPhieuMuon.TabStop = true;
            rbPhieuMuon.Text = "Phiếu mượn";
            rbPhieuMuon.UseVisualStyleBackColor = true;
            // 
            // cbMaSach
            // 
            cbMaSach.FormattingEnabled = true;
            cbMaSach.Location = new Point(105, 93);
            cbMaSach.Name = "cbMaSach";
            cbMaSach.Size = new Size(228, 28);
            cbMaSach.TabIndex = 58;
            // 
            // cbMaSV
            // 
            cbMaSV.FormattingEnabled = true;
            cbMaSV.Location = new Point(460, 32);
            cbMaSV.Name = "cbMaSV";
            cbMaSV.Size = new Size(233, 28);
            cbMaSV.TabIndex = 57;
            // 
            // btnTimKiem
            // 
            btnTimKiem.FlatStyle = FlatStyle.Popup;
            btnTimKiem.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTimKiem.Location = new Point(1070, 87);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 56;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Times New Roman", 9F);
            textBox1.Location = new Point(1010, 38);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Tìm kiếm";
            textBox1.Size = new Size(218, 25);
            textBox1.TabIndex = 55;
            // 
            // dateNgayTra
            // 
            dateNgayTra.CustomFormat = "dd/MM/yyyy";
            dateNgayTra.Format = DateTimePickerFormat.Short;
            dateNgayTra.Location = new Point(866, 90);
            dateNgayTra.Name = "dateNgayTra";
            dateNgayTra.Size = new Size(125, 27);
            dateNgayTra.TabIndex = 54;
            // 
            // dateNgayMuon
            // 
            dateNgayMuon.CustomFormat = "dd/MM/yyyy";
            dateNgayMuon.Format = DateTimePickerFormat.Custom;
            dateNgayMuon.Location = new Point(866, 35);
            dateNgayMuon.Name = "dateNgayMuon";
            dateNgayMuon.Size = new Size(125, 27);
            dateNgayMuon.TabIndex = 53;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label4.Location = new Point(733, 98);
            label4.Name = "label4";
            label4.Size = new Size(84, 23);
            label4.TabIndex = 51;
            label4.Text = "Ngày trả";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label5.Location = new Point(733, 38);
            label5.Name = "label5";
            label5.Size = new Size(107, 23);
            label5.TabIndex = 50;
            label5.Text = "Ngày mượn";
            // 
            // txtSL
            // 
            txtSL.BorderStyle = BorderStyle.FixedSingle;
            txtSL.Font = new Font("Times New Roman", 9F);
            txtSL.Location = new Point(460, 96);
            txtSL.Name = "txtSL";
            txtSL.Size = new Size(233, 25);
            txtSL.TabIndex = 49;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label3.Location = new Point(351, 98);
            label3.Name = "label3";
            label3.Size = new Size(86, 23);
            label3.TabIndex = 48;
            label3.Text = "SL mượn";
            // 
            // txtMaPhieu
            // 
            txtMaPhieu.BorderStyle = BorderStyle.FixedSingle;
            txtMaPhieu.Font = new Font("Times New Roman", 9F);
            txtMaPhieu.Location = new Point(105, 36);
            txtMaPhieu.Name = "txtMaPhieu";
            txtMaPhieu.Size = new Size(228, 25);
            txtMaPhieu.TabIndex = 45;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label8.Location = new Point(6, 98);
            label8.Name = "label8";
            label8.Size = new Size(80, 23);
            label8.TabIndex = 44;
            label8.Text = "Mã sách";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label6.Location = new Point(351, 38);
            label6.Name = "label6";
            label6.Size = new Size(68, 23);
            label6.TabIndex = 43;
            label6.Text = "Mã SV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.Location = new Point(6, 38);
            label2.Name = "label2";
            label2.Size = new Size(88, 23);
            label2.TabIndex = 42;
            label2.Text = "Mã phiếu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(516, 32);
            label1.Name = "label1";
            label1.Size = new Size(246, 51);
            label1.TabIndex = 28;
            label1.Text = "Phiếu mượn";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnSkip);
            panel1.Controls.Add(btnDel);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnAdd);
            panel1.Location = new Point(69, 638);
            panel1.Name = "panel1";
            panel1.Size = new Size(1273, 70);
            panel1.TabIndex = 27;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Location = new Point(978, 24);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 5;
            btnExit.Text = "Đóng";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnDong_Click;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Location = new Point(805, 24);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 4;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnLuu_Click;
            // 
            // btnSkip
            // 
            btnSkip.FlatStyle = FlatStyle.Popup;
            btnSkip.Location = new Point(631, 24);
            btnSkip.Name = "btnSkip";
            btnSkip.Size = new Size(94, 29);
            btnSkip.TabIndex = 3;
            btnSkip.Text = "Bỏ qua";
            btnSkip.UseVisualStyleBackColor = true;
            btnSkip.Click += btnBoQua_Click;
            // 
            // btnDel
            // 
            btnDel.FlatStyle = FlatStyle.Popup;
            btnDel.Location = new Point(397, 24);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(94, 29);
            btnDel.TabIndex = 2;
            btnDel.Text = "Xóa";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnXoa_Click;
            // 
            // btnEdit
            // 
            btnEdit.FlatStyle = FlatStyle.Popup;
            btnEdit.Location = new Point(235, 24);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnSua_Click;
            // 
            // btnAdd
            // 
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Location = new Point(52, 24);
            btnAdd.Name = "btnAdd";
            btnAdd.RightToLeft = RightToLeft.Yes;
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnThem_Click;
            // 
            // dgvMuon
            // 
            dgvMuon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMuon.Location = new Point(69, 314);
            dgvMuon.Name = "dgvMuon";
            dgvMuon.RowHeadersWidth = 51;
            dgvMuon.Size = new Size(1273, 318);
            dgvMuon.TabIndex = 26;
            // 
            // fphieumuon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1421, 753);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(dgvMuon);
            Name = "fphieumuon";
            Text = "Phiếu mượn";
            Load += fphieumuon_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMuon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cbMaSach;
        private ComboBox cbMaSV;
        private Button btnTimKiem;
        private TextBox textBox1;
        private DateTimePicker dateNgayTra;
        private DateTimePicker dateNgayMuon;
        private Label label4;
        private Label label5;
        private TextBox txtSL;
        private Label label3;
        private TextBox txtMaPhieu;
        private Label label8;
        private Label label6;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Button btnExit;
        private Button btnSave;
        private Button btnSkip;
        private Button btnDel;
        private Button btnEdit;
        private Button btnAdd;
        private DataGridView dgvMuon;
        private RadioButton rbPhieuTra;
        private RadioButton rbPhieuMuon;
    }
}