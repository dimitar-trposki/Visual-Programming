namespace K3_ConferenceWindowsFormsApp
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
            this.lbAllPapers = new System.Windows.Forms.ListBox();
            this.lbAuthorsAndPapers = new System.Windows.Forms.ListBox();
            this.btnAddNewPaper = new System.Windows.Forms.Button();
            this.btnDeletePaper = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbAllPapers
            // 
            this.lbAllPapers.FormattingEnabled = true;
            this.lbAllPapers.ItemHeight = 16;
            this.lbAllPapers.Location = new System.Drawing.Point(33, 34);
            this.lbAllPapers.Name = "lbAllPapers";
            this.lbAllPapers.Size = new System.Drawing.Size(298, 308);
            this.lbAllPapers.TabIndex = 0;
            // 
            // lbAuthorsAndPapers
            // 
            this.lbAuthorsAndPapers.FormattingEnabled = true;
            this.lbAuthorsAndPapers.ItemHeight = 16;
            this.lbAuthorsAndPapers.Location = new System.Drawing.Point(467, 34);
            this.lbAuthorsAndPapers.Name = "lbAuthorsAndPapers";
            this.lbAuthorsAndPapers.Size = new System.Drawing.Size(298, 308);
            this.lbAuthorsAndPapers.TabIndex = 1;
            // 
            // btnAddNewPaper
            // 
            this.btnAddNewPaper.Location = new System.Drawing.Point(33, 359);
            this.btnAddNewPaper.Name = "btnAddNewPaper";
            this.btnAddNewPaper.Size = new System.Drawing.Size(298, 30);
            this.btnAddNewPaper.TabIndex = 2;
            this.btnAddNewPaper.Text = "Add new paper";
            this.btnAddNewPaper.UseVisualStyleBackColor = true;
            this.btnAddNewPaper.Click += new System.EventHandler(this.btnAddNewPaper_Click);
            // 
            // btnDeletePaper
            // 
            this.btnDeletePaper.Location = new System.Drawing.Point(33, 395);
            this.btnDeletePaper.Name = "btnDeletePaper";
            this.btnDeletePaper.Size = new System.Drawing.Size(298, 30);
            this.btnDeletePaper.TabIndex = 3;
            this.btnDeletePaper.Text = "Delete paper";
            this.btnDeletePaper.UseVisualStyleBackColor = true;
            this.btnDeletePaper.Click += new System.EventHandler(this.btnDeletePaper_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "All papers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(464, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Authors and papers";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeletePaper);
            this.Controls.Add(this.btnAddNewPaper);
            this.Controls.Add(this.lbAuthorsAndPapers);
            this.Controls.Add(this.lbAllPapers);
            this.Name = "Form1";
            this.Text = "Conference";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbAllPapers;
        private System.Windows.Forms.ListBox lbAuthorsAndPapers;
        private System.Windows.Forms.Button btnAddNewPaper;
        private System.Windows.Forms.Button btnDeletePaper;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

