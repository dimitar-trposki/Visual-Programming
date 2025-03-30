namespace I2_Busses
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
            this.lbBusses = new System.Windows.Forms.ListBox();
            this.lbLines = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddBus = new System.Windows.Forms.Button();
            this.btnRemoveBus = new System.Windows.Forms.Button();
            this.btnAddLine = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMostExpensiveLine = new System.Windows.Forms.TextBox();
            this.tbAveragePrice = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbBusses
            // 
            this.lbBusses.FormattingEnabled = true;
            this.lbBusses.ItemHeight = 16;
            this.lbBusses.Location = new System.Drawing.Point(21, 30);
            this.lbBusses.Name = "lbBusses";
            this.lbBusses.Size = new System.Drawing.Size(356, 276);
            this.lbBusses.TabIndex = 0;
            this.lbBusses.SelectedIndexChanged += new System.EventHandler(this.lbBusses_SelectedIndexChanged);
            // 
            // lbLines
            // 
            this.lbLines.FormattingEnabled = true;
            this.lbLines.ItemHeight = 16;
            this.lbLines.Location = new System.Drawing.Point(413, 30);
            this.lbLines.Name = "lbLines";
            this.lbLines.Size = new System.Drawing.Size(356, 276);
            this.lbLines.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(410, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Линии";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Автобуси";
            // 
            // btnAddBus
            // 
            this.btnAddBus.Location = new System.Drawing.Point(21, 323);
            this.btnAddBus.Name = "btnAddBus";
            this.btnAddBus.Size = new System.Drawing.Size(356, 26);
            this.btnAddBus.TabIndex = 4;
            this.btnAddBus.Text = "Додади автобус";
            this.btnAddBus.UseVisualStyleBackColor = true;
            this.btnAddBus.Click += new System.EventHandler(this.btnAddBus_Click);
            // 
            // btnRemoveBus
            // 
            this.btnRemoveBus.Location = new System.Drawing.Point(21, 362);
            this.btnRemoveBus.Name = "btnRemoveBus";
            this.btnRemoveBus.Size = new System.Drawing.Size(356, 26);
            this.btnRemoveBus.TabIndex = 5;
            this.btnRemoveBus.Text = "Избриши автобус";
            this.btnRemoveBus.UseVisualStyleBackColor = true;
            this.btnRemoveBus.Click += new System.EventHandler(this.btnRemoveBus_Click);
            // 
            // btnAddLine
            // 
            this.btnAddLine.Location = new System.Drawing.Point(21, 402);
            this.btnAddLine.Name = "btnAddLine";
            this.btnAddLine.Size = new System.Drawing.Size(356, 26);
            this.btnAddLine.TabIndex = 6;
            this.btnAddLine.Text = "Додади линија";
            this.btnAddLine.UseVisualStyleBackColor = true;
            this.btnAddLine.Click += new System.EventHandler(this.btnAddLine_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbAveragePrice);
            this.groupBox1.Controls.Add(this.tbMostExpensiveLine);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(413, 312);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 126);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Линии";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Најскапа линија";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Просечна цена на линиите";
            // 
            // tbMostExpensiveLine
            // 
            this.tbMostExpensiveLine.Location = new System.Drawing.Point(9, 50);
            this.tbMostExpensiveLine.Name = "tbMostExpensiveLine";
            this.tbMostExpensiveLine.Size = new System.Drawing.Size(341, 22);
            this.tbMostExpensiveLine.TabIndex = 10;
            // 
            // tbAveragePrice
            // 
            this.tbAveragePrice.Location = new System.Drawing.Point(9, 94);
            this.tbAveragePrice.Name = "tbAveragePrice";
            this.tbAveragePrice.Size = new System.Drawing.Size(341, 22);
            this.tbAveragePrice.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddLine);
            this.Controls.Add(this.btnRemoveBus);
            this.Controls.Add(this.btnAddBus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbLines);
            this.Controls.Add(this.lbBusses);
            this.Name = "Form1";
            this.Text = "Автобуси";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbBusses;
        private System.Windows.Forms.ListBox lbLines;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddBus;
        private System.Windows.Forms.Button btnRemoveBus;
        private System.Windows.Forms.Button btnAddLine;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbAveragePrice;
        private System.Windows.Forms.TextBox tbMostExpensiveLine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

