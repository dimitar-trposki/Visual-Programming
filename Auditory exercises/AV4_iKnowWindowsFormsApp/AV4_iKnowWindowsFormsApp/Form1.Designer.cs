namespace AV4_iKnowWindowsFormsApp
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
            this.lbCourses = new System.Windows.Forms.ListBox();
            this.clbEnrolledCourses = new System.Windows.Forms.CheckedListBox();
            this.btnMoveRight = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbNewCourse = new System.Windows.Forms.TextBox();
            this.btnMoveLeft = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCourses
            // 
            this.lbCourses.FormattingEnabled = true;
            this.lbCourses.ItemHeight = 16;
            this.lbCourses.Location = new System.Drawing.Point(68, 54);
            this.lbCourses.Name = "lbCourses";
            this.lbCourses.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbCourses.Size = new System.Drawing.Size(181, 276);
            this.lbCourses.TabIndex = 0;
            this.lbCourses.SelectedIndexChanged += new System.EventHandler(this.lbCourses_SelectedIndexChanged);
            // 
            // clbEnrolledCourses
            // 
            this.clbEnrolledCourses.FormattingEnabled = true;
            this.clbEnrolledCourses.Location = new System.Drawing.Point(540, 54);
            this.clbEnrolledCourses.Name = "clbEnrolledCourses";
            this.clbEnrolledCourses.Size = new System.Drawing.Size(181, 276);
            this.clbEnrolledCourses.TabIndex = 1;
            // 
            // btnMoveRight
            // 
            this.btnMoveRight.Location = new System.Drawing.Point(366, 113);
            this.btnMoveRight.Name = "btnMoveRight";
            this.btnMoveRight.Size = new System.Drawing.Size(47, 43);
            this.btnMoveRight.TabIndex = 2;
            this.btnMoveRight.Text = ">>";
            this.btnMoveRight.UseVisualStyleBackColor = true;
            this.btnMoveRight.Click += new System.EventHandler(this.btnMoveRight_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(67, 391);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 28);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Додади";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbNewCourse
            // 
            this.tbNewCourse.Location = new System.Drawing.Point(67, 353);
            this.tbNewCourse.Name = "tbNewCourse";
            this.tbNewCourse.Size = new System.Drawing.Size(181, 22);
            this.tbNewCourse.TabIndex = 5;
            // 
            // btnMoveLeft
            // 
            this.btnMoveLeft.Location = new System.Drawing.Point(366, 227);
            this.btnMoveLeft.Name = "btnMoveLeft";
            this.btnMoveLeft.Size = new System.Drawing.Size(47, 43);
            this.btnMoveLeft.TabIndex = 6;
            this.btnMoveLeft.Text = "<<";
            this.btnMoveLeft.UseVisualStyleBackColor = true;
            this.btnMoveLeft.Click += new System.EventHandler(this.btnMoveLeft_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMoveLeft);
            this.Controls.Add(this.tbNewCourse);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnMoveRight);
            this.Controls.Add(this.clbEnrolledCourses);
            this.Controls.Add(this.lbCourses);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbCourses;
        private System.Windows.Forms.CheckedListBox clbEnrolledCourses;
        private System.Windows.Forms.Button btnMoveRight;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbNewCourse;
        private System.Windows.Forms.Button btnMoveLeft;
    }
}

