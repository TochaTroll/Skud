namespace Diplom.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnedAdmission));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNumberDoc = new System.Windows.Forms.TextBox();
            this.buttonRet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Linen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 47);
            this.button1.TabIndex = 7;
            this.button1.Text = "Назад в меню";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.label1.Location = new System.Drawing.Point(492, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "ФИО";
            // 
            // comboBoxName
            // 
            this.comboBoxName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxName.BackColor = System.Drawing.Color.LightCyan;
            this.comboBoxName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Location = new System.Drawing.Point(349, 75);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(343, 32);
            this.comboBoxName.TabIndex = 9;
            this.comboBoxName.SelectionChangeCommitted += new System.EventHandler(this.comboBoxName_SelectionChangeCommitted);
            this.comboBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxName_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.label2.Location = new System.Drawing.Point(813, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Тип документа";
            // 
            // textBoxDoc
            // 
            this.textBoxDoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxDoc.BackColor = System.Drawing.Color.LightCyan;
            this.textBoxDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxDoc.Location = new System.Drawing.Point(770, 78);
            this.textBoxDoc.Name = "textBoxDoc";
            this.textBoxDoc.Size = new System.Drawing.Size(245, 29);
            this.textBoxDoc.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.label3.Location = new System.Drawing.Point(1100, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "Номер документа";
            // 
            // textBoxNumberDoc
            // 
            this.textBoxNumberDoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxNumberDoc.BackColor = System.Drawing.Color.LightCyan;
            this.textBoxNumberDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxNumberDoc.Location = new System.Drawing.Point(1089, 75);
            this.textBoxNumberDoc.Name = "textBoxNumberDoc";
            this.textBoxNumberDoc.Size = new System.Drawing.Size(184, 29);
            this.textBoxNumberDoc.TabIndex = 13;
            // 
            // buttonRet
            // 
            this.buttonRet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRet.AutoSize = true;
            this.buttonRet.BackColor = System.Drawing.Color.Linen;
            this.buttonRet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.buttonRet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.buttonRet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRet.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.buttonRet.Location = new System.Drawing.Point(1104, 728);
            this.buttonRet.Name = "buttonRet";
            this.buttonRet.Size = new System.Drawing.Size(198, 71);
            this.buttonRet.TabIndex = 14;
            this.buttonRet.Text = "Сдать пропуск";
            this.buttonRet.UseVisualStyleBackColor = false;
            this.buttonRet.Click += new System.EventHandler(this.buttonRet_Click);
            // 
            // ReturnedAdmission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1314, 811);
            this.Controls.Add(this.buttonRet);
            this.Controls.Add(this.textBoxNumberDoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1261, 412);
            this.Name = "ReturnedAdmission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сдача пропусков";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReturnedAdmission_FormClosed);
            this.Load += new System.EventHandler(this.ReturnedAdmission_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNumberDoc;
        private System.Windows.Forms.Button buttonRet;
    }
}