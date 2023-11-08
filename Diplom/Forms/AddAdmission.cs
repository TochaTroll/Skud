using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Diplom.Forms
{
    public partial class AddAdmission : Form
    {
        public AddAdmission()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
        private void AddAdmission_Load(object sender, EventArgs e)
        {         
            connection.Open();
            string sqlExpression = $"SELECT * FROM  DocumentName ";
            SqlCommand sqlCommand = new SqlCommand(sqlExpression, connection);
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    string NameDoc = reader.GetString(1);
                    comboBoxDocument.Items.Add(NameDoc);
                }
                connection.Close();            
            }           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string time = DateTime.Now.ToString($"{now:T}");
            string date = DateTime.Now.Date.ToString();

            DateTime dateTime= DateTime.Now;
            string numberDoc;
            string number;
            string serDoc;
            string name;
            string nameDoc;
            int idDoc;
            if (textBoxName.TextLength > 0 && textBoxNumberDoc.TextLength > 0 && comboBoxDocument.SelectedItem !=null )
            {
                number = textBoxNumberDoc.Text;
                serDoc = textBoxSerDoc.Text;

                if (textBoxSerDoc.Text.Length == 0) numberDoc = textBoxNumberDoc.Text;
                else numberDoc = $"{serDoc} {number}";

                name = textBoxName.Text;
                nameDoc = comboBoxDocument.Text;
                
                connection.Open();
                string sqlExpression = $"SELECT * FROM  DocumentName WHERE DocumentName = '{nameDoc}'";
                SqlCommand sqlCommand = new SqlCommand(sqlExpression, connection);
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    reader.Read();
                    idDoc = reader.GetInt32(0);
                }
                string sqlExpression2 = $"INSERT INTO Admission (FullName, DocumentsID, DocumentNumber, DateTime, StateId) VALUES ('{name}','{idDoc}','{numberDoc}','{dateTime}','1')";
                SqlCommand command = new SqlCommand(sqlExpression2, connection);
                command.ExecuteNonQuery();

                string sqlExpression3 = $"INSERT INTO AllDataAdmission (FullName, DocumentsID, DocumentNumber, Date, Time, StateId) VALUES ('{name}','{idDoc}','{numberDoc}','{date}','{time}','1')";
                SqlCommand command1 = new SqlCommand(sqlExpression3, connection);
                command1.ExecuteNonQuery();

                textBoxName.Text = null;
                textBoxSerDoc.Text= null;
                textBoxNumberDoc.Text = null;   
                comboBoxDocument.Items.Clear();
                comboBoxDocument.Text = null;

                string sqlExpression1 = $"SELECT * FROM  DocumentName ";
                SqlCommand sqlCommand1= new SqlCommand(sqlExpression1, connection);
                using (SqlDataReader reader = sqlCommand1.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string NameDoc = reader.GetString(1);
                        comboBoxDocument.Items.Add(NameDoc);
                    }
                }
                Ok ok = new Ok();
                ok.ShowDialog();
                connection.Close();
            }           
            else MessageBox.Show("Заполните все поля");
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
            if(e.KeyChar == Convert.ToChar(Keys.Back)) return;
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
