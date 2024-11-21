namespace hethong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hethong(object sender, EventArgs e)
        {
            Form1 newForm1 = new Form1();
            newForm1.Show();
        }

        private void danhnhap(object sender, EventArgs e)
        {
            danhnhap newdanhnhap = new danhnhap();
            newdanhnhap.Show();
        }

        private void loaisach(object sender, EventArgs e)
        {
            loaisach newloaisach = new loaisach();
            newloaisach.Show();
        }

        private void sach(object sender, EventArgs e)
        {
            sach newsach = new sach();
            newsach.Show();
        }
    }
}