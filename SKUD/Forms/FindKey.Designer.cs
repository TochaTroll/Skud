namespace SKUD.Forms
{
    partial class FindKey
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
            dataGridView1 = new DataGridView();
            textBoxName = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            textBoxCab = new TextBox();
            label1 = new Label();
            buttonBack = new Button();
            label4 = new Label();
            label2 = new Label();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
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
            dataGridView1.Location = new Point(303, 151);
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
            dataGridView1.Size = new Size(952, 338);
            dataGridView1.TabIndex = 0;
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.Top;
            textBoxName.BackColor = Color.LightCyan;
            textBoxName.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(366, 110);
            textBoxName.Margin = new Padding(4, 3, 4, 3);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(277, 29);
            textBoxName.TabIndex = 1;
            textBoxName.TextChanged += textBoxName_TextChanged;
            textBoxName.KeyPress += textBoxName_KeyPress;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top;
            dateTimePicker1.CalendarMonthBackground = Color.LightCyan;
            dateTimePicker1.Checked = false;
            dateTimePicker1.Cursor = Cursors.Hand;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(886, 111);
            dateTimePicker1.Margin = new Padding(4, 3, 4, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(196, 29);
            dateTimePicker1.TabIndex = 2;
            dateTimePicker1.Value = new DateTime(2023, 3, 16, 0, 0, 0, 0);
            dateTimePicker1.CloseUp += dateTimePicker1_CloseUp;
            // 
            // textBoxCab
            // 
            textBoxCab.Anchor = AnchorStyles.Top;
            textBoxCab.BackColor = Color.LightCyan;
            textBoxCab.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCab.Location = new Point(704, 110);
            textBoxCab.Margin = new Padding(4, 3, 4, 3);
            textBoxCab.Name = "textBoxCab";
            textBoxCab.Size = new Size(108, 29);
            textBoxCab.TabIndex = 3;
            textBoxCab.TextChanged += textBoxCab_TextChanged;
            textBoxCab.KeyPress += textBoxCab_KeyPress;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(469, 76);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 26);
            label1.TabIndex = 4;
            label1.Text = " ФИО";
            // 
            // buttonBack
            // 
            buttonBack.AutoSize = true;
            buttonBack.BackColor = Color.Linen;
            buttonBack.Cursor = Cursors.Hand;
            buttonBack.FlatAppearance.MouseDownBackColor = Color.Coral;
            buttonBack.FlatAppearance.MouseOverBackColor = Color.PeachPuff;
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBack.Location = new Point(14, 13);
            buttonBack.Margin = new Padding(4, 3, 4, 3);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(252, 54);
            buttonBack.TabIndex = 8;
            buttonBack.Text = "Назад в меню";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(677, 76);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(163, 26);
            label4.TabIndex = 9;
            label4.Text = "Введите кабинет";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(892, 77);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(146, 26);
            label2.TabIndex = 10;
            label2.Text = "Выберите дату";
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.Top;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Font = new Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(1089, 105);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(184, 46);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "Не использовать дату";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // FindKey
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(1533, 936);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(buttonBack);
            Controls.Add(label1);
            Controls.Add(textBoxCab);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBoxName);
            Controls.Add(dataGridView1);
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(1277, 466);
            Name = "FindKey";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Поиск ключа";
            FormClosed += FindKey_FormClosed;
            Load += FindKey_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBoxName;
        private DateTimePicker dateTimePicker1;
        private TextBox textBoxCab;
        private Label label1;
        private Button buttonBack;
        private Label label4;
        private Label label2;
        private CheckBox checkBox1;
    }



}