namespace WindowsFormsApp2
{
    partial class SearchForm
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
            this.cancelBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.searchAfterName = new System.Windows.Forms.TextBox();
            this.searchNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.cancelBtn.Location = new System.Drawing.Point(66, 82);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 0;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.okBtn.Location = new System.Drawing.Point(147, 82);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 1;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // searchAfterName
            // 
            this.searchAfterName.Location = new System.Drawing.Point(103, 21);
            this.searchAfterName.Name = "searchAfterName";
            this.searchAfterName.Size = new System.Drawing.Size(100, 20);
            this.searchAfterName.TabIndex = 2;
            // 
            // searchNameLabel
            // 
            this.searchNameLabel.AutoSize = true;
            this.searchNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchNameLabel.Location = new System.Drawing.Point(0, 22);
            this.searchNameLabel.Name = "searchNameLabel";
            this.searchNameLabel.Size = new System.Drawing.Size(97, 16);
            this.searchNameLabel.TabIndex = 3;
            this.searchNameLabel.Text = "Search Name :";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 121);
            this.Controls.Add(this.searchNameLabel);
            this.Controls.Add(this.searchAfterName);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.cancelBtn);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.TextBox searchAfterName;
        private System.Windows.Forms.Label searchNameLabel;
    }
}