using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Diplom.Forms
{
    public partial class FindKey : Form
    {
        public FindKey()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
        private void FindKey_Load(object sender, EventArgs e)
        {          
            dateTimePicker1.Value = DateTime.Now;
            dataGridView1.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 14);
            
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select (FullName) AS ФИО, (AllDataTeachers.CabinetNumber) AS 'Номер кабинета', (Date) AS Дата, (Time) AS Время, (State) AS Статус\r\nfrom AllDataTeachers \r\njoin Teachers on AllDataTeachers.TeachersID = Teachers.ID\r\njoin State on AllDataTeachers.StateId = State.ID", connection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            dataGridView1.DataSource = dataSet.Tables[0];

            dataGridView1.Columns[0].Width = 300;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 100;
        }
        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCab.Text.Length > 0)
            {
                int cabinet = Convert.ToInt32(textBoxCab.Text);
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"[Номер кабинета] = '{cabinet}' and ФИО LIKE '%{textBoxName.Text}%'";
            }
            else
            {

                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"ФИО LIKE '%{textBoxName.Text}%'";
            }
        }
        private void textBoxCab_TextChanged(object sender, EventArgs e)
        {
            if(textBoxCab.Text.Length > 0)
            {
                int cabinet = Convert.ToInt32(textBoxCab.Text);
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"[Номер кабинета] = '{cabinet}'  and ФИО LIKE '%{textBoxName.Text}%'";
            }
            else
            {

                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"ФИО LIKE '%{textBoxName.Text}%'";
            }
        }

        private void dateTimePicker1_CloseUp(object sender, EventArgs e)
        {
            if (textBoxCab.Text.Length > 0)
            {
                int cabinet = Convert.ToInt32(textBoxCab.Text);
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Дата = '{dateTimePicker1.Value.Date}' and ФИО LIKE '%{textBoxName.Text}%' and [Номер кабинета] = '{cabinet}'";
            }
            else
            {
                
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Дата = '{dateTimePicker1.Value.Date}'and ФИО LIKE '%{textBoxName.Text}%'";
            }              
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
