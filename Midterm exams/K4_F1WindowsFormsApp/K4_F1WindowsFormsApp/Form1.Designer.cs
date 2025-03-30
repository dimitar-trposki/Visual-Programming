namespace K4_F1WindowsFormsApp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbDrivers = new System.Windows.Forms.ListBox();
            this.btnAddDriver = new System.Windows.Forms.Button();
            this.btnRemoveDriver = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbLaps = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudMinutes = new System.Windows.Forms.NumericUpDown();
            this.nudSeconds = new System.Windows.Forms.NumericUpDown();
            this.btnAddLap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFastestLap = new System.Windows.Forms.TextBox();
            this.nudTime = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTime)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemoveDriver);
            this.groupBox1.Controls.Add(this.btnAddDriver);
            this.groupBox1.Controls.Add(this.lbDrivers);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 496);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Возачи";
            // 
            // lbDrivers
            // 
            this.lbDrivers.FormattingEnabled = true;
            this.lbDrivers.ItemHeight = 16;
            this.lbDrivers.Location = new System.Drawing.Point(7, 22);
            this.lbDrivers.Name = "lbDrivers";
            this.lbDrivers.Size = new System.Drawing.Size(341, 356);
            this.lbDrivers.TabIndex = 0;
            this.lbDrivers.SelectedIndexChanged += new System.EventHandler(this.lbDrivers_SelectedIndexChanged);
            // 
            // btnAddDriver
            // 
            this.btnAddDriver.Location = new System.Drawing.Point(6, 404);
            this.btnAddDriver.Name = "btnAddDriver";
            this.btnAddDriver.Size = new System.Drawing.Size(341, 40);
            this.btnAddDriver.TabIndex = 1;
            this.btnAddDriver.Text = "Додади возач";
            this.btnAddDriver.UseVisualStyleBackColor = true;
            this.btnAddDriver.Click += new System.EventHandler(this.btnAddDriver_Click);
            // 
            // btnRemoveDriver
            // 
            this.btnRemoveDriver.Location = new System.Drawing.Point(7, 450);
            this.btnRemoveDriver.Name = "btnRemoveDriver";
            this.btnRemoveDriver.Size = new System.Drawing.Size(341, 40);
            this.btnRemoveDriver.TabIndex = 2;
            this.btnRemoveDriver.Text = "Избриши возач";
            this.btnRemoveDriver.UseVisualStyleBackColor = true;
            this.btnRemoveDriver.Click += new System.EventHandler(this.btnRemoveDriver_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.nudTime);
            this.groupBox2.Controls.Add(this.tbFastestLap);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnAddLap);
            this.groupBox2.Controls.Add(this.nudSeconds);
            this.groupBox2.Controls.Add(this.nudMinutes);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lbLaps);
            this.groupBox2.Location = new System.Drawing.Point(374, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 496);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Кругови";
            // 
            // lbLaps
            // 
            this.lbLaps.FormattingEnabled = true;
            this.lbLaps.ItemHeight = 16;
            this.lbLaps.Location = new System.Drawing.Point(6, 22);
            this.lbLaps.Name = "lbLaps";
            this.lbLaps.Size = new System.Drawing.Size(402, 292);
            this.lbLaps.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Минути";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Секунди";
            // 
            // nudMinutes
            // 
            this.nudMinutes.Location = new System.Drawing.Point(9, 341);
            this.nudMinutes.Name = "nudMinutes";
            this.nudMinutes.Size = new System.Drawing.Size(120, 22);
            this.nudMinutes.TabIndex = 3;
            // 
            // nudSeconds
            // 
            this.nudSeconds.Location = new System.Drawing.Point(135, 341);
            this.nudSeconds.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudSeconds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudSeconds.Name = "nudSeconds";
            this.nudSeconds.Size = new System.Drawing.Size(120, 22);
            this.nudSeconds.TabIndex = 4;
            this.nudSeconds.ValueChanged += new System.EventHandler(this.nudSeconds_ValueChanged);
            // 
            // btnAddLap
            // 
            this.btnAddLap.Location = new System.Drawing.Point(261, 332);
            this.btnAddLap.Name = "btnAddLap";
            this.btnAddLap.Size = new System.Drawing.Size(147, 38);
            this.btnAddLap.TabIndex = 5;
            this.btnAddLap.Text = "Додади круг";
            this.btnAddLap.UseVisualStyleBackColor = true;
            this.btnAddLap.Click += new System.EventHandler(this.btnAddLap_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Најдобар круг";
            // 
            // tbFastestLap
            // 
            this.tbFastestLap.Location = new System.Drawing.Point(9, 397);
            this.tbFastestLap.Name = "tbFastestLap";
            this.tbFastestLap.ReadOnly = true;
            this.tbFastestLap.Size = new System.Drawing.Size(399, 22);
            this.tbFastestLap.TabIndex = 7;
            // 
            // nudTime
            // 
            this.nudTime.Location = new System.Drawing.Point(9, 447);
            this.nudTime.Name = "nudTime";
            this.nudTime.Size = new System.Drawing.Size(120, 22);
            this.nudTime.TabIndex = 8;
            this.nudTime.ValueChanged += new System.EventHandler(this.nudTime_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Време";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Ф1 Трка";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRemoveDriver;
        private System.Windows.Forms.Button btnAddDriver;
        private System.Windows.Forms.ListBox lbDrivers;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudTime;
        private System.Windows.Forms.TextBox tbFastestLap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddLap;
        private System.Windows.Forms.NumericUpDown nudSeconds;
        private System.Windows.Forms.NumericUpDown nudMinutes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbLaps;
    }
}

