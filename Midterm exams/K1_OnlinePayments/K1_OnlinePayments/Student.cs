using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K1_OnlinePayments
{
    public class Student
    {
        public string Name { get; set; }
        public string Index { get; set; }
        List<int> Payments { get; set; }

        public Student(string name, string index, List<int> payments)
        {
            Name = name;
            Index = index;
            Payments = new List<int>();
        }

        private int tax(int i)
        {
            if (i < Payments.Count)
            {
                return Convert.ToInt32(Payments[i] * 0.0114);
            }
            else
            {
                return 0;
            }
        }

        private int total(int i)
        {
            if (i < Payments.Count)
            {
                return Convert.ToInt32(Payments[i] + tax(i));
            }
            {
                return 0;
            }
        }

        public void AddPayment(int amount)
        {
            Payments.Add(amount);
        }

        public void RemovePayments()
        {
            Payments.Clear();
        }

        public int sumPayments()
        {
            int sum = 0;
            foreach (int i in Payments)
            {
                sum += i;
            }
            return sum;
        }

        public int sumTax()
        {
            int sum = 0;
            for (int i = 0; i < Payments.Count; i++)
            {
                sum += tax(i);
            }
            return sum;
        }

        public string ToString1()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Index);
            sb.Append(" ");
            sb.Append(Name);
            sb.Append("\n");
            for (int i = 0; i < Payments.Count; i++)
            {
                sb.Append((i + 1) + ". Уплата: " + Payments[i].ToString() + " ");
                sb.Append("Провизија: " + tax(i) + " ");
                sb.Append("Вкупно: " + total(i) + "\n");
            }
            sb.Append("Вкупно уплати: " + sumPayments() + "\n");
            sb.Append("Вкупно провизија: " + sumTax() + "\n");
            return sb.ToString();
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Index);
            sb.Append(" ");
            sb.Append(Name);
            return sb.ToString();
        }
    }
}
