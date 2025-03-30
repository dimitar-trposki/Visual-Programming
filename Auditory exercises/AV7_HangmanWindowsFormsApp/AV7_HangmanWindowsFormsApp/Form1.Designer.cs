namespace AV7_HangmanWindowsFormsApp
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblWordToGuess = new System.Windows.Forms.Label();
            this.tbLetter = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbGuessedLetters = new System.Windows.Forms.TextBox();
            this.btnConfirmLetter = new System.Windows.Forms.Button();
            this.pbFailedAttempts = new System.Windows.Forms.ProgressBar();
            this.pbTimeLeft = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Игра";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(696, 18);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(81, 29);
            this.lblTimer.TabIndex = 1;
            this.lblTimer.Text = "label2";
            // 
            // lblWordToGuess
            // 
            this.lblWordToGuess.AutoSize = true;
            this.lblWordToGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordToGuess.Location = new System.Drawing.Point(18, 72);
            this.lblWordToGuess.Name = "lblWordToGuess";
            this.lblWordToGuess.Size = new System.Drawing.Size(132, 48);
            this.lblWordToGuess.TabIndex = 2;
            this.lblWordToGuess.Text = "label3";
            // 
            // tbLetter
            // 
            this.tbLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLetter.Location = new System.Drawing.Point(19, 134);
            this.tbLetter.Name = "tbLetter";
            this.tbLetter.Size = new System.Drawing.Size(83, 55);
            this.tbLetter.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbGuessedLetters);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(759, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Употребени букви";
            // 
            // tbGuessedLetters
            // 
            this.tbGuessedLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGuessedLetters.Location = new System.Drawing.Point(7, 32);
            this.tbGuessedLetters.Name = "tbGuessedLetters";
            this.tbGuessedLetters.ReadOnly = true;
            this.tbGuessedLetters.Size = new System.Drawing.Size(746, 43);
            this.tbGuessedLetters.TabIndex = 0;
            // 
            // btnConfirmLetter
            // 
            this.btnConfirmLetter.Location = new System.Drawing.Point(122, 134);
            this.btnConfirmLetter.Name = "btnConfirmLetter";
            this.btnConfirmLetter.Size = new System.Drawing.Size(83, 55);
            this.btnConfirmLetter.TabIndex = 5;
            this.btnConfirmLetter.Text = "OK";
            this.btnConfirmLetter.UseVisualStyleBackColor = true;
            this.btnConfirmLetter.Click += new System.EventHandler(this.btnConfirmLetter_Click);
            // 
            // pbFailedAttempts
            // 
            this.pbFailedAttempts.Location = new System.Drawing.Point(15, 331);
            this.pbFailedAttempts.Name = "pbFailedAttempts";
            this.pbFailedAttempts.Size = new System.Drawing.Size(762, 27);
            this.pbFailedAttempts.TabIndex = 6;
            // 
            // pbTimeLeft
            // 
            this.pbTimeLeft.Location = new System.Drawing.Point(15, 373);
            this.pbTimeLeft.Name = "pbTimeLeft";
            this.pbTimeLeft.Size = new System.Drawing.Size(762, 27);
            this.pbTimeLeft.TabIndex = 7;
            this.pbTimeLeft.Click += new System.EventHandler(this.pbTimeLeft_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnConfirmLetter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 422);
            this.Controls.Add(this.pbTimeLeft);
            this.Controls.Add(this.btnConfirmLetter);
            this.Controls.Add(this.pbFailedAttempts);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbLetter);
            this.Controls.Add(this.lblWordToGuess);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Бесилка";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblWordToGuess;
        private System.Windows.Forms.TextBox tbLetter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbGuessedLetters;
        private System.Windows.Forms.Button btnConfirmLetter;
        private System.Windows.Forms.ProgressBar pbFailedAttempts;
        private System.Windows.Forms.ProgressBar pbTimeLeft;
        private System.Windows.Forms.Timer timer1;
    }
}

