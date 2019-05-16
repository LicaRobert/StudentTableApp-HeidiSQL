namespace WindowsFormsApp2
{
    partial class InsertForm
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
            this.numeTextBox = new System.Windows.Forms.TextBox();
            this.varstaTextBox = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.radioMaleButton = new System.Windows.Forms.RadioButton();
            this.radioFemaleButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // numeTextBox
            // 
            this.numeTextBox.Location = new System.Drawing.Point(20, 27);
            this.numeTextBox.Name = "numeTextBox";
            this.numeTextBox.Size = new System.Drawing.Size(100, 20);
            this.numeTextBox.TabIndex = 0;
            this.numeTextBox.Text = "Nume";
            this.numeTextBox.Click += new System.EventHandler(this.numeTextBox_Click);
            this.numeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeTextBox_KeyPress);
            // 
            // varstaTextBox
            // 
            this.varstaTextBox.Location = new System.Drawing.Point(20, 71);
            this.varstaTextBox.Name = "varstaTextBox";
            this.varstaTextBox.Size = new System.Drawing.Size(100, 20);
            this.varstaTextBox.TabIndex = 2;
            this.varstaTextBox.Text = "Varsta";
            this.varstaTextBox.Click += new System.EventHandler(this.varstaTextBox_Click);
            this.varstaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.varstaTextBox_KeyPress);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cancelBtn.Location = new System.Drawing.Point(12, 156);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.okBtn.Location = new System.Drawing.Point(97, 156);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 4;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = false;
            this.okBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // radioMaleButton
            // 
            this.radioMaleButton.AutoSize = true;
            this.radioMaleButton.Location = new System.Drawing.Point(20, 107);
            this.radioMaleButton.Name = "radioMaleButton";
            this.radioMaleButton.Size = new System.Drawing.Size(34, 17);
            this.radioMaleButton.TabIndex = 5;
            this.radioMaleButton.TabStop = true;
            this.radioMaleButton.Text = "M";
            this.radioMaleButton.UseVisualStyleBackColor = true;
            this.radioMaleButton.CheckedChanged += new System.EventHandler(this.radioMaleButton_CheckedChanged);
            // 
            // radioFemaleButton
            // 
            this.radioFemaleButton.AutoSize = true;
            this.radioFemaleButton.Location = new System.Drawing.Point(89, 107);
            this.radioFemaleButton.Name = "radioFemaleButton";
            this.radioFemaleButton.Size = new System.Drawing.Size(31, 17);
            this.radioFemaleButton.TabIndex = 6;
            this.radioFemaleButton.TabStop = true;
            this.radioFemaleButton.Text = "F";
            this.radioFemaleButton.UseVisualStyleBackColor = true;
            this.radioFemaleButton.CheckedChanged += new System.EventHandler(this.radioFemaleButton_CheckedChanged);
            // 
            // InsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 191);
            this.Controls.Add(this.radioFemaleButton);
            this.Controls.Add(this.radioMaleButton);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.varstaTextBox);
            this.Controls.Add(this.numeTextBox);
            this.Name = "InsertForm";
            this.Text = "Insert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox varstaTextBox;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button okBtn;
        public System.Windows.Forms.TextBox numeTextBox;
        private System.Windows.Forms.RadioButton radioMaleButton;
        private System.Windows.Forms.RadioButton radioFemaleButton;
    }
}