using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Diplom.Forms
{
    public partial class FindAdmission : Form
    {
        public FindAdmission()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
        private void FindAdmissioncs_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            dataGridView1.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 14);
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select (AllDataAdmission.FullName) AS ФИО, (DocumentName) AS 'Тип документа', (DocumentNumber) AS 'Номер документа', (Date) AS Дата, (Time) AS Время, (State) AS Статус \r\nfrom AllDataAdmission\r\njoin DocumentName on AllDataAdmission.DocumentsID = DocumentName.ID\r\njoin State on  AllDataAdmission.StateId= State.ID\r\n", connection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];

            connection.Open();
            string sqlExpression = $"SELECT * FROM  DocumentName ";
            SqlCommand sqlCommand = new SqlCommand(sqlExpression, connection);
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    string NameDoc = reader.GetString(1);
                    comboBoxDoc.Items.Add(NameDoc);
                }
                connection.Close();
            }
            dataGridView1.Columns[0].Width = 300;
            dataGridView1.Columns[1].Width = 370;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].Width = 100;
        }

        private void dateTimePicker1_CloseUp_1(object sender, EventArgs e)
        {
            if (comboBoxDoc.SelectedItem != null)
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Дата = '{dateTimePicker1.Value.Date}' and ФИО LIKE '%{textBoxName.Text}%' and [Тип документа] = '{nameDoc}'";
            }
            else (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Дата = '{dateTimePicker1.Value.Date}' and ФИО LIKE '%{textBoxName.Text}%'";
        }
        private void FindAdmission_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }
        string nameDoc;
        private void comboBoxDoc_SelectionChangeCommitted(object sender, EventArgs e)
        {                   
            nameDoc = comboBoxDoc.SelectedItem.ToString();
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $" ФИО LIKE '%{textBoxName.Text}%' and [Тип документа] = '{nameDoc}'";                    
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxDoc.SelectedItem != null)
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"ФИО LIKE '%{textBoxName.Text}%' and [Тип документа] = '{nameDoc}'";
            }
            else (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"ФИО LIKE '%{textBoxName.Text}%'";


        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            StartMenu startMenu = new StartMenu();
            startMenu.Width = this.Width;
            startMenu.Height = this.Height;
            startMenu.Show();
        }
        private void comboBoxDoc_KeyUp(object sender, KeyEventArgs e)
        {
            if (comboBoxDoc.Text.Length == 0)
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"ФИО LIKE '%{textBoxName.Text}%'";
            }
        }
    }
}
