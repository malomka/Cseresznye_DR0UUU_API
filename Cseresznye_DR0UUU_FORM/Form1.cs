using Cseresznye_DR0UUU_FORM.LibraryModels;

namespace Cseresznye_DR0UUU_FORM
{
    public partial class Form1 : Form
    {
        LibraryDatabaseContext context = new LibraryDatabaseContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Biztos ki szeretne lépni?", "Kilépés", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserControl1 uc1 = new UserControl1();

            panel1.Controls.Clear();
            panel1.Controls.Add(uc1);

            uc1.Dock = DockStyle.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserControl2 uc2 = new UserControl2();

            panel1.Controls.Clear();
            panel1.Controls.Add(uc2);

            uc2.Dock = DockStyle.Fill;
        }
    }
}