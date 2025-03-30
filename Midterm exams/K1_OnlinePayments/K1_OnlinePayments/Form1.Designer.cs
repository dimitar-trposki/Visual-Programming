namespace K1_OnlinePayments
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
            this.lbStudents = new System.Windows.Forms.ListBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnDeletePayments = new System.Windows.Forms.Button();
            this.nudPaymentCost = new System.Windows.Forms.NumericUpDown();
            this.btnAddPayment = new System.Windows.Forms.Button();
            this.lbPaymentsOfStudent = new System.Windows.Forms.Label();
            this.tbBiggestPayment = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaymentCost)).BeginInit();
            this.SuspendLayout();
            // 
            // lbStudents
            // 
            this.lbStudents.FormattingEnabled = true;
            this.lbStudents.ItemHeight = 16;
            this.lbStudents.Location = new System.Drawing.Point(54, 24);
            this.lbStudents.Name = "lbStudents";
            this.lbStudents.Size = new System.Drawing.Size(219, 324);
            this.lbStudents.TabIndex = 0;
            this.lbStudents.SelectedIndexChanged += new System.EventHandler(this.lbStudents_SelectedIndexChanged);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(54, 368);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(219, 32);
            this.btnAddStudent.TabIndex = 1;
            this.btnAddStudent.Text = "Додади студент";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnDeletePayments
            // 
            this.btnDeletePayments.Location = new System.Drawing.Point(54, 417);
            this.btnDeletePayments.Name = "btnDeletePayments";
            this.btnDeletePayments.Size = new System.Drawing.Size(219, 32);
            this.btnDeletePayments.TabIndex = 2;
            this.btnDeletePayments.Text = "Избриши уплати";
            this.btnDeletePayments.UseVisualStyleBackColor = true;
            this.btnDeletePayments.Click += new System.EventHandler(this.btnDeletePayments_Click);
            // 
            // nudPaymentCost
            // 
            this.nudPaymentCost.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudPaymentCost.Location = new System.Drawing.Point(303, 24);
            this.nudPaymentCost.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.nudPaymentCost.Name = "nudPaymentCost";
            this.nudPaymentCost.Size = new System.Drawing.Size(221, 22);
            this.nudPaymentCost.TabIndex = 3;
            // 
            // btnAddPayment
            // 
            this.btnAddPayment.Location = new System.Drawing.Point(303, 62);
            this.btnAddPayment.Name = "btnAddPayment";
            this.btnAddPayment.Size = new System.Drawing.Size(221, 32);
            this.btnAddPayment.TabIndex = 4;
            this.btnAddPayment.Text = "Додади уплата";
            this.btnAddPayment.UseVisualStyleBackColor = true;
            this.btnAddPayment.Click += new System.EventHandler(this.btnAddPayment_Click);
            // 
            // lbPaymentsOfStudent
            // 
            this.lbPaymentsOfStudent.AutoSize = true;
            this.lbPaymentsOfStudent.Location = new System.Drawing.Point(300, 113);
            this.lbPaymentsOfStudent.Name = "lbPaymentsOfStudent";
            this.lbPaymentsOfStudent.Size = new System.Drawing.Size(0, 16);
            this.lbPaymentsOfStudent.TabIndex = 5;
            // 
            // tbBiggestPayment
            // 
            this.tbBiggestPayment.Location = new System.Drawing.Point(303, 326);
            this.tbBiggestPayment.Name = "tbBiggestPayment";
            this.tbBiggestPayment.ReadOnly = true;
            this.tbBiggestPayment.Size = new System.Drawing.Size(221, 22);
            this.tbBiggestPayment.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 501);
            this.Controls.Add(this.tbBiggestPayment);
            this.Controls.Add(this.lbPaymentsOfStudent);
            this.Controls.Add(this.btnAddPayment);
            this.Controls.Add(this.nudPaymentCost);
            this.Controls.Add(this.btnDeletePayments);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.lbStudents);
            this.Name = "Form1";
            this.Text = "Онлајн плаќање";
            ((System.ComponentModel.ISupportInitialize)(this.nudPaymentCost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbStudents;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnDeletePayments;
        private System.Windows.Forms.NumericUpDown nudPaymentCost;
        private System.Windows.Forms.Button btnAddPayment;
        private System.Windows.Forms.Label lbPaymentsOfStudent;
        private System.Windows.Forms.TextBox tbBiggestPayment;
    }
}

