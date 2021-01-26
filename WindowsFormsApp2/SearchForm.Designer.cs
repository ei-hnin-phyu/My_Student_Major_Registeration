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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.export = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.rMajor = new System.Windows.Forms.RadioButton();
            this.rEmail = new System.Windows.Forms.RadioButton();
            this.rName = new System.Windows.Forms.RadioButton();
            this.grid = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.export);
            this.groupBox1.Controls.Add(this.searchBtn);
            this.groupBox1.Controls.Add(this.searchTxt);
            this.groupBox1.Controls.Add(this.rMajor);
            this.groupBox1.Controls.Add(this.rEmail);
            this.groupBox1.Controls.Add(this.rName);
            this.groupBox1.Location = new System.Drawing.Point(12, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 98);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Student By";
            // 
            // export
            // 
            this.export.Location = new System.Drawing.Point(393, 51);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(75, 23);
            this.export.TabIndex = 5;
            this.export.Text = "Export";
            this.export.UseVisualStyleBackColor = true;
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(275, 51);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.Text = "Search     ";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchTxt
            // 
            this.searchTxt.Location = new System.Drawing.Point(15, 54);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(233, 20);
            this.searchTxt.TabIndex = 3;
            // 
            // rMajor
            // 
            this.rMajor.AutoSize = true;
            this.rMajor.Location = new System.Drawing.Point(202, 19);
            this.rMajor.Name = "rMajor";
            this.rMajor.Size = new System.Drawing.Size(51, 17);
            this.rMajor.TabIndex = 2;
            this.rMajor.TabStop = true;
            this.rMajor.Text = "Major";
            this.rMajor.UseVisualStyleBackColor = true;
            this.rMajor.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // rEmail
            // 
            this.rEmail.AutoSize = true;
            this.rEmail.Location = new System.Drawing.Point(116, 19);
            this.rEmail.Name = "rEmail";
            this.rEmail.Size = new System.Drawing.Size(50, 17);
            this.rEmail.TabIndex = 1;
            this.rEmail.TabStop = true;
            this.rEmail.Text = "Email";
            this.rEmail.UseVisualStyleBackColor = true;
            this.rEmail.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // rName
            // 
            this.rName.AutoSize = true;
            this.rName.Location = new System.Drawing.Point(15, 19);
            this.rName.Name = "rName";
            this.rName.Size = new System.Drawing.Size(53, 17);
            this.rName.TabIndex = 0;
            this.rName.TabStop = true;
            this.rName.Text = "Name";
            this.rName.UseVisualStyleBackColor = true;
            this.rName.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(27, 117);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(555, 181);
            this.grid.TabIndex = 1;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 318);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.groupBox1);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rMajor;
        private System.Windows.Forms.RadioButton rEmail;
        private System.Windows.Forms.RadioButton rName;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button export;
        private System.Windows.Forms.DataGridView grid;
    }
}