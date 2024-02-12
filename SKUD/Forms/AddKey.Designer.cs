namespace SKUD.Forms
{
    partial class AddKey
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxName = new ComboBox();
            comboBoxCabinet = new ComboBox();
            buttonAdd = new Button();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // comboBoxName
            // 
            comboBoxName.BackColor = Color.LightCyan;
            comboBoxName.Cursor = Cursors.Hand;
            comboBoxName.DisplayMember = "FullName";
            comboBoxName.FlatStyle = FlatStyle.Flat;
            comboBoxName.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxName.ForeColor = SystemColors.MenuText;
            comboBoxName.FormattingEnabled = true;
            comboBoxName.ImeMode = ImeMode.NoControl;
            comboBoxName.Location = new Point(574, 87);
            comboBoxName.Margin = new Padding(4, 3, 4, 3);
            comboBoxName.Name = "comboBoxName";
            comboBoxName.Size = new Size(409, 32);
            comboBoxName.TabIndex = 0;
            comboBoxName.SelectionChangeCommitted += comboBoxName_SelectionChangeCommitted;
            comboBoxName.KeyPress += comboBoxName_KeyPress;
            // 
            // comboBoxCabinet
            // 
            comboBoxCabinet.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxCabinet.BackColor = Color.LightCyan;
            comboBoxCabinet.Cursor = Cursors.Hand;
            comboBoxCabinet.DisplayMember = "CabinetNumber";
            comboBoxCabinet.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxCabinet.FormattingEnabled = true;
            comboBoxCabinet.Location = new Point(1266, 87);
            comboBoxCabinet.Margin = new Padding(4, 3, 4, 3);
            comboBoxCabinet.Name = "comboBoxCabinet";
            comboBoxCabinet.Size = new Size(106, 32);
            comboBoxCabinet.TabIndex = 1;
           
            
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonAdd.AutoSize = true;
            buttonAdd.BackColor = Color.Linen;
            buttonAdd.Cursor = Cursors.Hand;
            buttonAdd.FlatAppearance.MouseDownBackColor = Color.Coral;
            buttonAdd.FlatAppearance.MouseOverBackColor = Color.PeachPuff;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAdd.Location = new Point(1288, 798);
            buttonAdd.Margin = new Padding(4, 3, 4, 3);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(231, 82);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Внести данные";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.Linen;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.MouseDownBackColor = Color.Coral;
            button1.FlatAppearance.MouseOverBackColor = Color.PeachPuff;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(14, 14);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(252, 54);
            button1.TabIndex = 3;
            button1.Text = "Назад в меню";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(650, 53);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(243, 26);
            label1.TabIndex = 4;
            label1.Text = "Выберите преподавателя";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(1197, 53);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(177, 26);
            label2.TabIndex = 5;
            label2.Text = "Выберите кабинет";
            // 
            // AddKey
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(1533, 936);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(buttonAdd);
            Controls.Add(comboBoxCabinet);
            Controls.Add(comboBoxName);
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(1348, 371);
            Name = "AddKey";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Выдача ключей";
            FormClosing += AddKey_FormClosing;
            Load += AddKey_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxName;
        private ComboBox comboBoxCabinet;
        private Button buttonAdd;
        private Button button1;
        private Label label1;
        private Label label2;
    }
}