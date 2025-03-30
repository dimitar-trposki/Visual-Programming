using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I3_Library
{
    public partial class Form1 : Form
    {
        public List<Book> Books { get; set; }
        public Form1()
        {
            InitializeComponent();
            Books = new List<Book>();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                Book book = new Book(tbId.Text, tbTitle.Text, tbAuthor.Text, (int)nudNumCopies.Value);
                Books.Add(book);
                showBooks();
                clearTextBoxs();
                showNumberOfBooks();
            }
        }

        private void showBooks()
        {
            lbBooks.Items.Clear();
            if (Books.Count > 0)
            {
                foreach (Book book in Books)
                {
                    lbBooks.Items.Add(book);
                }
            }
        }

        private void clearTextBoxs()
        {
            tbId.Text = string.Empty;
            tbTitle.Text = string.Empty;
            tbAuthor.Text = string.Empty;
            nudNumCopies.Value = 0;
        }

        private void tbTitle_Validating(object sender, CancelEventArgs e)
        {
            if (tbTitle.Text.Length == 0)
            {
                errorProvider1.SetError(tbTitle, "Полето за наслов не смее да биде празно!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbTitle, null);
                e.Cancel = false;
            }
        }

        private void tbId_Validating(object sender, CancelEventArgs e)
        {
            bool isPresent = false;
            for (int i = 0; i < Books.Count; i++)
            {
                if (Books[i].ID == tbId.Text)
                {
                    isPresent = true;
                    break;
                }
            }
            if (isPresent)
            {
                errorProvider1.SetError(tbId, "Внесеното ИД постои во листата!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbId, null);
                e.Cancel = false;
            }
        }

        private void btnTakeBook_Click(object sender, EventArgs e)
        {
            if (lbBooks.SelectedIndex != -1)
            {
                Book book = lbBooks.SelectedItem as Book;
                book.decrementCopies();
                showBooks();
                showNumberOfBooks();
            }
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (lbBooks.SelectedIndex != -1)
            {
                Books.Remove(lbBooks.SelectedItem as Book);
                showBooks();
                showNumberOfBooks();
            }
        }

        private void showNumberOfBooks()
        {
            int countBooks = 0;
            if (Books.Count > 0)
            {
                foreach (Book b in Books)
                {
                    countBooks += b.NumOfAvailableCopies;
                }
            }
            tbNumOfBooks.Text = countBooks.ToString();
        }
    }
}
