using SKUD.Context;
using SKUD.Model;
using System.Data;

namespace SKUD.Forms
{
    public partial class AddAdmission : Form
    {
        private readonly SkudContext _context;
        public AddAdmission()
        {
            InitializeComponent();
            _context = new SkudContext();
        }      
        private void AddAdmission_Load(object sender, EventArgs e)
        {
            comboBoxDocument.Items.AddRange(_context.DocumentNames.Select(x => x.DocumentName1).ToArray());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxName.TextLength > 0 && textBoxNumberDoc.TextLength > 0 && comboBoxDocument.SelectedItem != null)
            {
                Admission admission = new Admission();   
                AllDataAdmission allAdmission = new AllDataAdmission();
                string numberDocument = textBoxNumberDoc.Text;
                string seriesDocument = textBoxSerDoc.Text;
                string fullName = textBoxName.Text;
                if (textBoxSerDoc.Text.Length > 1)
                    numberDocument = $"{seriesDocument} {numberDocument}";
                int documentId = _context.DocumentNames.Where(x => x.DocumentName1 == comboBoxDocument.SelectedItem.ToString()).Select(x => x.Id).FirstOrDefault();

                admission.FullName = fullName;
                admission.DocumentsId = documentId;
                admission.DocumentNumber = numberDocument;
                admission.DateTime = DateTime.Now;
                admission.StateId = 1;

                allAdmission.FullName = fullName;
                allAdmission.DocumentsId = documentId;
                allAdmission.DocumentNumber = numberDocument;
                allAdmission.Date = DateTime.Now;
                allAdmission.Time = TimeSpan.Parse(DateTime.Now.ToString($"{DateTime.Now:T}"));
                allAdmission.StateId = 1;

                try
                {
                    _context.Admissions.Add(admission);
                    _context.AllDataAdmissions.Add(allAdmission);
                    _context.SaveChanges();
                    comboBoxDocument.Text = null;
                    textBoxNumberDoc.Text = null;
                    textBoxName.Text = null;
                    textBoxSerDoc.Text = null;
                    MessageBox.Show("Данные успешно сохранены", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(),"Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }         
            }
            else MessageBox.Show("Заполните все поля", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartMenu startMenu = new StartMenu();
            startMenu.Width = this.Width;
            startMenu.Height = this.Height;
            startMenu.Show();
        }
        private void AddAdmission_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false) return;
            if (e.KeyChar == Convert.ToChar(Keys.Back)) return;
            e.Handled = true;
        }
        private void textBoxNumberDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == true) return;
            if (e.KeyChar == Convert.ToChar(Keys.Back)) return;
            e.Handled = true;
        }
    }
}
