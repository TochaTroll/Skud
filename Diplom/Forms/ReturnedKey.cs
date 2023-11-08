using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Diplom.Forms
{
    public partial class ReturnedKey : Form
    {
        int cabinetNumber;
        public ReturnedKey()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
        private void ReturnedKey_Load(object sender, EventArgs e)
        {
            string name;
            connection.Open();
            string sqlExpression = $"select * from AdmissionTeachers\r\njoin Teachers on AdmissionTeachers.TeachersID = Teachers.ID";
            SqlCommand sqlCommand = new SqlCommand(sqlExpression, connection);
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    name = reader.GetString(6);
                    comboBoxName.Items.Add(name);
                }

            }
            connection.Close();
        }        
        private void comboBoxName_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            comboBoxCab.Items.Clear();
            int teachersID;
            string nameSelected;
            if (comboBoxName.SelectedItem != null)
            {
                nameSelected = comboBoxName.SelectedItem.ToString();
                if (nameSelected != null)
                {
                    string sqlExpression = $"SELECT * FROM  Teachers WHERE FullName='{nameSelected}'";
                    connection.Open();
                    SqlCommand sqlCommand = new SqlCommand(sqlExpression, connection);
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        reader.Read();
                        teachersID = reader.GetInt32(0);
                    }
                    string sqlExpression1 = $"SELECT * FROM  AdmissionTeachers WHERE TeachersID='{teachersID}' AND StateId = '1'";
                    SqlCommand sqlCommand1 = new SqlCommand(sqlExpression1, connection);
                    using (SqlDataReader reader = sqlCommand1.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cabinetNumber = reader.GetInt32(2);

                            comboBoxCab.Items.Add(cabinetNumber);
                            comboBoxCab.Text = cabinetNumber.ToString();
                        }
                    }                
                    connection.Close();
                }
                else MessageBox.Show("Заполните все поля");
            }
            else MessageBox.Show("Заполните все поля");
        }
        private void buttonRet_Click_1(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string time = DateTime.Now.ToString($"{now:T}");
            string date = DateTime.Now.Date.ToString();
            if (comboBoxName.SelectedItem != null && comboBoxCab.SelectedItem != null)
            {
                string fullName = comboBoxName.Text;
                int cabinetNumber = Convert.ToInt32(comboBoxCab.Text);        
                int teachersID;

                string sqlExpression = $"SELECT * FROM  Teachers WHERE FullName='{fullName}'";
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlExpression, connection);
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    reader.Read();
                    teachersID = reader.GetInt32(0);                   
                }
                string sqlExpression1 = $"DELETE FROM AdmissionTeachers  WHERE CabinetNumber ='{cabinetNumber}' AND TeachersID = '{teachersID}'";
                SqlCommand sqlCommand1 = new SqlCommand(sqlExpression1, connection);
                sqlCommand1.ExecuteNonQuery();

                string sqlExpression3 = $"INSERT INTO AllDataTeachers (TeachersID, CabinetNumber, Date, Time, StateID) VALUES ('{teachersID}','{cabinetNumber}','{date}','{time}','2')";
                SqlCommand command1 = new SqlCommand(sqlExpression3, connection);
                command1.ExecuteNonQuery();

                comboBoxName.Text = null;
                comboBoxCab.Text = null;
                comboBoxName.Items.Clear();
                comboBoxCab.Items.Clear();

                string name;
                string sqlExpression2 = $"select * from AdmissionTeachers\r\njoin Teachers on AdmissionTeachers.TeachersID = Teachers.ID";
                SqlCommand sqlCommand2 = new SqlCommand(sqlExpression2, connection);
                using (SqlDataReader reader = sqlCommand2.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        name = reader.GetString(6);
                        comboBoxName.Items.Add(name);
                    }
                }

                ReturnedOk returnedOk = new ReturnedOk();
                returnedOk.ShowDialog();
                connection.Close();

            }
            else MessageBox.Show("Заполните все поля");
            
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

