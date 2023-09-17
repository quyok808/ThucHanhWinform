namespace QLSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_Khoa.SelectedIndex = 0;
            GT_Nu.Checked = true;
            label_SumNam.Text = "0";
            label_SumNu.Text = "0";


            //dataGridView1.Rows[0].Cells[0].Value = "123456";
            //dataGridView1.Rows[0].Cells[1].Value = "Nguyen A";
            //dataGridView1.Rows[0].Cells[2].Value = "Nữ";
            //dataGridView1.Rows[0].Cells[3].Value = "8";
            //dataGridView1.Rows[0].Cells[4].Value = "CNTT";

        }

        private void button_Them_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_MSSV.Text == "" || textBox_HoTen.Text == "" || textBox_DTB.Text == "")
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin !!!");
                }
                int selectedRow = GetSelectedRow(textBox_MSSV.Text);
                if (selectedRow == -1)
                {
                    selectedRow = dataGridView1.Rows.Add();
                    InsertUpdate(selectedRow);
                    MessageBox.Show("Them thanh cong", "Thong bao", MessageBoxButtons.OK);
                }
                else
                {
                    InsertUpdate(selectedRow);
                    MessageBox.Show("update thanh cong", "Thong bao", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int GetSelectedRow(string studentID)
        {
            
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == studentID)
                    {
                        return i;
                    }
                }
                return -1;
            
        }
        private void InsertUpdate(int selectedRow)
        {
            dataGridView1.Rows[selectedRow].Cells[0].Value = textBox_MSSV.Text;
            dataGridView1.Rows[selectedRow].Cells[1].Value = textBox_HoTen.Text;
            dataGridView1.Rows[selectedRow].Cells[2].Value = GT_Nu.Checked ? "Nữ" : "Nam";
            dataGridView1.Rows[selectedRow].Cells[3].Value = float.Parse(textBox_DTB.Text).ToString();
            dataGridView1.Rows[selectedRow].Cells[4].Value = comboBox_Khoa.Text;
        }
    }
}