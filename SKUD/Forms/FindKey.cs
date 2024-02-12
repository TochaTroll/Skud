using SKUD.Context;
using SKUD.ViewModels;
using System.Data;

namespace SKUD.Forms
{
    public partial class FindKey : Form
    {
        private readonly SkudContext _context;
        private List<ViewAdmissionTeacher> ViewAdmissionTeachers;
        public FindKey()
        {
            InitializeComponent();
            _context = new SkudContext();
            ViewAdmissionTeachers = (from c in _context.AllDataTeachers
                                     select new ViewAdmissionTeacher
                                     {
                                         FullName = c.Teachers.FullName,
                                         CabinetNumber = c.CabinetNumber,
                                         Date = c.Date,
                                         Time = c.Time,
                                         State = c.State.State1

                                     }).ToList();
        }
        private void UpdateData()
        {
            var foundTeachers = ViewAdmissionTeachers;
            foundTeachers = foundTeachers.Where(x => x.FullName.ToLower().Contains(textBoxName.Text.ToLower())).ToList();

            if (textBoxCab.Text != "")
                foundTeachers = foundTeachers.Where(x => x.CabinetNumber.ToString() == textBoxCab.Text).ToList();
            if (checkBox1.Checked == false)
                foundTeachers = foundTeachers.Where(x => x.Date == dateTimePicker1.Value.Date).ToList();

            dataGridView1.DataSource = foundTeachers;
        }
        private void FindKey_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            dataGridView1.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 14);
            dataGridView1.DataSource = ViewAdmissionTeachers;

            dataGridView1.Columns[0].Width = 350;
            dataGridView1.Columns[0].HeaderText = "ФИО";

            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[1].HeaderText = "Номер кабинета";

            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[2].HeaderText = "Дата";

            dataGridView1.Columns[3].Width = 140;
            dataGridView1.Columns[3].HeaderText = "Время";

            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[4].HeaderText = "Статус";
        }
        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            UpdateData();
        }
        private void textBoxCab_TextChanged(object sender, EventArgs e)
        {
            UpdateData();
        }
        private void dateTimePicker1_CloseUp(object sender, EventArgs e)
        {
            UpdateData();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateData();
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartMenu mainMenu = new StartMenu();
            mainMenu.Width = this.Width;
            mainMenu.Height = this.Height;
            mainMenu.Show();
        }
        private void FindKey_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false) return;
            if (e.KeyChar == Convert.ToChar(Keys.Back)) return;
            e.Handled = true;
        }
        private void textBoxCab_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == true) return;
            if (e.KeyChar == Convert.ToChar(Keys.Back)) return;
            e.Handled = true;
        }      
    }
}
