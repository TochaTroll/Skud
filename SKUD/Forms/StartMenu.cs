using SKUD.Forms;

namespace SKUD
{
    public partial class StartMenu : Form
    {
        public StartMenu()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReturnedKey returnedKey = new ReturnedKey();
            returnedKey.Width = this.Width;
            returnedKey.Height = this.Height;
            returnedKey.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddAdmission addAdmission = new AddAdmission();
            addAdmission.Width = this.Width;
            addAdmission.Height = this.Height;
            addAdmission.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FindKey findKey = new FindKey();
            findKey.Width = this.Width;
            findKey.Height = this.Height;
            findKey.Show();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddKey addKey = new AddKey();
            addKey.Width = this.Width;
            addKey.Height = this.Height;
            addKey.Show();
        }
        private void StartMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReturnedAdmission returnedAdmission = new ReturnedAdmission();
            returnedAdmission.Width = this.Width;
            returnedAdmission.Height = this.Height;
            returnedAdmission.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FindAdmission findAdmission = new FindAdmission();
            findAdmission.Width = this.Width;
            findAdmission.Height = this.Height;
            findAdmission.Show();
        }
    }
}