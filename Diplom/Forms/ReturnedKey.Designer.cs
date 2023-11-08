namespace Diplom.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnedKey));
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.comboBoxCab = new System.Windows.Forms.ComboBox();
            this.buttonRet = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxName
            // 
            this.comboBoxName.BackColor = System.Drawing.Color.LightCyan;
            this.comboBoxName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Location = new System.Drawing.Point(522, 75);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(343, 32);
            this.comboBoxName.TabIndex = 0;
            this.comboBoxName.SelectionChangeCommitted += new System.EventHandler(this.comboBoxName_SelectionChangeCommitted_1);
            this.comboBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxName_KeyPress);
            // 
            // comboBoxCab
            // 
            this.comboBoxCab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCab.BackColor = System.Drawing.Color.LightCyan;
            this.comboBoxCab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxCab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.comboBoxCab.FormattingEnabled = true;
            this.comboBoxCab.Location = new System.Drawing.Point(1141, 75);
            this.comboBoxCab.Name = "comboBoxCab";
            this.comboBoxCab.Size = new System.Drawing.Size(98, 32);
            this.comboBoxCab.TabIndex = 1;
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
            this.buttonRet.TabIndex = 2;
            this.buttonRet.Text = "Сдать ключ";
            this.buttonRet.UseVisualStyleBackColor = false;
            this.buttonRet.Click += new System.EventHandler(this.buttonRet_Click_1);
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
            this.button1.TabIndex = 6;
            this.button1.Text = "Назад в меню";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.label1.Location = new System.Drawing.Point(583, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Выберите преподавателя";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.label2.Location = new System.Drawing.Point(1099, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Выберите кабинет";
            // 
            // ReturnedKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1314, 811);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonRet);
            this.Controls.Add(this.comboBoxCab);
            this.Controls.Add(this.comboBoxName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1158, 327);
            this.Name = "ReturnedKey";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сдача ключей";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReturnedKey_FormClosed);
            this.Load += new System.EventHandler(this.ReturnedKey_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxName;
        private System.Windows.Forms.ComboBox comboBoxCab;
        private System.Windows.Forms.Button buttonRet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}