namespace nguyenvantan_buoi4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<SinhVien> li_sv = new List<SinhVien>();
        private void button1_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien(txt_mssv.Text, txt_hoten.Text, txt_gioitinh.Text, dtp_ngaysinh.Value, txt_diachi.Text);

            li_sv.Add(sv);
            dataGridView1.DataSource = null; // reset
            dataGridView1.DataSource = li_sv;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            li_sv.Remove(li_sv[0]);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = li_sv;
        }
    }
}
