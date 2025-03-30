using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K1_OnlinePayments
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            AddStudentForm newStudent = new AddStudentForm();
            newStudent.ShowDialog();

            if (newStudent.DialogResult == DialogResult.OK)
            {
                lbStudents.Items.Add(newStudent.student);
            }
        }

        private void lbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbStudents.SelectedItems.Count > 0)
            {
                lbPaymentsOfStudent.Text = ((Student)lbStudents.SelectedItem).ToString1();
            }
        }

        private Student maxPayment()
        {
            Student max = (Student)lbStudents.Items[0];
            int maxTotal = ((Student)lbStudents.Items[0]).sumPayments() + ((Student)lbStudents.Items[0]).sumTax();
            foreach (Student student in lbStudents.Items)
            {
                int total = student.sumPayments() + student.sumTax();
                if(total > maxTotal)
                {
                    max = student;
                    maxTotal = total;
                }
            }
            return max;
        }

        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            if (lbStudents.SelectedItems.Count > 0)
            {
                ((Student)lbStudents.SelectedItem).AddPayment(Convert.ToInt32(nudPaymentCost.Value));
                lbPaymentsOfStudent.Text = ((Student)lbStudents.SelectedItem).ToString1();
                nudPaymentCost.Value = 0;
                tbBiggestPayment.Text = maxPayment().ToString();
            }
        }

        private void btnDeletePayments_Click(object sender, EventArgs e)
        {
            if (lbStudents.SelectedItems.Count > 0)
            {
                ((Student)lbStudents.SelectedItem).RemovePayments();
                lbPaymentsOfStudent.Text = ((Student)lbStudents.SelectedItem).ToString1();
                tbBiggestPayment.Text = maxPayment().ToString();
            }
        }
    }
}
