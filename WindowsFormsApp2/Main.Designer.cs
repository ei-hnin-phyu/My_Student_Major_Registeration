namespace WindowsFormsApp2
{
    partial class Main
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
            this.registerBtn = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.studentList = new System.Windows.Forms.Button();
            this.majorForm = new System.Windows.Forms.Button();
            this.majorList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(30, 62);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(102, 29);
            this.registerBtn.TabIndex = 0;
            this.registerBtn.Text = "Register Student";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(171, 62);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(93, 29);
            this.search.TabIndex = 2;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // studentList
            // 
            this.studentList.Location = new System.Drawing.Point(305, 62);
            this.studentList.Name = "studentList";
            this.studentList.Size = new System.Drawing.Size(126, 29);
            this.studentList.TabIndex = 3;
            this.studentList.Text = "Student List By Age";
            this.studentList.UseVisualStyleBackColor = true;
            this.studentList.Click += new System.EventHandler(this.studentList_Click);
            // 
            // majorForm
            // 
            this.majorForm.Location = new System.Drawing.Point(466, 62);
            this.majorForm.Name = "majorForm";
            this.majorForm.Size = new System.Drawing.Size(150, 29);
            this.majorForm.TabIndex = 4;
            this.majorForm.Text = "Major Form";
            this.majorForm.UseVisualStyleBackColor = true;
            this.majorForm.Click += new System.EventHandler(this.majorForm_Click);
            // 
            // majorList
            // 
            this.majorList.Location = new System.Drawing.Point(646, 62);
            this.majorList.Name = "majorList";
            this.majorList.Size = new System.Drawing.Size(104, 29);
            this.majorList.TabIndex = 5;
            this.majorList.Text = "Major List";
            this.majorList.UseVisualStyleBackColor = true;
            this.majorList.Click += new System.EventHandler(this.majorList_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.majorList);
            this.Controls.Add(this.majorForm);
            this.Controls.Add(this.studentList);
            this.Controls.Add(this.search);
            this.Controls.Add(this.registerBtn);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button studentList;
        private System.Windows.Forms.Button majorForm;
        private System.Windows.Forms.Button majorList;
    }
}