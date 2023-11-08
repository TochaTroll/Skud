using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Diplom.Forms
{
    public partial class ReturnedAdmission : Form
    {
        public ReturnedAdmission()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
        private void ReturnedAdmission_Load(object sender, EventArgs e)
        {
            textBoxNumberDoc.Enabled = false;
            textBoxDoc.Enabled = false;

            string name;
            connection.Open();
            string sqlExpression = $"select * from Admission";
            SqlCommand sqlCommand = new SqlCommand(sqlExpression, connection);
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    name = reader.GetString(1);
                    comboBoxName.Items.Add(name);
                }

            }
            connection.Close();
        }
        private void comboBoxName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string name = comboBoxName.SelectedItem.ToString();
            connection.Open();

            string sqlExpression1 = $"select * from Admission\r\njoin DocumentName on Admission.DocumentsID = DocumentName.ID Where FullName = '{name}'";
            SqlCommand sqlCommand1 = new SqlCommand(sqlExpression1, connection);
            using (SqlDataReader reader = sqlCommand1.ExecuteReader())
            {
                reader.Read();
                string numberDoc = reader.GetString(3);
                string nameDoc = reader.GetString(7);
               
                textBoxNumberDoc.Text = numberDoc;
                textBoxDoc.Text = nameDoc;

            }       
            connection.Close();
        }
        private void buttonRet_Click(object sender, EventArgs e)
        {
            if (comboBoxName.SelectedItem != null)
            {
                DateTime now = DateTime.Now;
                string time = DateTime.Now.ToString($"{now:T}");
                string date = DateTime.Now.Date.ToString();

                string name = comboBoxName.SelectedItem.ToString();
                string numberDoc = textBoxNumberDoc.Text;
                string nameDoc = textBoxDoc.Text;
                int documenId;

                connection.Open();
                string sqlExpression = $"DELETE FROM Admission WHERE FullName ='{name}' AND DocumentNumber = '{numberDoc}'";
                SqlCommand sqlCommand = new SqlCommand(sqlExpression, connection);
                sqlCommand.ExecuteNonQuery();

                string sqlExpression1 = $"SELECT * FROM DocumentName WHERE DocumentName ='{nameDoc}'";
                SqlCommand sqlCommand1 = new SqlCommand(sqlExpression1, connection);
                using (SqlDataReader reader = sqlCommand1.ExecuteReader())
                {
                    reader.Read();
                    documenId = reader.GetInt32(0);

                }
                string sqlExpression2 = $"INSERT INTO AllDataAdmission (FullName, DocumentsID, DocumentNumber, Date, Time, StateId) VALUES ('{name}','{documenId}', '{numberDoc}', '{date}', '{time}', '2')";
                SqlCommand sqlCommand2 = new SqlCommand(sqlExpression2, connection);
                sqlCommand2.ExecuteNonQuery();

                comboBoxName.Text = null;
                comboBoxName.Items.Clear();
                textBoxDoc.Text = null;
                textBoxNumberDoc.Text = null;

                string sqlExpression3 = $"select * from Admission";
                SqlCommand sqlCommand3 = new SqlCommand(sqlExpression3, connection);
                using (SqlDataReader reader = sqlCommand3.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string Fulname = reader.GetString(1);
                        comboBoxName.Items.Add(Fulname);
                    }

                }
                connection.Close();

                ReturnedAdmissionOk ok = new ReturnedAdmissionOk();
                ok.ShowDialog();
            }
            else MessageBox.Show("Заполните все поля");                      
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartMenu startMenu = new StartMenu();
            startMenu.Width = this.Width;
            startMenu.Height = this.Height;
            startMenu.Show();
        }
        private void ReturnedAdmission_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void comboBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            ((ComboBox)(sender)).DroppedDown = true;
            if ((char.IsControl(e.KeyChar)))
                return;
            string Str = ((ComboBox)(sender)).Text.Substring(0, ((ComboBox)(sender)).SelectionStart) + e.KeyChar;
            int Index = ((ComboBox)(sender)).FindStringExact(Str);
            if (Index == -1)
                Index = ((ComboBox)(sender)).FindString(Str);
            ((ComboBox)sender).SelectedIndex = Index;
            ((ComboBox)(sender)).SelectionStart = Str.Length;
            ((ComboBox)(sender)).SelectionLength = ((ComboBox)(sender)).Text.Length - ((ComboBox)(sender)).SelectionStart;
            e.Handled = true;
        }
    }
}
