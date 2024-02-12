namespace SKUD.Forms
{
    partial class ReturnedAdmission
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
            button1 = new Button();
            label1 = new Label();
            comboBoxName = new ComboBox();
            label2 = new Label();
            textBoxDoc = new TextBox();
            label3 = new Label();
            textBoxNumberDoc = new TextBox();
            buttonRet = new Button();
            SuspendLayout();
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
            button1.TabIndex = 7;
            button1.Text = "Назад в меню";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(454, 53);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(53, 26);
            label1.TabIndex = 8;
            label1.Text = "ФИО";
            // 
            // comboBoxName
            // 
            comboBoxName.Anchor = AnchorStyles.Top;
            comboBoxName.BackColor = Color.LightCyan;
            comboBoxName.Cursor = Cursors.Hand;
            comboBoxName.FlatStyle = FlatStyle.Flat;
            comboBoxName.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxName.FormattingEnabled = true;
            comboBoxName.Location = new Point(287, 87);
            comboBoxName.Margin = new Padding(4, 3, 4, 3);
            comboBoxName.Name = "comboBoxName";
            comboBoxName.Size = new Size(400, 32);
            comboBoxName.TabIndex = 9;
            comboBoxName.SelectionChangeCommitted += comboBoxName_SelectionChangeCommitted;
            comboBoxName.KeyPress += comboBoxName_KeyPress;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(928, 53);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(150, 26);
            label2.TabIndex = 10;
            label2.Text = "Тип документа";
            // 
            // textBoxDoc
            // 
            textBoxDoc.Anchor = AnchorStyles.Top;
            textBoxDoc.BackColor = Color.LightCyan;
            textBoxDoc.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDoc.Location = new Point(790, 90);
            textBoxDoc.Margin = new Padding(4, 3, 4, 3);
            textBoxDoc.Name = "textBoxDoc";
            textBoxDoc.Size = new Size(423, 29);
            textBoxDoc.TabIndex = 11;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(1283, 53);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(173, 26);
            label3.TabIndex = 12;
            label3.Text = "Номер документа";
            // 
            // textBoxNumberDoc
            // 
            textBoxNumberDoc.Anchor = AnchorStyles.Top;
            textBoxNumberDoc.BackColor = Color.LightCyan;
            textBoxNumberDoc.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNumberDoc.Location = new Point(1256, 90);
            textBoxNumberDoc.Margin = new Padding(4, 3, 4, 3);
            textBoxNumberDoc.Name = "textBoxNumberDoc";
            textBoxNumberDoc.Size = new Size(214, 29);
            textBoxNumberDoc.TabIndex = 13;
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
            buttonRet.TabIndex = 14;
            buttonRet.Text = "Сдать пропуск";
            buttonRet.UseVisualStyleBackColor = false;
            buttonRet.Click += buttonRet_Click;
            // 
            // ReturnedAdmission
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(1533, 936);
            Controls.Add(buttonRet);
            Controls.Add(textBoxNumberDoc);
            Controls.Add(label3);
            Controls.Add(textBoxDoc);
            Controls.Add(label2);
            Controls.Add(comboBoxName);
            Controls.Add(label1);
            Controls.Add(button1);
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(1468, 469);
            Name = "ReturnedAdmission";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Сдача пропусков";
            FormClosed += ReturnedAdmission_FormClosed;
            Load += ReturnedAdmission_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private ComboBox comboBoxName;
        private Label label2;
        private TextBox textBoxDoc;
        private Label label3;
        private TextBox textBoxNumberDoc;
        private Button buttonRet;
    }



}