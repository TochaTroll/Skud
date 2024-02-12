namespace SKUD.Forms
{
    partial class FindAdmission
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label2 = new Label();
            button2 = new Button();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBoxName = new TextBox();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            comboBoxDoc = new ComboBox();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(1110, 123);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(146, 26);
            label2.TabIndex = 18;
            label2.Text = "Выберите дату";
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackColor = Color.Linen;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.MouseDownBackColor = Color.Coral;
            button2.FlatAppearance.MouseOverBackColor = Color.PeachPuff;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(4, 14);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(252, 54);
            button2.TabIndex = 16;
            button2.Text = "Назад в меню";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(223, 117);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 26);
            label1.TabIndex = 15;
            label1.Text = " ФИО";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top;
            dateTimePicker1.CalendarMonthBackground = Color.LightCyan;
            dateTimePicker1.Cursor = Cursors.Hand;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(1101, 157);
            dateTimePicker1.Margin = new Padding(4, 3, 4, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(196, 29);
            dateTimePicker1.TabIndex = 13;
            dateTimePicker1.Value = new DateTime(2023, 3, 16, 0, 0, 0, 0);
            dateTimePicker1.CloseUp += dateTimePicker1_CloseUp_1;
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.Top;
            textBoxName.BackColor = Color.LightCyan;
            textBoxName.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(139, 153);
            textBoxName.Margin = new Padding(4, 3, 4, 3);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(258, 29);
            textBoxName.TabIndex = 12;
            textBoxName.TextChanged += textBoxName_TextChanged;
            textBoxName.KeyPress += textBoxName_KeyPress;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top;
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(59, 197);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Size = new Size(1418, 388);
            dataGridView1.TabIndex = 11;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(597, 117);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(150, 26);
            label3.TabIndex = 20;
            label3.Text = "Тип документа";
            // 
            // comboBoxDoc
            // 
            comboBoxDoc.Anchor = AnchorStyles.Top;
            comboBoxDoc.BackColor = Color.LightCyan;
            comboBoxDoc.Cursor = Cursors.Hand;
            comboBoxDoc.DisplayMember = "CabinetNumber";
            comboBoxDoc.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxDoc.FormattingEnabled = true;
            comboBoxDoc.Location = new Point(476, 150);
            comboBoxDoc.Margin = new Padding(4, 3, 4, 3);
            comboBoxDoc.Name = "comboBoxDoc";
            comboBoxDoc.Size = new Size(414, 32);
            comboBoxDoc.TabIndex = 21;
            comboBoxDoc.SelectionChangeCommitted += comboBoxDoc_SelectionChangeCommitted;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.Top;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Font = new Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(1304, 150);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(184, 46);
            checkBox1.TabIndex = 22;
            checkBox1.Text = "Не использовать дату";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // FindAdmission
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(1533, 936);
            Controls.Add(checkBox1);
            Controls.Add(comboBoxDoc);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBoxName);
            Controls.Add(dataGridView1);
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(1348, 607);
            Name = "FindAdmission";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Поиск пропуска";
            FormClosed += FindAdmission_FormClosed;
            Load += FindAdmission_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button button2;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBoxName;
        private DataGridView dataGridView1;
        private Label label3;
        private ComboBox comboBoxDoc;
        private CheckBox checkBox1;
    }
}