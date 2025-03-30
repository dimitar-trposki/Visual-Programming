namespace K2_AirportsWindowsFormsApp
{
    partial class FormAirports
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
            this.lbAirports = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbDestinations = new System.Windows.Forms.ListBox();
            this.btnAddAirport = new System.Windows.Forms.Button();
            this.btnRemoveAirport = new System.Windows.Forms.Button();
            this.btnAddDestination = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbAverageDIstance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMostExpensiveDestination = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Аеродроми";
            // 
            // lbAirports
            // 
            this.lbAirports.FormattingEnabled = true;
            this.lbAirports.ItemHeight = 16;
            this.lbAirports.Location = new System.Drawing.Point(26, 39);
            this.lbAirports.Name = "lbAirports";
            this.lbAirports.Size = new System.Drawing.Size(334, 260);
            this.lbAirports.TabIndex = 1;
            this.lbAirports.SelectedIndexChanged += new System.EventHandler(this.lbAirports_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дестинации";
            // 
            // lbDestinations
            // 
            this.lbDestinations.FormattingEnabled = true;
            this.lbDestinations.ItemHeight = 16;
            this.lbDestinations.Location = new System.Drawing.Point(370, 39);
            this.lbDestinations.Name = "lbDestinations";
            this.lbDestinations.Size = new System.Drawing.Size(393, 260);
            this.lbDestinations.TabIndex = 3;
            // 
            // btnAddAirport
            // 
            this.btnAddAirport.Location = new System.Drawing.Point(26, 317);
            this.btnAddAirport.Name = "btnAddAirport";
            this.btnAddAirport.Size = new System.Drawing.Size(334, 27);
            this.btnAddAirport.TabIndex = 4;
            this.btnAddAirport.Text = "Додади аеродром";
            this.btnAddAirport.UseVisualStyleBackColor = true;
            this.btnAddAirport.Click += new System.EventHandler(this.btnAddAirport_Click);
            // 
            // btnRemoveAirport
            // 
            this.btnRemoveAirport.Location = new System.Drawing.Point(26, 359);
            this.btnRemoveAirport.Name = "btnRemoveAirport";
            this.btnRemoveAirport.Size = new System.Drawing.Size(334, 27);
            this.btnRemoveAirport.TabIndex = 5;
            this.btnRemoveAirport.Text = "Избриши аеродром";
            this.btnRemoveAirport.UseVisualStyleBackColor = true;
            this.btnRemoveAirport.Click += new System.EventHandler(this.btnRemoveAirport_Click);
            // 
            // btnAddDestination
            // 
            this.btnAddDestination.Location = new System.Drawing.Point(26, 401);
            this.btnAddDestination.Name = "btnAddDestination";
            this.btnAddDestination.Size = new System.Drawing.Size(334, 27);
            this.btnAddDestination.TabIndex = 6;
            this.btnAddDestination.Text = "Додади дестинација";
            this.btnAddDestination.UseVisualStyleBackColor = true;
            this.btnAddDestination.Click += new System.EventHandler(this.btnAddDestination_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbAverageDIstance);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbMostExpensiveDestination);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(370, 305);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 133);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Дестинации";
            // 
            // tbAverageDIstance
            // 
            this.tbAverageDIstance.Location = new System.Drawing.Point(9, 95);
            this.tbAverageDIstance.Name = "tbAverageDIstance";
            this.tbAverageDIstance.ReadOnly = true;
            this.tbAverageDIstance.Size = new System.Drawing.Size(378, 22);
            this.tbAverageDIstance.TabIndex = 11;
            this.tbAverageDIstance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Просечна должина на дестинациите";
            // 
            // tbMostExpensiveDestination
            // 
            this.tbMostExpensiveDestination.Location = new System.Drawing.Point(9, 42);
            this.tbMostExpensiveDestination.Name = "tbMostExpensiveDestination";
            this.tbMostExpensiveDestination.ReadOnly = true;
            this.tbMostExpensiveDestination.Size = new System.Drawing.Size(378, 22);
            this.tbMostExpensiveDestination.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Најскапа дестинација";
            // 
            // FormAirports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddDestination);
            this.Controls.Add(this.btnRemoveAirport);
            this.Controls.Add(this.btnAddAirport);
            this.Controls.Add(this.lbDestinations);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbAirports);
            this.Controls.Add(this.label1);
            this.Name = "FormAirports";
            this.Text = "Аеродроми";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbAirports;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbDestinations;
        private System.Windows.Forms.Button btnAddAirport;
        private System.Windows.Forms.Button btnRemoveAirport;
        private System.Windows.Forms.Button btnAddDestination;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMostExpensiveDestination;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAverageDIstance;
    }
}

