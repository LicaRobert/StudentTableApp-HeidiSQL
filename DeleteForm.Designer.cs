namespace WindowsFormsApp2
{
    partial class DeleteForm
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.comboBoxNume = new System.Windows.Forms.ComboBox();
            this.checkBoxNume = new System.Windows.Forms.CheckBox();
            this.checkBoxVarsta = new System.Windows.Forms.CheckBox();
            this.comboBoxVarsta = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOK.Location = new System.Drawing.Point(95, 122);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(77, 27);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnCancel.Location = new System.Drawing.Point(12, 122);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 27);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // comboBoxNume
            // 
            this.comboBoxNume.FormattingEnabled = true;
            this.comboBoxNume.Location = new System.Drawing.Point(12, 29);
            this.comboBoxNume.Name = "comboBoxNume";
            this.comboBoxNume.Size = new System.Drawing.Size(160, 21);
            this.comboBoxNume.TabIndex = 4;
            // 
            // checkBoxNume
            // 
            this.checkBoxNume.AutoSize = true;
            this.checkBoxNume.Location = new System.Drawing.Point(14, 6);
            this.checkBoxNume.Name = "checkBoxNume";
            this.checkBoxNume.Size = new System.Drawing.Size(54, 17);
            this.checkBoxNume.TabIndex = 5;
            this.checkBoxNume.Text = "Nume";
            this.checkBoxNume.UseVisualStyleBackColor = true;
            this.checkBoxNume.CheckedChanged += new System.EventHandler(this.CheckBoxNume_CheckedChanged);
            // 
            // checkBoxVarsta
            // 
            this.checkBoxVarsta.AutoSize = true;
            this.checkBoxVarsta.Location = new System.Drawing.Point(12, 56);
            this.checkBoxVarsta.Name = "checkBoxVarsta";
            this.checkBoxVarsta.Size = new System.Drawing.Size(56, 17);
            this.checkBoxVarsta.TabIndex = 6;
            this.checkBoxVarsta.Text = "Varsta";
            this.checkBoxVarsta.UseVisualStyleBackColor = true;
            this.checkBoxVarsta.CheckedChanged += new System.EventHandler(this.checkBoxVarsta_CheckedChanged);
            // 
            // comboBoxVarsta
            // 
            this.comboBoxVarsta.FormattingEnabled = true;
            this.comboBoxVarsta.Location = new System.Drawing.Point(14, 79);
            this.comboBoxVarsta.Name = "comboBoxVarsta";
            this.comboBoxVarsta.Size = new System.Drawing.Size(158, 21);
            this.comboBoxVarsta.TabIndex = 7;
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 161);
            this.Controls.Add(this.comboBoxVarsta);
            this.Controls.Add(this.checkBoxVarsta);
            this.Controls.Add(this.checkBoxNume);
            this.Controls.Add(this.comboBoxNume);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Name = "DeleteForm";
            this.Text = "Delete";
            this.Activated += new System.EventHandler(this.DeleteForm_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox comboBoxNume;
        private System.Windows.Forms.CheckBox checkBoxNume;
        private System.Windows.Forms.CheckBox checkBoxVarsta;
        private System.Windows.Forms.ComboBox comboBoxVarsta;
    }
}