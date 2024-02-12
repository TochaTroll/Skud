using Microsoft.EntityFrameworkCore;
using SKUD.Context;
using SKUD.Model;
using System.Data;


namespace SKUD.Forms
{
    public partial class ReturnedAdmission : Form
    {
        private readonly SkudContext _context;
        private List<Admission> Admissions;
        public ReturnedAdmission()
        {
            InitializeComponent();
            _context = new SkudContext();
            Admissions = _context.Admissions.Include(x=>x.Documents).ToList();
        }
        private void ReturnedAdmission_Load(object sender, EventArgs e)
        {
            textBoxDoc.Enabled = false;
            textBoxNumberDoc.Enabled = false;
            comboBoxName.Items.AddRange(Admissions.Select(x => x.FullName).ToArray());
        }
        private void comboBoxName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxName.SelectedItem == null)
                return;
            Admissions = _context.Admissions.Where(x => x.FullName == comboBoxName.SelectedItem.ToString()).ToList();
            string typeDocument = Admissions.Select(x=>x.Documents.DocumentName1).First();
            string numberDocument = Admissions.Select(x => x.DocumentNumber).First();

            textBoxDoc.Text = typeDocument;
            textBoxNumberDoc.Text = numberDocument;
        }
        private void buttonRet_Click(object sender, EventArgs e)
        {
            if (comboBoxName.SelectedItem != null)
            {
                Admission admission = Admissions.First();
                AllDataAdmission allDataAdmission = new AllDataAdmission();
                allDataAdmission.FullName = admission.FullName;
                allDataAdmission.DocumentNumber = admission.DocumentNumber;
                allDataAdmission.DocumentsId = admission.DocumentsId;
                allDataAdmission.Date = admission.DateTime;
                allDataAdmission.Time = TimeSpan.Parse(DateTime.Now.ToString($"{DateTime.Now:T}"));
                allDataAdmission.StateId = 2;

                try
                {
                    _context.Admissions.Remove(admission);
                    _context.AllDataAdmissions.Add(allDataAdmission);
                    _context.SaveChanges();
                    MessageBox.Show("Данные успешно сохранены", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Выберите человека", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);

            comboBoxName.Text = null;
            textBoxDoc.Text = null;
            textBoxNumberDoc.Text = null;
            comboBoxName.Items.Clear();
            comboBoxName.Items.AddRange(_context.Admissions.Select(x => x.FullName).ToArray());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartMenu startMenu = new StartMenu();
            startMenu.Width = this.Width;
            startMenu.Height = this.Height;
            startMenu.Show();
        }   
        private void comboBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            comboBoxName.DroppedDown = true;
            if (char.IsControl(e.KeyChar))
                return;
            string str = comboBoxName.Text.Substring(0, comboBoxName.SelectionStart) + e.KeyChar;
            int index = comboBoxName.FindStringExact(str);
            if (index == -1)
                index = comboBoxName.FindString(str);
            comboBoxName.SelectedIndex = index;
            comboBoxName.SelectionStart = str.Length;
            comboBoxName.SelectionLength = comboBoxName.Text.Length - comboBoxName.SelectionStart;
            e.Handled = true;
        }
        private void ReturnedAdmission_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
