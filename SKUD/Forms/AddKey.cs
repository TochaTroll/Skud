using SKUD.Context;
using SKUD.Model;
using System.Data;

namespace SKUD.Forms
{
    public partial class AddKey : Form
    {
        private readonly SkudContext _context;
        private readonly List<Teacher> _teachers = new List<Teacher>(); 
        public AddKey()
        {
            InitializeComponent();
            _context = new SkudContext();
            _teachers = _context.Teachers.ToList();
        }
        private void AddKey_Load(object sender, EventArgs e)
        {          
            foreach (var teacher in _teachers)
            {
                comboBoxName.Items.Add(teacher.FullName);
                comboBoxCabinet.Items.Add(teacher.CabinetNumber);
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxName.SelectedItem != null && comboBoxCabinet.SelectedItem != null)
            {
                if (_context.AdmissionTeachers.Where(x => x.CabinetNumber == Convert.ToInt32(comboBoxCabinet.Text)).Count() < 1)
                {
                    int teachersID = _teachers.Where(x => x.FullName == comboBoxName.Text).Select(x => x.Id).FirstOrDefault();
                    int cabinetNumber = Convert.ToInt32(comboBoxCabinet.Text);

                    var admissonTeacher = new AdmissionTeacher();
                    admissonTeacher.TeachersId = teachersID;
                    admissonTeacher.CabinetNumber = cabinetNumber;
                    admissonTeacher.StateId = 1;
                    admissonTeacher.DateTime = DateTime.Now;

                    var allDataTeacher = new AllDataTeacher();
                    allDataTeacher.TeachersId = teachersID;
                    allDataTeacher.CabinetNumber = cabinetNumber;
                    allDataTeacher.StateId = 1;
                    allDataTeacher.Date = DateTime.Now.Date;
                    allDataTeacher.Time = TimeSpan.Parse(DateTime.Now.ToString($"{DateTime.Now:T}"));

                    _context.AdmissionTeachers.Add(admissonTeacher);
                    _context.AllDataTeachers.Add(allDataTeacher);
                    _context.SaveChanges();

                    MessageBox.Show("Данные успешно сохранены", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Данный кабнет уже занят", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Заполните все поля", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void comboBoxName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxName.SelectedItem != null)
            {             
                var cabinet = _teachers.Where(x => x.FullName == comboBoxName.SelectedItem.ToString()).Select(x => x.CabinetNumber).FirstOrDefault();
                comboBoxCabinet.Text = cabinet.ToString();
            }
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
        private void AddKey_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }         
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartMenu menu = new StartMenu();
            menu.Width = this.Width;
            menu.Height = this.Height;
            menu.Show();
        }
    }
}



