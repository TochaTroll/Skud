namespace Diplom.Forms
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddKey));
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.teachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sKUDDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sKUDDataSet = new Diplom.SKUDDataSet();
            this.comboBoxCabinet = new System.Windows.Forms.ComboBox();
            this.teachersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAdd = new System.Windows.Forms.Button();
            this.teachersTableAdapter = new Diplom.SKUDDataSetTableAdapters.TeachersTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sKUDDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sKUDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxName
            // 
            this.comboBoxName.BackColor = System.Drawing.Color.LightCyan;
            this.comboBoxName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxName.DataSource = this.teachersBindingSource;
            this.comboBoxName.DisplayMember = "FullName";
            this.comboBoxName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxName.ForeColor = System.Drawing.SystemColors.MenuText;
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxName.Location = new System.Drawing.Point(492, 75);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(351, 32);
            this.comboBoxName.TabIndex = 0;
            this.comboBoxName.SelectionChangeCommitted += new System.EventHandler(this.comboBoxName_SelectionChangeCommitted);
            this.comboBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxName_KeyPress);
            // 
            // teachersBindingSource
            // 
            this.teachersBindingSource.DataMember = "Teachers";
            this.teachersBindingSource.DataSource = this.sKUDDataSetBindingSource;
            // 
            // sKUDDataSetBindingSource
            // 
            this.sKUDDataSetBindingSource.DataSource = this.sKUDDataSet;
            this.sKUDDataSetBindingSource.Position = 0;
            // 
            // sKUDDataSet
            // 
            this.sKUDDataSet.DataSetName = "SKUDDataSet";
            this.sKUDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxCabinet
            // 
            this.comboBoxCabinet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCabinet.BackColor = System.Drawing.Color.LightCyan;
            this.comboBoxCabinet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxCabinet.DataSource = this.teachersBindingSource1;
            this.comboBoxCabinet.DisplayMember = "CabinetNumber";
            this.comboBoxCabinet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxCabinet.FormattingEnabled = true;
            this.comboBoxCabinet.Location = new System.Drawing.Point(1085, 75);
            this.comboBoxCabinet.Name = "comboBoxCabinet";
            this.comboBoxCabinet.Size = new System.Drawing.Size(91, 32);
            this.comboBoxCabinet.TabIndex = 1;
            this.comboBoxCabinet.SelectionChangeCommitted += new System.EventHandler(this.comboBoxCabinet_SelectionChangeCommitted);
            this.comboBoxCabinet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxCabinet_KeyPress);
            // 
            // teachersBindingSource1
            // 
            this.teachersBindingSource1.DataMember = "Teachers";
            this.teachersBindingSource1.DataSource = this.sKUDDataSetBindingSource;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.AutoSize = true;
            this.buttonAdd.BackColor = System.Drawing.Color.Linen;
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.buttonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.buttonAdd.Location = new System.Drawing.Point(1104, 692);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(198, 71);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Внести данные";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // teachersTableAdapter
            // 
            this.teachersTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Linen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 47);
            this.button1.TabIndex = 3;
            this.button1.Text = "Назад в меню";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.label1.Location = new System.Drawing.Point(557, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Выберите преподавателя";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.label2.Location = new System.Drawing.Point(1026, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Выберите кабинет";
            // 
            // AddKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1314, 811);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBoxCabinet);
            this.Controls.Add(this.comboBoxName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1158, 327);
            this.Name = "AddKey";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выдача ключей";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddKey_FormClosing);
            this.Load += new System.EventHandler(this.AddKey_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sKUDDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sKUDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxName;
        private System.Windows.Forms.ComboBox comboBoxCabinet;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.BindingSource sKUDDataSetBindingSource;
        private SKUDDataSet sKUDDataSet;
        private System.Windows.Forms.BindingSource teachersBindingSource;
        private SKUDDataSetTableAdapters.TeachersTableAdapter teachersTableAdapter;
        private System.Windows.Forms.BindingSource teachersBindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}