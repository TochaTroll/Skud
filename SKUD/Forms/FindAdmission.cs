using SKUD.Context;
using SKUD.ViewModels;
using System.Data;

namespace SKUD.Forms
{
    public partial class FindAdmission : Form
    {
        private readonly SkudContext _context;
        private List<ViewAdmission> ViewAdmissions;
        public FindAdmission()
        {
            InitializeComponent();
            _context = new SkudContext();
            ViewAdmissions = (from c in _context.AllDataAdmissions
                              select new ViewAdmission
                              {
                                  FullName = c.FullName,
                                  Documents = c.Documents.DocumentName1,
                                  DocumentNumber = c.DocumentNumber,
                                  Date = c.Date,
                                  Time = c.Time,
                                  State = c.State.State1
                              }).ToList();
        }
        private void FindAdmission_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            dataGridView1.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 14);

            dataGridView1.DataSource = ViewAdmissions;
            comboBoxDoc.Items.Add("Без фильтра");
            comboBoxDoc.Items.AddRange(ViewAdmissions.Select(x => x.Documents).Distinct().ToArray());

            dataGridView1.Columns[0].Width = 350;
            dataGridView1.Columns[0].HeaderText = "ФИО";

            dataGridView1.Columns[1].Width = 350;
            dataGridView1.Columns[1].HeaderText = "Документ";

            dataGridView1.Columns[2].Width = 250;
            dataGridView1.Columns[2].HeaderText = "Номер документа";

            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[3].HeaderText = "Дата";

            dataGridView1.Columns[4].Width = 150;
            dataGridView1.Columns[4].HeaderText = "Время";

            dataGridView1.Columns[4].Width = 150;
            dataGridView1.Columns[5].HeaderText = "Статус";
        }
        private void UpdateData()
        {
            var foundAdmission = ViewAdmissions;
            foundAdmission = foundAdmission.Where(x => x.FullName.ToLower().Contains(textBoxName.Text.ToLower())).ToList();

            if (comboBoxDoc.SelectedItem != null && comboBoxDoc.SelectedIndex != 0)
                foundAdmission = foundAdmission.Where(x => x.Documents == comboBoxDoc.SelectedItem.ToString()).ToList();
            if (checkBox1.Checked == false)
                foundAdmission = foundAdmission.Where(x => x.Date == dateTimePicker1.Value.Date).ToList();

            dataGridView1.DataSource = foundAdmission;
        }
        private void dateTimePicker1_CloseUp_1(object sender, EventArgs e)
        {
            UpdateData();

        }
        private void comboBoxDoc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            UpdateData();
        }
        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            UpdateData();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateData();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartMenu startMenu = new StartMenu();
            startMenu.Width = this.Width;
            startMenu.Height = this.Height;
            startMenu.Show();
        }
        private void FindAdmission_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false) return;
            if (e.KeyChar == Convert.ToChar(Keys.Back)) return;
            e.Handled = true;
        }      
    }
}
