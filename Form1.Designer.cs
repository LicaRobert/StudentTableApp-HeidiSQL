namespace WindowsFormsApp2
{
    partial class Form1
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
            this.numeTextBox = new System.Windows.Forms.TextBox();
            this.prenumeTextBox = new System.Windows.Forms.TextBox();
            this.varstaTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stergeElev = new System.Windows.Forms.Button();
            this.updateElev = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.Button();
            this.searchElev = new System.Windows.Forms.Button();
            this.deleteAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // adaugaElev
            // 
            this.adaugaElev.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.adaugaElev.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adaugaElev.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.adaugaElev.Location = new System.Drawing.Point(11, 12);
            this.adaugaElev.Name = "adaugaElev";
            this.adaugaElev.Size = new System.Drawing.Size(99, 28);
            this.adaugaElev.TabIndex = 0;
            this.adaugaElev.Text = "adauga Elev";
            this.adaugaElev.UseVisualStyleBackColor = false;
            this.adaugaElev.Click += new System.EventHandler(this.adauga_Elev);
            // 
            // numeTextBox
            // 
            this.numeTextBox.Location = new System.Drawing.Point(12, 58);
            this.numeTextBox.Name = "numeTextBox";
            this.numeTextBox.Size = new System.Drawing.Size(100, 20);
            this.numeTextBox.TabIndex = 1;
            this.numeTextBox.Text = "nume elev";
            this.numeTextBox.Click += new System.EventHandler(this.adaugaNume);
            // 
            // prenumeTextBox
            // 
            this.prenumeTextBox.Location = new System.Drawing.Point(13, 97);
            this.prenumeTextBox.Name = "prenumeTextBox";
            this.prenumeTextBox.Size = new System.Drawing.Size(100, 20);
            this.prenumeTextBox.TabIndex = 2;
            this.prenumeTextBox.Text = "prenume elev";
            this.prenumeTextBox.UseWaitCursor = true;
            this.prenumeTextBox.Click += new System.EventHandler(this.adaugaPrenume);
            // 
            // varstaTextBox
            // 
            this.varstaTextBox.Location = new System.Drawing.Point(13, 139);
            this.varstaTextBox.Name = "varstaTextBox";
            this.varstaTextBox.Size = new System.Drawing.Size(100, 20);
            this.varstaTextBox.TabIndex = 3;
            this.varstaTextBox.Text = "10";
            this.varstaTextBox.Click += new System.EventHandler(this.adaugaVarsta);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(196, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(342, 209);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // stergeElev
            // 
            this.stergeElev.BackColor = System.Drawing.Color.Red;
            this.stergeElev.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stergeElev.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stergeElev.Location = new System.Drawing.Point(13, 165);
            this.stergeElev.Name = "stergeElev";
            this.stergeElev.Size = new System.Drawing.Size(99, 28);
            this.stergeElev.TabIndex = 5;
            this.stergeElev.Text = "sterge Elev";
            this.stergeElev.UseVisualStyleBackColor = false;
            this.stergeElev.Click += new System.EventHandler(this.button1_Click);
            // 
            // updateElev
            // 
            this.updateElev.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.updateElev.ForeColor = System.Drawing.SystemColors.Control;
            this.updateElev.Location = new System.Drawing.Point(13, 200);
            this.updateElev.Name = "updateElev";
            this.updateElev.Size = new System.Drawing.Size(99, 28);
            this.updateElev.TabIndex = 6;
            this.updateElev.Text = "update Elev";
            this.updateElev.UseVisualStyleBackColor = false;
            this.updateElev.Click += new System.EventHandler(this.button2_Click);
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.display.ForeColor = System.Drawing.Color.White;
            this.display.Location = new System.Drawing.Point(12, 234);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(99, 28);
            this.display.TabIndex = 7;
            this.display.Text = "display Elev";
            this.display.UseVisualStyleBackColor = false;
            this.display.Click += new System.EventHandler(this.button3_Click);
            // 
            // searchElev
            // 
            this.searchElev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.searchElev.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.searchElev.Location = new System.Drawing.Point(11, 268);
            this.searchElev.Name = "searchElev";
            this.searchElev.Size = new System.Drawing.Size(99, 28);
            this.searchElev.TabIndex = 8;
            this.searchElev.Text = "search Elev";
            this.searchElev.UseVisualStyleBackColor = false;
            this.searchElev.Click += new System.EventHandler(this.button4_Click);
            // 
            // deleteAll
            // 
            this.deleteAll.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.deleteAll.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteAll.Location = new System.Drawing.Point(128, 268);
            this.deleteAll.Name = "deleteAll";
            this.deleteAll.Size = new System.Drawing.Size(99, 28);
            this.deleteAll.TabIndex = 9;
            this.deleteAll.Text = "Delete All";
            this.deleteAll.UseVisualStyleBackColor = false;
            this.deleteAll.Click += new System.EventHandler(this.deleteAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 303);
            this.Controls.Add(this.deleteAll);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchElev);
            this.Controls.Add(this.display);
            this.Controls.Add(this.updateElev);
            this.Controls.Add(this.stergeElev);
            this.Controls.Add(this.varstaTextBox);
            this.Controls.Add(this.prenumeTextBox);
            this.Controls.Add(this.numeTextBox);
            this.Controls.Add(this.adaugaElev);
            this.Name = "Form1";
            this.Text = "Form";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button adaugaElev;
        private System.Windows.Forms.TextBox numeTextBox;
        private System.Windows.Forms.TextBox prenumeTextBox;
        private System.Windows.Forms.TextBox varstaTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button stergeElev;
        private System.Windows.Forms.Button updateElev;
        private System.Windows.Forms.Button display;
        private System.Windows.Forms.Button searchElev;
        private System.Windows.Forms.Button deleteAll;
    }
}

