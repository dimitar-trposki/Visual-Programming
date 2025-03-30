namespace K3_ConferenceWindowsFormsApp
{
    partial class AddPaper
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
            this.components = new System.ComponentModel.Container();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbKeywords = new System.Windows.Forms.TextBox();
            this.tbAuthor1 = new System.Windows.Forms.TextBox();
            this.tbAuthor2 = new System.Windows.Forms.TextBox();
            this.tbAuthor3 = new System.Windows.Forms.TextBox();
            this.tbAuthor4 = new System.Windows.Forms.TextBox();
            this.tbAuthor5 = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProviderAddPaper = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddPaper)).BeginInit();
            this.SuspendLayout();
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(29, 45);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(299, 22);
            this.tbTitle.TabIndex = 0;
            this.tbTitle.Validating += new System.ComponentModel.CancelEventHandler(this.tbTitle_Validating);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(26, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(33, 16);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Keywords";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Author 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Author 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Author 3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Author 4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Author 5";
            // 
            // tbKeywords
            // 
            this.tbKeywords.Location = new System.Drawing.Point(29, 106);
            this.tbKeywords.Name = "tbKeywords";
            this.tbKeywords.Size = new System.Drawing.Size(299, 22);
            this.tbKeywords.TabIndex = 8;
            this.tbKeywords.Validating += new System.ComponentModel.CancelEventHandler(this.tbKeywords_Validating);
            // 
            // tbAuthor1
            // 
            this.tbAuthor1.Location = new System.Drawing.Point(29, 164);
            this.tbAuthor1.Name = "tbAuthor1";
            this.tbAuthor1.Size = new System.Drawing.Size(299, 22);
            this.tbAuthor1.TabIndex = 9;
            this.tbAuthor1.Validating += new System.ComponentModel.CancelEventHandler(this.tbAuthor1_Validating);
            // 
            // tbAuthor2
            // 
            this.tbAuthor2.Location = new System.Drawing.Point(29, 217);
            this.tbAuthor2.Name = "tbAuthor2";
            this.tbAuthor2.Size = new System.Drawing.Size(299, 22);
            this.tbAuthor2.TabIndex = 10;
            // 
            // tbAuthor3
            // 
            this.tbAuthor3.Location = new System.Drawing.Point(29, 272);
            this.tbAuthor3.Name = "tbAuthor3";
            this.tbAuthor3.Size = new System.Drawing.Size(299, 22);
            this.tbAuthor3.TabIndex = 11;
            // 
            // tbAuthor4
            // 
            this.tbAuthor4.Location = new System.Drawing.Point(29, 325);
            this.tbAuthor4.Name = "tbAuthor4";
            this.tbAuthor4.Size = new System.Drawing.Size(299, 22);
            this.tbAuthor4.TabIndex = 12;
            // 
            // tbAuthor5
            // 
            this.tbAuthor5.Location = new System.Drawing.Point(29, 378);
            this.tbAuthor5.Name = "tbAuthor5";
            this.tbAuthor5.Size = new System.Drawing.Size(299, 22);
            this.tbAuthor5.TabIndex = 13;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(29, 432);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(95, 30);
            this.btnOK.TabIndex = 16;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.CausesValidation = false;
            this.btnCancel.Location = new System.Drawing.Point(233, 432);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 30);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorProviderAddPaper
            // 
            this.errorProviderAddPaper.ContainerControl = this;
            // 
            // AddPaper
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(368, 486);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbAuthor5);
            this.Controls.Add(this.tbAuthor4);
            this.Controls.Add(this.tbAuthor3);
            this.Controls.Add(this.tbAuthor2);
            this.Controls.Add(this.tbAuthor1);
            this.Controls.Add(this.tbKeywords);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tbTitle);
            this.Name = "AddPaper";
            this.Text = "AddPaper";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddPaper)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbKeywords;
        private System.Windows.Forms.TextBox tbAuthor1;
        private System.Windows.Forms.TextBox tbAuthor2;
        private System.Windows.Forms.TextBox tbAuthor3;
        private System.Windows.Forms.TextBox tbAuthor4;
        private System.Windows.Forms.TextBox tbAuthor5;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProviderAddPaper;
    }
}