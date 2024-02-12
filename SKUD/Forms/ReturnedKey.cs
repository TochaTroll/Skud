using Microsoft.EntityFrameworkCore;
using SKUD.Context;
using SKUD.Model;
using System.Data;

namespace SKUD.Forms
{
    public partial class ReturnedKey : Form
    {
        private readonly SkudContext _context;
        private List<AdmissionTeacher> AdmissionTeacher;
        public ReturnedKey()
        {
            InitializeComponent();
            _context = new SkudContext();
            AdmissionTeacher = _context.AdmissionTeachers.Include(x=>x.Teachers).ToList();         
        }
        private void ReturnedKey_Load(object sender, EventArgs e)
        {
            comboBoxName.Items.AddRange(AdmissionTeacher.Select(x=>x.Teachers.FullName).ToArray());
        } 
        private void comboBoxName_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            comboBoxCab.Items.Clear();
            if (comboBoxName.SelectedItem == null)
                return;
            AdmissionTeacher = _context.AdmissionTeachers.Where(x=>x.Teachers.FullName == comboBoxName.SelectedItem.ToString()).ToList();
            var cabinets = AdmissionTeacher.Select(x=>x.CabinetNumber.ToString()).ToArray();

            comboBoxCab.Items.AddRange(cabinets);            
            comboBoxCab.SelectedItem = cabinets[0];
        }
        private void buttonRet_Click_1(object sender, EventArgs e)
        {
            if (comboBoxName.SelectedItem != null && comboBoxCab.SelectedItem != null )
            {
                int teacherId = AdmissionTeacher.Select(x => x.Teachers.Id).First();
                int cabinet = Convert.ToInt32(comboBoxCab.SelectedItem);

                var allDataTeacher = new AllDataTeacher();
                allDataTeacher.TeachersId = teacherId;
                allDataTeacher.CabinetNumber = cabinet;
                allDataTeacher.StateId = 2;
                allDataTeacher.Date = DateTime.Now.Date;
                allDataTeacher.Time = TimeSpan.Parse(DateTime.Now.ToString($"{DateTime.Now:T}"));

                var admissonTeacher = AdmissionTeacher.Where(x=>x.CabinetNumber == cabinet).First();

                try
                {
                    _context.Add(allDataTeacher);
                    _context.AdmissionTeachers.Remove(admissonTeacher);
                    _context.SaveChanges();

                    comboBoxCab.Items.Clear();
                    comboBoxName.Items.Clear();
                    comboBoxName.Text = null;
                    comboBoxCab.Text = null;
                    AdmissionTeacher = _context.AdmissionTeachers.ToList(); 
                    comboBoxName.Items.AddRange(AdmissionTeacher.Select(x=>x.Teachers.FullName).ToArray());                   
                   
                    MessageBox.Show("Данные успешно сохранены", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else MessageBox.Show("Заполните все поля", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            StartMenu mainMenu = new StartMenu();
            mainMenu.Width = this.Width;
            mainMenu.Height = this.Height;
            mainMenu.Show();
        }
        private void ReturnedKey_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
