namespace WindowsFormsApp2
{
    partial class MainForm
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
            this.adaugaElev = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stergeElev = new System.Windows.Forms.Button();
            this.updateElev = new System.Windows.Forms.Button();
            this.searchElev = new System.Windows.Forms.Button();
            this.deleteAll = new System.Windows.Forms.Button();
            this.displayBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // adaugaElev
            // 
            this.adaugaElev.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.adaugaElev.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adaugaElev.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.adaugaElev.Location = new System.Drawing.Point(13, 32);
            this.adaugaElev.Name = "adaugaElev";
            this.adaugaElev.Size = new System.Drawing.Size(99, 28);
            this.adaugaElev.TabIndex = 0;
            this.adaugaElev.Text = "Insert";
            this.adaugaElev.UseVisualStyleBackColor = false;
            this.adaugaElev.Click += new System.EventHandler(this.Adauga_Elev);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(196, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(342, 209);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // stergeElev
            // 
            this.stergeElev.BackColor = System.Drawing.Color.Red;
            this.stergeElev.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stergeElev.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stergeElev.Location = new System.Drawing.Point(13, 83);
            this.stergeElev.Name = "stergeElev";
            this.stergeElev.Size = new System.Drawing.Size(99, 28);
            this.stergeElev.TabIndex = 5;
            this.stergeElev.Text = "Delete";
            this.stergeElev.UseVisualStyleBackColor = false;
            this.stergeElev.Click += new System.EventHandler(this.Button1_Click);
            // 
            // updateElev
            // 
            this.updateElev.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.updateElev.ForeColor = System.Drawing.SystemColors.Control;
            this.updateElev.Location = new System.Drawing.Point(13, 138);
            this.updateElev.Name = "updateElev";
            this.updateElev.Size = new System.Drawing.Size(99, 28);
            this.updateElev.TabIndex = 6;
            this.updateElev.Text = "Update";
            this.updateElev.UseVisualStyleBackColor = false;
            this.updateElev.Click += new System.EventHandler(this.Button2_Click);
            // 
            // searchElev
            // 
            this.searchElev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.searchElev.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.searchElev.Location = new System.Drawing.Point(11, 192);
            this.searchElev.Name = "searchElev";
            this.searchElev.Size = new System.Drawing.Size(99, 28);
            this.searchElev.TabIndex = 8;
            this.searchElev.Text = "Search";
            this.searchElev.UseVisualStyleBackColor = false;
            this.searchElev.Click += new System.EventHandler(this.Button4_Click);
            // 
            // deleteAll
            // 
            this.deleteAll.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.deleteAll.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteAll.Location = new System.Drawing.Point(11, 247);
            this.deleteAll.Name = "deleteAll";
            this.deleteAll.Size = new System.Drawing.Size(99, 28);
            this.deleteAll.TabIndex = 9;
            this.deleteAll.Text = "Delete All";
            this.deleteAll.UseVisualStyleBackColor = false;
            this.deleteAll.Click += new System.EventHandler(this.DeleteAll_Click);
            // 
            // displayBtn
            // 
            this.displayBtn.Location = new System.Drawing.Point(145, 252);
            this.displayBtn.Name = "displayBtn";
            this.displayBtn.Size = new System.Drawing.Size(75, 23);
            this.displayBtn.TabIndex = 10;
            this.displayBtn.Text = "Display";
            this.displayBtn.UseVisualStyleBackColor = true;
            this.displayBtn.Click += new System.EventHandler(this.displayBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 303);
            this.Controls.Add(this.displayBtn);
            this.Controls.Add(this.deleteAll);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchElev);
            this.Controls.Add(this.updateElev);
            this.Controls.Add(this.stergeElev);
            this.Controls.Add(this.adaugaElev);
            this.Name = "MainForm";
            this.Text = "Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button adaugaElev;
        private System.Windows.Forms.Button stergeElev;
        private System.Windows.Forms.Button updateElev;
        private System.Windows.Forms.Button searchElev;
        private System.Windows.Forms.Button deleteAll;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button displayBtn;
    }
}

