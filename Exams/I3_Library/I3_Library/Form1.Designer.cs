namespace I3_Library
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
            this.tbId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.nudNumCopies = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnTakeBook = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.lbBooks = new System.Windows.Forms.ListBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbNumOfBooks = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumCopies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ИД";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(41, 54);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(244, 22);
            this.tbId.TabIndex = 1;
            this.tbId.Validating += new System.ComponentModel.CancelEventHandler(this.tbId_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Наслов";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Автор";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Бр. на копии";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(41, 120);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(244, 22);
            this.tbTitle.TabIndex = 5;
            this.tbTitle.Validating += new System.ComponentModel.CancelEventHandler(this.tbTitle_Validating);
            // 
            // tbAuthor
            // 
            this.tbAuthor.Location = new System.Drawing.Point(41, 186);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.Size = new System.Drawing.Size(244, 22);
            this.tbAuthor.TabIndex = 7;
            // 
            // nudNumCopies
            // 
            this.nudNumCopies.Location = new System.Drawing.Point(41, 250);
            this.nudNumCopies.Name = "nudNumCopies";
            this.nudNumCopies.Size = new System.Drawing.Size(120, 22);
            this.nudNumCopies.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(41, 311);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 32);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Додади";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnTakeBook
            // 
            this.btnTakeBook.Location = new System.Drawing.Point(341, 52);
            this.btnTakeBook.Name = "btnTakeBook";
            this.btnTakeBook.Size = new System.Drawing.Size(149, 23);
            this.btnTakeBook.TabIndex = 10;
            this.btnTakeBook.Text = "Изнајми копија";
            this.btnTakeBook.UseVisualStyleBackColor = true;
            this.btnTakeBook.Click += new System.EventHandler(this.btnTakeBook_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Location = new System.Drawing.Point(536, 410);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(268, 28);
            this.btnDeleteBook.TabIndex = 11;
            this.btnDeleteBook.Text = "Избриши книга";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // lbBooks
            // 
            this.lbBooks.FormattingEnabled = true;
            this.lbBooks.ItemHeight = 16;
            this.lbBooks.Location = new System.Drawing.Point(536, 52);
            this.lbBooks.Name = "lbBooks";
            this.lbBooks.Size = new System.Drawing.Size(268, 340);
            this.lbBooks.TabIndex = 12;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tbNumOfBooks
            // 
            this.tbNumOfBooks.Location = new System.Drawing.Point(536, 457);
            this.tbNumOfBooks.Name = "tbNumOfBooks";
            this.tbNumOfBooks.ReadOnly = true;
            this.tbNumOfBooks.Size = new System.Drawing.Size(268, 22);
            this.tbNumOfBooks.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 506);
            this.Controls.Add(this.tbNumOfBooks);
            this.Controls.Add(this.lbBooks);
            this.Controls.Add(this.btnDeleteBook);
            this.Controls.Add(this.btnTakeBook);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.nudNumCopies);
            this.Controls.Add(this.tbAuthor);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumCopies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbAuthor;
        private System.Windows.Forms.NumericUpDown nudNumCopies;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnTakeBook;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.ListBox lbBooks;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox tbNumOfBooks;
    }
}

