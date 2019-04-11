namespace WindowsFormsApp2
{
    partial class Form2
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
            this.prenumeTextBox = new System.Windows.Forms.TextBox();
            this.varstaTextBox = new System.Windows.Forms.TextBox();
            this.numeInitialTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numeTextBox
            // 
            this.numeTextBox.Location = new System.Drawing.Point(22, 30);
            this.numeTextBox.Name = "numeTextBox";
            this.numeTextBox.Size = new System.Drawing.Size(100, 20);
            this.numeTextBox.TabIndex = 0;
            this.numeTextBox.Text = "Nume";
            // 
            // prenumeTextBox
            // 
            this.prenumeTextBox.Location = new System.Drawing.Point(22, 67);
            this.prenumeTextBox.Name = "prenumeTextBox";
            this.prenumeTextBox.Size = new System.Drawing.Size(100, 20);
            this.prenumeTextBox.TabIndex = 1;
            this.prenumeTextBox.Text = "Prenume";
            // 
            // varstaTextBox
            // 
            this.varstaTextBox.Location = new System.Drawing.Point(22, 103);
            this.varstaTextBox.Name = "varstaTextBox";
            this.varstaTextBox.Size = new System.Drawing.Size(100, 20);
            this.varstaTextBox.TabIndex = 2;
            this.varstaTextBox.Text = "Varsta";
            // 
            // numeInitialTextBox
            // 
            this.numeInitialTextBox.Location = new System.Drawing.Point(22, 146);
            this.numeInitialTextBox.Name = "numeInitialTextBox";
            this.numeInitialTextBox.Size = new System.Drawing.Size(100, 20);
            this.numeInitialTextBox.TabIndex = 3;
            this.numeInitialTextBox.Text = "NumeInitial";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(195, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.AliceBlue;
            this.button2.Location = new System.Drawing.Point(112, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 27);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numeInitialTextBox);
            this.Controls.Add(this.varstaTextBox);
            this.Controls.Add(this.prenumeTextBox);
            this.Controls.Add(this.numeTextBox);
            this.Name = "Form2";
            this.Text = "Update Elev";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numeTextBox;
        private System.Windows.Forms.TextBox prenumeTextBox;
        private System.Windows.Forms.TextBox varstaTextBox;
        private System.Windows.Forms.TextBox numeInitialTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}