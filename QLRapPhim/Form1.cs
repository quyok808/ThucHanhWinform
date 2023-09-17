using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLRapPhim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            for (int cot = 0; cot < 4; cot++)
            {
                for (int dong = 0; dong < 5; dong++)
                {
                    Button btn = new Button();
                    btn.BackColor = System.Drawing.Color.White;
                    btn.Cursor = System.Windows.Forms.Cursors.Hand;
                    btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                    btn.Size = new System.Drawing.Size(50, 50);

                    btn.Name = (cot * 5 + dong + 1).ToString();
                    btn.Text = (cot * 5 + dong + 1).ToString();
                    btn.TabIndex = 7;
                    btn.UseVisualStyleBackColor = false;

                    btn.Click += chon;

                    btn.Location = new System.Drawing.Point(15 + dong * 78, 21 + cot * 68);
                    groupBox_choncho.Controls.Add(btn);
                }
            }


        }

        private void chon(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.White)
            {
                btn.BackColor = Color.Blue;
            }
            else if (btn.BackColor == Color.Yellow)
            {
                MessageBox.Show("Ghế này đã được bán", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                btn.BackColor = Color.White;
            }
        }

        private void button_chon_Click(object sender, EventArgs e)
        {
            foreach (Button item in groupBox_choncho.Controls)
            {
                if (item.BackColor == Color.Blue)
                {   
                    label_thanhtien.Text = ThanhTien(item).ToString();
                    item.BackColor = Color.Yellow;
                    
                }
            }
            tong = 0;
        }

        private void button_huy_Click(object sender, EventArgs e)
        {
            foreach (Button item in groupBox_choncho.Controls)
            {
                if (item.BackColor == Color.Blue)
                {
                    item.BackColor = Color.White;
                    label_thanhtien.Text = "0";
                }
            }
        }
        double tong = 0;
        public double ThanhTien(Button item)
        {
            int name = int.Parse(item.Name);
            if (name > 0 && name < 6)
            {
                tong = tong + 30000;
            } else  
            if (name > 5 && name < 11)
            {
                tong = tong + 40000;
            }
            else
            if (name > 10 && name < 16)
            {
                tong = tong + 50000;
            }
            if (name > 15 && name < 21)
            {
                tong = tong + 80000;
            }
            return tong;
        }

        private void button_ketthuc_Click(object sender, EventArgs e)
        {
            label_thanhtien.Text = tong.ToString();
        }
    }
}
