using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K3_ConferenceWindowsFormsApp
{
    public class ScientificWork
    {
        public string Title { get; set; }
        public string Keywords { get; set; }
        public List<Author> AuthorList { get; set; }

        public ScientificWork(string title, string keywords)
        {
            Title = title;
            Keywords = keywords;
            AuthorList = new List<Author>();
        }

        public void AddAuthor(Author author)
        {
            AuthorList.Add(author);
        }

        public string ToStringRight()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(AuthorList.ElementAt(0).ToString());
            for (int i = 1; i < AuthorList.Count; i++)
            {
                sb.Append(", " + AuthorList[i].ToString());
            }
            sb.Append(" - " + Title);
            return sb.ToString();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(AuthorList.ElementAt(0).ToStringLeft());
            if (AuthorList.Count < 3)
            {
                for (int i = 1; i < AuthorList.Count; i++)
                {
                    sb.Append(", " + AuthorList[i].ToStringLeft());
                }
            }
            else
            {
                sb.Append(", et al.");
            }
            sb.Append(" - " + Title);
            return sb.ToString();
        }
    }
}
