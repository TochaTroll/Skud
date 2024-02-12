namespace SKUD.Forms
{
    partial class ReturnedKey
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
            comboBoxCab = new ComboBox();
            buttonRet = new Button();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // comboBoxName
            // 
            comboBoxName.BackColor = Color.LightCyan;
            comboBoxName.Cursor = Cursors.Hand;
            comboBoxName.FlatStyle = FlatStyle.Flat;
            comboBoxName.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxName.FormattingEnabled = true;
            comboBoxName.Location = new Point(609, 87);
            comboBoxName.Margin = new Padding(4, 3, 4, 3);
            comboBoxName.Name = "comboBoxName";
            comboBoxName.Size = new Size(400, 32);
            comboBoxName.TabIndex = 0;
            comboBoxName.SelectionChangeCommitted += comboBoxName_SelectionChangeCommitted_1;
            comboBoxName.KeyPress += comboBoxName_KeyPress;
            // 
            // comboBoxCab
            // 
            comboBoxCab.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxCab.BackColor = Color.LightCyan;
            comboBoxCab.Cursor = Cursors.Hand;
            comboBoxCab.FlatStyle = FlatStyle.Flat;
            comboBoxCab.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxCab.FormattingEnabled = true;
            comboBoxCab.Location = new Point(1331, 87);
            comboBoxCab.Margin = new Padding(4, 3, 4, 3);
            comboBoxCab.Name = "comboBoxCab";
            comboBoxCab.Size = new Size(114, 32);
            comboBoxCab.TabIndex = 1;
            // 
            // buttonRet
            // 
            buttonRet.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonRet.AutoSize = true;
            buttonRet.BackColor = Color.Linen;
            buttonRet.Cursor = Cursors.Hand;
            buttonRet.FlatAppearance.MouseDownBackColor = Color.Coral;
            buttonRet.FlatAppearance.MouseOverBackColor = Color.PeachPuff;
            buttonRet.FlatStyle = FlatStyle.Flat;
            buttonRet.Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRet.Location = new Point(1288, 840);
            buttonRet.Margin = new Padding(4, 3, 4, 3);
            buttonRet.Name = "buttonRet";
            buttonRet.Size = new Size(231, 82);
            buttonRet.TabIndex = 2;
            buttonRet.Text = "Сдать ключ";
            buttonRet.UseVisualStyleBackColor = false;
            buttonRet.Click += buttonRet_Click_1;
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
            button1.TabIndex = 6;
            button1.Text = "Назад в меню";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(680, 53);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(243, 26);
            label1.TabIndex = 7;
            label1.Text = "Выберите преподавателя";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(1282, 53);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(177, 26);
            label2.TabIndex = 8;
            label2.Text = "Выберите кабинет";
            // 
            // ReturnedKey
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(1533, 936);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(buttonRet);
            Controls.Add(comboBoxCab);
            Controls.Add(comboBoxName);
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(1348, 371);
            Name = "ReturnedKey";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Сдача ключей";
            FormClosed += ReturnedKey_FormClosed;
            Load += ReturnedKey_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxName;
        private ComboBox comboBoxCab;
        private Button buttonRet;
        private Button button1;
        private Label label1;
        private Label label2;
    }

}