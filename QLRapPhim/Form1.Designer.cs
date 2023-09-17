namespace QLRapPhim
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
            this.groupBox_choncho = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_thanhtien = new System.Windows.Forms.Label();
            this.button_chon = new System.Windows.Forms.Button();
            this.button_huy = new System.Windows.Forms.Button();
            this.button_ketthuc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // groupBox_choncho
            // 
            this.groupBox_choncho.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_choncho.Location = new System.Drawing.Point(25, 74);
            this.groupBox_choncho.Name = "groupBox_choncho";
            this.groupBox_choncho.Size = new System.Drawing.Size(522, 354);
            this.groupBox_choncho.TabIndex = 0;
            this.groupBox_choncho.TabStop = false;
            this.groupBox_choncho.Text = "Sơ đồ chỗ ngồi";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("#9Slide03 BoosterNextFYBlack", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(535, 53);
            this.label1.TabIndex = 1;
            this.label1.Text = "MÀN ẢNH ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 443);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thành tiền:";
            // 
            // label_thanhtien
            // 
            this.label_thanhtien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_thanhtien.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_thanhtien.Location = new System.Drawing.Point(226, 440);
            this.label_thanhtien.Name = "label_thanhtien";
            this.label_thanhtien.Size = new System.Drawing.Size(160, 23);
            this.label_thanhtien.TabIndex = 3;
            this.label_thanhtien.Text = "0";
            this.label_thanhtien.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // button_chon
            // 
            this.button_chon.Location = new System.Drawing.Point(62, 483);
            this.button_chon.Name = "button_chon";
            this.button_chon.Size = new System.Drawing.Size(100, 36);
            this.button_chon.TabIndex = 4;
            this.button_chon.Text = "Chọn ";
            this.button_chon.UseVisualStyleBackColor = true;
            this.button_chon.Click += new System.EventHandler(this.button_chon_Click);
            // 
            // button_huy
            // 
            this.button_huy.Location = new System.Drawing.Point(232, 483);
            this.button_huy.Name = "button_huy";
            this.button_huy.Size = new System.Drawing.Size(100, 36);
            this.button_huy.TabIndex = 5;
            this.button_huy.Text = "Huỷ bỏ";
            this.button_huy.UseVisualStyleBackColor = true;
            this.button_huy.Click += new System.EventHandler(this.button_huy_Click);
            // 
            // button_ketthuc
            // 
            this.button_ketthuc.Location = new System.Drawing.Point(402, 483);
            this.button_ketthuc.Name = "button_ketthuc";
            this.button_ketthuc.Size = new System.Drawing.Size(100, 36);
            this.button_ketthuc.TabIndex = 6;
            this.button_ketthuc.Text = "Kết thúc";
            this.button_ketthuc.UseVisualStyleBackColor = true;
            this.button_ketthuc.Click += new System.EventHandler(this.button_ketthuc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(559, 529);
            this.Controls.Add(this.button_ketthuc);
            this.Controls.Add(this.button_huy);
            this.Controls.Add(this.button_chon);
            this.Controls.Add(this.label_thanhtien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox_choncho);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_choncho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_thanhtien;
        private System.Windows.Forms.Button button_chon;
        private System.Windows.Forms.Button button_huy;
        private System.Windows.Forms.Button button_ketthuc;
    }
}

