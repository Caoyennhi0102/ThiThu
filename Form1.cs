namespace ThiThu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string Thongtin = "Họ Và Tên: Lưu Vĩnh Phát \n" + "MSSV: 123456789\n" + "Khoa : Công Nghệ Thông Tin\n" + "Ngày Thi : 29/02/2025\n";
            lbInfo.Text = Thongtin;

        }

        private void đăngKýMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dangkymonhoc dk = new Dangkymonhoc();
            dk.ShowDialog();
        }
    }
}
