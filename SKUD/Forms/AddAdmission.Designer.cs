namespace SKUD.Forms
{
    partial class AddAdmission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAdmission));
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxDocument = new System.Windows.Forms.ComboBox();
            this.textBoxNumberDoc = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSerDoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.LightCyan;
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxName.Location = new System.Drawing.Point(63, 172);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(321, 29);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxName_KeyPress);
            // 
            // comboBoxDocument
            // 
            this.comboBoxDocument.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxDocument.BackColor = System.Drawing.Color.LightCyan;
            this.comboBoxDocument.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.comboBoxDocument.FormattingEnabled = true;
            this.comboBoxDocument.Location = new System.Drawing.Point(428, 172);
            this.comboBoxDocument.Name = "comboBoxDocument";
            this.comboBoxDocument.Size = new System.Drawing.Size(343, 32);
            this.comboBoxDocument.TabIndex = 1;
            // 
            // textBoxNumberDoc
            // 
            this.textBoxNumberDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNumberDoc.BackColor = System.Drawing.Color.LightCyan;
            this.textBoxNumberDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNumberDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxNumberDoc.Location = new System.Drawing.Point(1022, 175);
            this.textBoxNumberDoc.MaxLength = 12;
            this.textBoxNumberDoc.Name = "textBoxNumberDoc";
            this.textBoxNumberDoc.Size = new System.Drawing.Size(184, 29);
            this.textBoxNumberDoc.TabIndex = 2;
            this.textBoxNumberDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumberDoc_KeyPress);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Linen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.button1.Location = new System.Drawing.Point(1104, 728);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 71);
            this.button1.TabIndex = 3;
            this.button1.Text = "Выдать пропуск";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.Linen;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 47);
            this.button2.TabIndex = 4;
            this.button2.Text = "Назад в меню";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.label1.Location = new System.Drawing.Point(193, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "ФИО";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.label4.Location = new System.Drawing.Point(480, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Выберите тип документа";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.label2.Location = new System.Drawing.Point(1033, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Номер документа";
            // 
            // textBoxSerDoc
            // 
            this.textBoxSerDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSerDoc.BackColor = System.Drawing.Color.LightCyan;
            this.textBoxSerDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSerDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxSerDoc.Location = new System.Drawing.Point(832, 175);
            this.textBoxSerDoc.MaxLength = 4;
            this.textBoxSerDoc.Name = "textBoxSerDoc";
            this.textBoxSerDoc.Size = new System.Drawing.Size(184, 29);
            this.textBoxSerDoc.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.label3.Location = new System.Drawing.Point(843, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "Серия документа";
            // 
            // AddAdmission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1314, 811);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSerDoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxNumberDoc);
            this.Controls.Add(this.comboBoxDocument);
            this.Controls.Add(this.textBoxName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1299, 489);
            this.Name = "AddAdmission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выдача пропусков";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddAdmission_FormClosed);
            this.Load += new System.EventHandler(this.AddAdmission_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ComboBox comboBoxDocument;
        private System.Windows.Forms.TextBox textBoxNumberDoc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSerDoc;
        private System.Windows.Forms.Label label3;
    }

        
    
}