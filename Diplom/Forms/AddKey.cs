using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace Diplom.Forms
{
    public partial class AddKey : Form
    {
        public AddKey()
        {
            InitializeComponent();
        }    
        private void AddKey_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sKUDDataSet.Teachers". При необходимости она может быть перемещена или удалена.
            this.teachersTableAdapter.Fill(this.sKUDDataSet.Teachers);

            comboBoxName.Text = null;
            comboBoxCabinet.Text = null;
            
        }      
        List<string> list = new List<string>();
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
        private void buttonAdd_Click(object sender, EventArgs e)
        {        
            if (comboBoxName.SelectedItem != null && comboBoxCabinet.SelectedItem !=null)
            {
                DateTime now = DateTime.Now;
                string time = DateTime.Now.ToString($"{now:T}");             
                string date = DateTime.Now.Date.ToString();            
                DateTime dateTime = DateTime.Now;

                int teachersID;
                int cabinetNumber = Convert.ToInt32(comboBoxCabinet.Text);
                string fullName = comboBoxName.Text;             
                connection.Open();

                string sqlExpression = $"SELECT * FROM  Teachers WHERE FullName='{fullName}'";
                SqlCommand sqlCommand = new SqlCommand(sqlExpression, connection);
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    reader.Read();
                    teachersID = reader.GetInt32(0);                       
                }

                if (list.Count > 0)
                {
                    MessageBox.Show("Кабинет уже занят");
                    list.Clear();
                }
                else if (list.Count == 0)
                {                 
                    string sqlExpression2 = $"INSERT INTO AdmissionTeachers (TeachersID, CabinetNumber, DateTime, StateID) VALUES ('{teachersID}','{cabinetNumber}','{dateTime}','1')";
                    SqlCommand command = new SqlCommand(sqlExpression2, connection);
                    command.ExecuteNonQuery();

                    string sqlExpression3 = $"INSERT INTO AllDataTeachers (TeachersID, CabinetNumber, Date, Time, StateID) VALUES ('{teachersID}','{cabinetNumber}','{date}','{time}','1')";
                    SqlCommand command1 = new SqlCommand(sqlExpression3, connection);
                    command1.ExecuteNonQuery();

                    comboBoxName.Text = null;
                    comboBoxCabinet.Text = null;

                    Ok ok = new Ok();
                    ok.ShowDialog();                  
                }
            }
            else MessageBox.Show("Заполните все поля!");
            connection.Close();
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
        private void comboBoxName_SelectionChangeCommitted(object sender, EventArgs e)
        {         
            int cabinetNumber;
            if (comboBoxName.SelectedItem != null)
            {
                DataRowView drv = (DataRowView)comboBoxName.SelectedItem;
                String name = drv["FullName"].ToString();
                if (name != null)
                {                   
                    string sqlExpression = $"SELECT * FROM  Teachers WHERE FullName='{name}'";
                    connection.Open();
                    SqlCommand sqlCommand = new SqlCommand(sqlExpression, connection);
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        reader.Read();
                        cabinetNumber = reader.GetInt32(2);                       
                    }
                    comboBoxCabinet.Text = cabinetNumber.ToString();
                    string sqlExpression1 = $"SELECT * FROM  AdmissionTeachers WHERE CabinetNumber = '{comboBoxCabinet.Text}'";                   
                    SqlCommand sqlCommand1 = new SqlCommand(sqlExpression1, connection);                
                    using (SqlDataReader reader1 = sqlCommand1.ExecuteReader())
                    {
                        while (reader1.Read())
                        {
                            var CabinetNumber1 = Convert.ToString(reader1.GetInt32(2));
                            list.Add(CabinetNumber1);
                        }
                        connection.Close();
                    }
                }
                else MessageBox.Show("Пусто");
            }
            else MessageBox.Show("Пусто");         
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartMenu menu = new StartMenu();
            menu.Width = this.Width;
            menu.Height = this.Height;
            menu.Show();
        }
        private void comboBoxCabinet_SelectionChangeCommitted(object sender, EventArgs e)
        {
            list.Clear();
            DataRowView drv = (DataRowView)comboBoxCabinet.SelectedItem;
            String cabinet = drv["CabinetNumber"].ToString();
            string sqlExpression1 = $"SELECT * FROM  AdmissionTeachers WHERE CabinetNumber = '{cabinet}'";
            connection.Open();
            SqlCommand sqlCommand1 = new SqlCommand(sqlExpression1, connection);
            using (SqlDataReader reader1 = sqlCommand1.ExecuteReader())
            {
                while (reader1.Read())
                {
                    var CabinetNumber1 = Convert.ToString(reader1.GetInt32(2));
                    list.Add(CabinetNumber1);

                }
                connection.Close();
            }
            
        }
        private void AddKey_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); 
        }
        private void comboBoxCabinet_KeyPress(object sender, KeyPressEventArgs e)
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
