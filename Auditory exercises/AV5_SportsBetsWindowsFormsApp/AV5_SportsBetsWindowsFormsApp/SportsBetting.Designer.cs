namespace AV5_SportsBetsWindowsFormsApp
{
    partial class SportsBetting
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
            this.lbMatches = new System.Windows.Forms.ListBox();
            this.lbTeams = new System.Windows.Forms.ListBox();
            this.lbTickets = new System.Windows.Forms.ListBox();
            this.lblTeams = new System.Windows.Forms.Label();
            this.lblMatches = new System.Windows.Forms.Label();
            this.lblTickets = new System.Windows.Forms.Label();
            this.gbCreate = new System.Windows.Forms.GroupBox();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.btnAddMatch = new System.Windows.Forms.Button();
            this.mtbCode = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nud2 = new System.Windows.Forms.NumericUpDown();
            this.nudX = new System.Windows.Forms.NumericUpDown();
            this.nud1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblChooseTeams = new System.Windows.Forms.Label();
            this.gbAddMatch = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblChooseMatch = new System.Windows.Forms.Label();
            this.gbPay = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCoef = new System.Windows.Forms.Label();
            this.errorCode = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbCreate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).BeginInit();
            this.gbAddMatch.SuspendLayout();
            this.gbPay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCode)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMatches
            // 
            this.lbMatches.FormattingEnabled = true;
            this.lbMatches.ItemHeight = 16;
            this.lbMatches.Location = new System.Drawing.Point(270, 30);
            this.lbMatches.Name = "lbMatches";
            this.lbMatches.Size = new System.Drawing.Size(356, 228);
            this.lbMatches.TabIndex = 0;
            // 
            // lbTeams
            // 
            this.lbTeams.FormattingEnabled = true;
            this.lbTeams.ItemHeight = 16;
            this.lbTeams.Location = new System.Drawing.Point(12, 30);
            this.lbTeams.Name = "lbTeams";
            this.lbTeams.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbTeams.Size = new System.Drawing.Size(252, 228);
            this.lbTeams.TabIndex = 1;
            // 
            // lbTickets
            // 
            this.lbTickets.FormattingEnabled = true;
            this.lbTickets.ItemHeight = 16;
            this.lbTickets.Location = new System.Drawing.Point(632, 30);
            this.lbTickets.Name = "lbTickets";
            this.lbTickets.Size = new System.Drawing.Size(256, 228);
            this.lbTickets.TabIndex = 2;
            // 
            // lblTeams
            // 
            this.lblTeams.AutoSize = true;
            this.lblTeams.Location = new System.Drawing.Point(9, 11);
            this.lblTeams.Name = "lblTeams";
            this.lblTeams.Size = new System.Drawing.Size(119, 16);
            this.lblTeams.TabIndex = 3;
            this.lblTeams.Text = "Листа на тимови:";
            // 
            // lblMatches
            // 
            this.lblMatches.AutoSize = true;
            this.lblMatches.Location = new System.Drawing.Point(267, 11);
            this.lblMatches.Name = "lblMatches";
            this.lblMatches.Size = new System.Drawing.Size(55, 16);
            this.lblMatches.TabIndex = 4;
            this.lblMatches.Text = "Билтен";
            // 
            // lblTickets
            // 
            this.lblTickets.AutoSize = true;
            this.lblTickets.Location = new System.Drawing.Point(629, 11);
            this.lblTickets.Name = "lblTickets";
            this.lblTickets.Size = new System.Drawing.Size(54, 16);
            this.lblTickets.TabIndex = 5;
            this.lblTickets.Text = "Тикети";
            // 
            // gbCreate
            // 
            this.gbCreate.Controls.Add(this.btnAddTeam);
            this.gbCreate.Controls.Add(this.btnAddMatch);
            this.gbCreate.Controls.Add(this.mtbCode);
            this.gbCreate.Controls.Add(this.label5);
            this.gbCreate.Controls.Add(this.nud2);
            this.gbCreate.Controls.Add(this.nudX);
            this.gbCreate.Controls.Add(this.nud1);
            this.gbCreate.Controls.Add(this.label4);
            this.gbCreate.Controls.Add(this.label3);
            this.gbCreate.Controls.Add(this.label2);
            this.gbCreate.Controls.Add(this.label1);
            this.gbCreate.Controls.Add(this.lblChooseTeams);
            this.gbCreate.Location = new System.Drawing.Point(12, 264);
            this.gbCreate.Name = "gbCreate";
            this.gbCreate.Size = new System.Drawing.Size(252, 268);
            this.gbCreate.TabIndex = 6;
            this.gbCreate.TabStop = false;
            this.gbCreate.Text = "Креирај билтен";
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.Location = new System.Drawing.Point(23, 231);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(209, 31);
            this.btnAddTeam.TabIndex = 22;
            this.btnAddTeam.Text = "Додади нов тим";
            this.btnAddTeam.UseVisualStyleBackColor = true;
            this.btnAddTeam.Click += new System.EventHandler(this.btnAddTeam_Click);
            // 
            // btnAddMatch
            // 
            this.btnAddMatch.Location = new System.Drawing.Point(23, 190);
            this.btnAddMatch.Name = "btnAddMatch";
            this.btnAddMatch.Size = new System.Drawing.Size(209, 35);
            this.btnAddMatch.TabIndex = 21;
            this.btnAddMatch.Text = "Додади во билтен";
            this.btnAddMatch.UseVisualStyleBackColor = true;
            this.btnAddMatch.Click += new System.EventHandler(this.btnAddMatch_Click);
            // 
            // mtbCode
            // 
            this.mtbCode.Location = new System.Drawing.Point(73, 162);
            this.mtbCode.Mask = "0000";
            this.mtbCode.Name = "mtbCode";
            this.mtbCode.Size = new System.Drawing.Size(105, 22);
            this.mtbCode.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Шифра:";
            // 
            // nud2
            // 
            this.nud2.DecimalPlaces = 2;
            this.nud2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud2.Location = new System.Drawing.Point(41, 131);
            this.nud2.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            this.nud2.Name = "nud2";
            this.nud2.Size = new System.Drawing.Size(120, 22);
            this.nud2.TabIndex = 18;
            this.nud2.Value = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            // 
            // nudX
            // 
            this.nudX.DecimalPlaces = 2;
            this.nudX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudX.Location = new System.Drawing.Point(41, 103);
            this.nudX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            this.nudX.Name = "nudX";
            this.nudX.Size = new System.Drawing.Size(120, 22);
            this.nudX.TabIndex = 17;
            this.nudX.Value = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            // 
            // nud1
            // 
            this.nud1.DecimalPlaces = 2;
            this.nud1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud1.Location = new System.Drawing.Point(40, 75);
            this.nud1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            this.nud1.Name = "nud1";
            this.nud1.Size = new System.Drawing.Size(120, 22);
            this.nud1.TabIndex = 16;
            this.nud1.Value = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Постави коефициенти";
            // 
            // lblChooseTeams
            // 
            this.lblChooseTeams.AutoSize = true;
            this.lblChooseTeams.Location = new System.Drawing.Point(6, 29);
            this.lblChooseTeams.Name = "lblChooseTeams";
            this.lblChooseTeams.Size = new System.Drawing.Size(206, 16);
            this.lblChooseTeams.TabIndex = 9;
            this.lblChooseTeams.Text = "Избери 2 тима од иста држава";
            // 
            // gbAddMatch
            // 
            this.gbAddMatch.Controls.Add(this.button1);
            this.gbAddMatch.Controls.Add(this.comboBox1);
            this.gbAddMatch.Controls.Add(this.label7);
            this.gbAddMatch.Controls.Add(this.tbCode);
            this.gbAddMatch.Controls.Add(this.label6);
            this.gbAddMatch.Controls.Add(this.lblChooseMatch);
            this.gbAddMatch.Location = new System.Drawing.Point(270, 264);
            this.gbAddMatch.Name = "gbAddMatch";
            this.gbAddMatch.Size = new System.Drawing.Size(356, 268);
            this.gbAddMatch.TabIndex = 7;
            this.gbAddMatch.TabStop = false;
            this.gbAddMatch.Text = "Додади натпревар во тикет";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 31);
            this.button1.TabIndex = 23;
            this.button1.Text = "Додади натпревар";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "X",
            "2"});
            this.comboBox1.Location = new System.Drawing.Point(9, 156);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 24);
            this.comboBox1.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Избери тип:";
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(9, 84);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(155, 22);
            this.tbCode.TabIndex = 21;
            this.tbCode.TextChanged += new System.EventHandler(this.tbCode_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Шифра:";
            // 
            // lblChooseMatch
            // 
            this.lblChooseMatch.AutoSize = true;
            this.lblChooseMatch.Location = new System.Drawing.Point(6, 29);
            this.lblChooseMatch.Name = "lblChooseMatch";
            this.lblChooseMatch.Size = new System.Drawing.Size(331, 16);
            this.lblChooseMatch.TabIndex = 9;
            this.lblChooseMatch.Text = "Избери натпревар од билтенот или внеси шифра";
            // 
            // gbPay
            // 
            this.gbPay.Controls.Add(this.button2);
            this.gbPay.Controls.Add(this.numericUpDown1);
            this.gbPay.Controls.Add(this.label9);
            this.gbPay.Controls.Add(this.textBox2);
            this.gbPay.Controls.Add(this.label8);
            this.gbPay.Controls.Add(this.textBox1);
            this.gbPay.Controls.Add(this.lblCoef);
            this.gbPay.Location = new System.Drawing.Point(632, 264);
            this.gbPay.Name = "gbPay";
            this.gbPay.Size = new System.Drawing.Size(256, 268);
            this.gbPay.TabIndex = 7;
            this.gbPay.TabStop = false;
            this.gbPay.Text = "Уплати тикет";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(241, 31);
            this.button2.TabIndex = 24;
            this.button2.Text = "Печати";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(9, 115);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(241, 22);
            this.numericUpDown1.TabIndex = 17;
            this.numericUpDown1.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Уплата";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 190);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(241, 22);
            this.textBox2.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Добивка:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(241, 22);
            this.textBox1.TabIndex = 9;
            // 
            // lblCoef
            // 
            this.lblCoef.AutoSize = true;
            this.lblCoef.Location = new System.Drawing.Point(6, 29);
            this.lblCoef.Name = "lblCoef";
            this.lblCoef.Size = new System.Drawing.Size(142, 16);
            this.lblCoef.TabIndex = 8;
            this.lblCoef.Text = "Вкупно коефициент:";
            // 
            // errorCode
            // 
            this.errorCode.ContainerControl = this;
            this.errorCode.RightToLeftChanged += new System.EventHandler(this.btnAddMatch_Click);
            // 
            // SportsBetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 541);
            this.Controls.Add(this.gbPay);
            this.Controls.Add(this.gbAddMatch);
            this.Controls.Add(this.gbCreate);
            this.Controls.Add(this.lblTickets);
            this.Controls.Add(this.lblMatches);
            this.Controls.Add(this.lblTeams);
            this.Controls.Add(this.lbTickets);
            this.Controls.Add(this.lbTeams);
            this.Controls.Add(this.lbMatches);
            this.Name = "SportsBetting";
            this.Text = "Спортска обложувалница";
            this.gbCreate.ResumeLayout(false);
            this.gbCreate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).EndInit();
            this.gbAddMatch.ResumeLayout(false);
            this.gbAddMatch.PerformLayout();
            this.gbPay.ResumeLayout(false);
            this.gbPay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbMatches;
        private System.Windows.Forms.ListBox lbTeams;
        private System.Windows.Forms.ListBox lbTickets;
        private System.Windows.Forms.Label lblTeams;
        private System.Windows.Forms.Label lblMatches;
        private System.Windows.Forms.Label lblTickets;
        private System.Windows.Forms.GroupBox gbCreate;
        private System.Windows.Forms.GroupBox gbAddMatch;
        private System.Windows.Forms.GroupBox gbPay;
        private System.Windows.Forms.Label lblChooseTeams;
        private System.Windows.Forms.Label lblChooseMatch;
        private System.Windows.Forms.Label lblCoef;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nud2;
        private System.Windows.Forms.NumericUpDown nudX;
        private System.Windows.Forms.NumericUpDown nud1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.Button btnAddMatch;
        private System.Windows.Forms.MaskedTextBox mtbCode;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ErrorProvider errorCode;
    }
}

