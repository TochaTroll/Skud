using System;
using System.Windows.Forms;

namespace Diplom.Forms
{
    public partial class Ok : Form
    {
        public Ok()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();                    
        }       
    }
}
