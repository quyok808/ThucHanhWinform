namespace QLSV
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            comboBox_Khoa = new ComboBox();
            textBox_HoTen = new TextBox();
            textBox_DTB = new TextBox();
            textBox_MSSV = new TextBox();
            GT_Nu = new RadioButton();
            GT_Nam = new RadioButton();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            mssv = new DataGridViewTextBoxColumn();
            hoten = new DataGridViewTextBoxColumn();
            gioitinh = new DataGridViewTextBoxColumn();
            dtb = new DataGridViewTextBoxColumn();
            khoa = new DataGridViewTextBoxColumn();
            button_Them_Sua = new Button();
            button_Xoa = new Button();
            label1010 = new Label();
            label010101 = new Label();
            label_SumNam = new Label();
            label_SumNu = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox_Khoa);
            groupBox1.Controls.Add(textBox_HoTen);
            groupBox1.Controls.Add(textBox_DTB);
            groupBox1.Controls.Add(textBox_MSSV);
            groupBox1.Controls.Add(GT_Nu);
            groupBox1.Controls.Add(GT_Nam);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(25, 111);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(375, 280);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sinh viên";
            // 
            // comboBox_Khoa
            // 
            comboBox_Khoa.BackColor = Color.LightGray;
            comboBox_Khoa.FormattingEnabled = true;
            comboBox_Khoa.Items.AddRange(new object[] { "QTKD", "CNTT", "NNA" });
            comboBox_Khoa.Location = new Point(175, 237);
            comboBox_Khoa.Name = "comboBox_Khoa";
            comboBox_Khoa.Size = new Size(194, 28);
            comboBox_Khoa.TabIndex = 3;
            // 
            // textBox_HoTen
            // 
            textBox_HoTen.Location = new Point(175, 87);
            textBox_HoTen.Name = "textBox_HoTen";
            textBox_HoTen.Size = new Size(194, 27);
            textBox_HoTen.TabIndex = 2;
            // 
            // textBox_DTB
            // 
            textBox_DTB.Location = new Point(175, 187);
            textBox_DTB.Name = "textBox_DTB";
            textBox_DTB.Size = new Size(194, 27);
            textBox_DTB.TabIndex = 2;
            // 
            // textBox_MSSV
            // 
            textBox_MSSV.Location = new Point(175, 37);
            textBox_MSSV.Name = "textBox_MSSV";
            textBox_MSSV.Size = new Size(194, 27);
            textBox_MSSV.TabIndex = 2;
            // 
            // GT_Nu
            // 
            GT_Nu.AutoSize = true;
            GT_Nu.Location = new Point(262, 140);
            GT_Nu.Name = "GT_Nu";
            GT_Nu.Size = new Size(50, 24);
            GT_Nu.TabIndex = 1;
            GT_Nu.TabStop = true;
            GT_Nu.Text = "Nữ";
            GT_Nu.UseVisualStyleBackColor = true;
            // 
            // GT_Nam
            // 
            GT_Nam.AutoSize = true;
            GT_Nam.Location = new Point(175, 140);
            GT_Nam.Name = "GT_Nam";
            GT_Nam.Size = new Size(62, 24);
            GT_Nam.TabIndex = 1;
            GT_Nam.TabStop = true;
            GT_Nam.Text = "Nam";
            GT_Nam.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 240);
            label6.Name = "label6";
            label6.Size = new Size(102, 20);
            label6.TabIndex = 0;
            label6.Text = "Chuyên ngành";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 190);
            label5.Name = "label5";
            label5.Size = new Size(121, 20);
            label5.TabIndex = 0;
            label5.Text = "Điểm trung bình ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 140);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 0;
            label4.Text = "Giới tính";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 90);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 0;
            label3.Text = "Họ và tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 40);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã Sinh viên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("#9Slide07 IcielCadena", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(287, 31);
            label1.Name = "label1";
            label1.Size = new Size(568, 51);
            label1.TabIndex = 1;
            label1.Text = "Quản Lý Thông Tin Sinh Viên";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { mssv, hoten, gioitinh, dtb, khoa });
            dataGridView1.Location = new Point(406, 122);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(743, 324);
            dataGridView1.TabIndex = 2;
            // 
            // mssv
            // 
            mssv.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            mssv.HeaderText = "MSSV";
            mssv.MinimumWidth = 6;
            mssv.Name = "mssv";
            mssv.Width = 150;
            // 
            // hoten
            // 
            hoten.HeaderText = "Họ Tên";
            hoten.MinimumWidth = 6;
            hoten.Name = "hoten";
            hoten.ReadOnly = true;
            hoten.Width = 200;
            // 
            // gioitinh
            // 
            gioitinh.HeaderText = "Giới tính";
            gioitinh.MinimumWidth = 6;
            gioitinh.Name = "gioitinh";
            gioitinh.ReadOnly = true;
            gioitinh.Width = 125;
            // 
            // dtb
            // 
            dtb.HeaderText = "ĐTB";
            dtb.MinimumWidth = 6;
            dtb.Name = "dtb";
            dtb.ReadOnly = true;
            dtb.Width = 125;
            // 
            // khoa
            // 
            khoa.HeaderText = "Khoa";
            khoa.MinimumWidth = 6;
            khoa.Name = "khoa";
            khoa.ReadOnly = true;
            khoa.Width = 125;
            // 
            // button_Them_Sua
            // 
            button_Them_Sua.Location = new Point(94, 417);
            button_Them_Sua.Name = "button_Them_Sua";
            button_Them_Sua.Size = new Size(94, 29);
            button_Them_Sua.TabIndex = 3;
            button_Them_Sua.Text = "Thêm / Sửa";
            button_Them_Sua.UseVisualStyleBackColor = true;
            button_Them_Sua.Click += button_Them_Sua_Click;
            // 
            // button_Xoa
            // 
            button_Xoa.Location = new Point(243, 417);
            button_Xoa.Name = "button_Xoa";
            button_Xoa.Size = new Size(94, 29);
            button_Xoa.TabIndex = 4;
            button_Xoa.Text = "Xoá";
            button_Xoa.UseVisualStyleBackColor = true;
            // 
            // label1010
            // 
            label1010.AutoSize = true;
            label1010.Location = new Point(835, 466);
            label1010.Name = "label1010";
            label1010.Size = new Size(100, 20);
            label1010.TabIndex = 5;
            label1010.Text = "Tổng SV Nam";
            // 
            // label010101
            // 
            label010101.AutoSize = true;
            label010101.Location = new Point(1017, 466);
            label010101.Name = "label010101";
            label010101.Size = new Size(29, 20);
            label010101.TabIndex = 5;
            label010101.Text = "Nữ";
            // 
            // label_SumNam
            // 
            label_SumNam.BackColor = Color.White;
            label_SumNam.BorderStyle = BorderStyle.FixedSingle;
            label_SumNam.FlatStyle = FlatStyle.Popup;
            label_SumNam.Location = new Point(938, 465);
            label_SumNam.Name = "label_SumNam";
            label_SumNam.Size = new Size(76, 25);
            label_SumNam.TabIndex = 6;
            // 
            // label_SumNu
            // 
            label_SumNu.BackColor = Color.White;
            label_SumNu.BorderStyle = BorderStyle.FixedSingle;
            label_SumNu.FlatStyle = FlatStyle.Popup;
            label_SumNu.Location = new Point(1052, 465);
            label_SumNu.Name = "label_SumNu";
            label_SumNu.Size = new Size(76, 25);
            label_SumNu.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(1161, 503);
            Controls.Add(label_SumNu);
            Controls.Add(label_SumNam);
            Controls.Add(label010101);
            Controls.Add(label1010);
            Controls.Add(button_Xoa);
            Controls.Add(button_Them_Sua);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label4;
        private Label label3;
        private Label label2;
        private RadioButton GT_Nam;
        private Label label6;
        private Label label5;
        private RadioButton GT_Nu;
        private ComboBox comboBox_Khoa;
        private TextBox textBox_HoTen;
        private TextBox textBox_DTB;
        private TextBox textBox_MSSV;
        private Button button_Them_Sua;
        private Button button_Xoa;
        private Label label1010;
        private Label label010101;
        private Label label_SumNam;
        private Label label_SumNu;
        private DataGridViewTextBoxColumn mssv;
        private DataGridViewTextBoxColumn hoten;
        private DataGridViewTextBoxColumn gioitinh;
        private DataGridViewTextBoxColumn dtb;
        private DataGridViewTextBoxColumn khoa;
    }
}