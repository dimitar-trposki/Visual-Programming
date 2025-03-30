namespace K2_AirportsWindowsFormsApp
{
    partial class AddNewAirport
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCityAirport = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNameAirport = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbShortName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProviderNewAirport = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNewAirport)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.tbShortName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbNameAirport);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbCityAirport);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 244);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Додади аеродром";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Град";
            // 
            // tbCityAirport
            // 
            this.tbCityAirport.Location = new System.Drawing.Point(18, 48);
            this.tbCityAirport.Name = "tbCityAirport";
            this.tbCityAirport.Size = new System.Drawing.Size(239, 22);
            this.tbCityAirport.TabIndex = 1;
            this.tbCityAirport.Validating += new System.ComponentModel.CancelEventHandler(this.tbCityAirport_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Име:";
            // 
            // tbNameAirport
            // 
            this.tbNameAirport.Location = new System.Drawing.Point(18, 103);
            this.tbNameAirport.Name = "tbNameAirport";
            this.tbNameAirport.Size = new System.Drawing.Size(239, 22);
            this.tbNameAirport.TabIndex = 3;
            this.tbNameAirport.Validating += new System.ComponentModel.CancelEventHandler(this.tbNameAirport_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Кратенка:";
            // 
            // tbShortName
            // 
            this.tbShortName.Location = new System.Drawing.Point(18, 158);
            this.tbShortName.Name = "tbShortName";
            this.tbShortName.Size = new System.Drawing.Size(111, 22);
            this.tbShortName.TabIndex = 5;
            this.tbShortName.Validating += new System.ComponentModel.CancelEventHandler(this.tbShortName_Validating);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(18, 197);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 30);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Зачувај";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.CausesValidation = false;
            this.btnCancel.Location = new System.Drawing.Point(146, 197);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 30);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Откажи";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorProviderNewAirport
            // 
            this.errorProviderNewAirport.ContainerControl = this;
            // 
            // AddNewAirport
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(347, 268);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddNewAirport";
            this.Text = "Нов аеродром";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNewAirport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbShortName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNameAirport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCityAirport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProviderNewAirport;
    }
}