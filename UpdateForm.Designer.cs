namespace WindowsFormsApp2
{
    partial class UpdateForm
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
            this.genTextBox = new System.Windows.Forms.TextBox();
            this.varstaTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.updateListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // numeTextBox
            // 
            this.numeTextBox.Location = new System.Drawing.Point(136, 32);
            this.numeTextBox.Name = "numeTextBox";
            this.numeTextBox.Size = new System.Drawing.Size(100, 20);
            this.numeTextBox.TabIndex = 0;
            this.numeTextBox.Text = "Nume";
            // 
            // genTextBox
            // 
            this.genTextBox.Location = new System.Drawing.Point(136, 132);
            this.genTextBox.Name = "genTextBox";
            this.genTextBox.Size = new System.Drawing.Size(100, 20);
            this.genTextBox.TabIndex = 1;
            this.genTextBox.Text = "Gen";
            this.genTextBox.Click += new System.EventHandler(this.genTextBox_Click);
            // 
            // varstaTextBox
            // 
            this.varstaTextBox.Location = new System.Drawing.Point(136, 84);
            this.varstaTextBox.Name = "varstaTextBox";
            this.varstaTextBox.Size = new System.Drawing.Size(100, 20);
            this.varstaTextBox.TabIndex = 2;
            this.varstaTextBox.Text = "Varsta";
            this.varstaTextBox.Click += new System.EventHandler(this.varstaTextBox_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(195, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.AliceBlue;
            this.button2.Location = new System.Drawing.Point(112, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 27);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // updateListBox
            // 
            this.updateListBox.FormattingEnabled = true;
            this.updateListBox.Location = new System.Drawing.Point(12, 12);
            this.updateListBox.Name = "updateListBox";
            this.updateListBox.Size = new System.Drawing.Size(94, 199);
            this.updateListBox.TabIndex = 8;
            this.updateListBox.Click += new System.EventHandler(this.updateListBox_Click);
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 221);
            this.Controls.Add(this.updateListBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.varstaTextBox);
            this.Controls.Add(this.genTextBox);
            this.Controls.Add(this.numeTextBox);
            this.Name = "UpdateForm";
            this.Text = "Update";
            this.Activated += new System.EventHandler(this.UpdateForm_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numeTextBox;
        private System.Windows.Forms.TextBox genTextBox;
        private System.Windows.Forms.TextBox varstaTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox updateListBox;
    }
}