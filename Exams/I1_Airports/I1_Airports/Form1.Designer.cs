namespace I1_Airports
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbAirports = new System.Windows.Forms.ListBox();
            this.lbDestinations = new System.Windows.Forms.ListBox();
            this.btnDeleteAirport = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbAverageDistance = new System.Windows.Forms.TextBox();
            this.tbMostExpensiveDestination = new System.Windows.Forms.TextBox();
            this.btnAddAirport = new System.Windows.Forms.Button();
            this.btnAddDestination = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Аеродроми";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(407, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дестинации";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Најскапа дестинација";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Просечна должина на дестинациите";
            // 
            // lbAirports
            // 
            this.lbAirports.FormattingEnabled = true;
            this.lbAirports.ItemHeight = 16;
            this.lbAirports.Location = new System.Drawing.Point(12, 39);
            this.lbAirports.Name = "lbAirports";
            this.lbAirports.Size = new System.Drawing.Size(380, 276);
            this.lbAirports.TabIndex = 4;
            this.lbAirports.SelectedIndexChanged += new System.EventHandler(this.lbAirports_SelectedIndexChanged);
            // 
            // lbDestinations
            // 
            this.lbDestinations.FormattingEnabled = true;
            this.lbDestinations.ItemHeight = 16;
            this.lbDestinations.Location = new System.Drawing.Point(410, 39);
            this.lbDestinations.Name = "lbDestinations";
            this.lbDestinations.Size = new System.Drawing.Size(378, 276);
            this.lbDestinations.TabIndex = 5;
            // 
            // btnDeleteAirport
            // 
            this.btnDeleteAirport.Location = new System.Drawing.Point(12, 358);
            this.btnDeleteAirport.Name = "btnDeleteAirport";
            this.btnDeleteAirport.Size = new System.Drawing.Size(380, 32);
            this.btnDeleteAirport.TabIndex = 7;
            this.btnDeleteAirport.Text = "Избриши аеродром";
            this.btnDeleteAirport.UseVisualStyleBackColor = true;
            this.btnDeleteAirport.Click += new System.EventHandler(this.btnDeleteAirport_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbAverageDistance);
            this.groupBox1.Controls.Add(this.tbMostExpensiveDestination);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(410, 321);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 117);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Дестинации";
            // 
            // tbAverageDistance
            // 
            this.tbAverageDistance.Location = new System.Drawing.Point(9, 86);
            this.tbAverageDistance.Name = "tbAverageDistance";
            this.tbAverageDistance.ReadOnly = true;
            this.tbAverageDistance.Size = new System.Drawing.Size(363, 22);
            this.tbAverageDistance.TabIndex = 4;
            this.tbAverageDistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbMostExpensiveDestination
            // 
            this.tbMostExpensiveDestination.Location = new System.Drawing.Point(9, 37);
            this.tbMostExpensiveDestination.Name = "tbMostExpensiveDestination";
            this.tbMostExpensiveDestination.ReadOnly = true;
            this.tbMostExpensiveDestination.Size = new System.Drawing.Size(363, 22);
            this.tbMostExpensiveDestination.TabIndex = 3;
            // 
            // btnAddAirport
            // 
            this.btnAddAirport.Location = new System.Drawing.Point(12, 320);
            this.btnAddAirport.Name = "btnAddAirport";
            this.btnAddAirport.Size = new System.Drawing.Size(380, 32);
            this.btnAddAirport.TabIndex = 8;
            this.btnAddAirport.Text = "Додади аеродром";
            this.btnAddAirport.UseVisualStyleBackColor = true;
            this.btnAddAirport.Click += new System.EventHandler(this.btnAddAirport_Click);
            // 
            // btnAddDestination
            // 
            this.btnAddDestination.Location = new System.Drawing.Point(12, 396);
            this.btnAddDestination.Name = "btnAddDestination";
            this.btnAddDestination.Size = new System.Drawing.Size(380, 32);
            this.btnAddDestination.TabIndex = 10;
            this.btnAddDestination.Text = "Додади дестинација";
            this.btnAddDestination.UseVisualStyleBackColor = true;
            this.btnAddDestination.Click += new System.EventHandler(this.btnAddDestination_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddDestination);
            this.Controls.Add(this.btnAddAirport);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDeleteAirport);
            this.Controls.Add(this.lbDestinations);
            this.Controls.Add(this.lbAirports);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Аеродроми";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbAirports;
        private System.Windows.Forms.ListBox lbDestinations;
        private System.Windows.Forms.Button btnDeleteAirport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbAverageDistance;
        private System.Windows.Forms.TextBox tbMostExpensiveDestination;
        private System.Windows.Forms.Button btnAddAirport;
        private System.Windows.Forms.Button btnAddDestination;
    }
}

