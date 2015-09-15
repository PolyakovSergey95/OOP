using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Exam: IDateAndCopy
    {
        public String Name { get; set; }
        public int Mark { get; set; }
        public DateTime Date { get; set; }
        public Exam(String N, int M, DateTime D)
        {
            Name = N;
            Mark = M;
            Date = D;
        }
        public Exam()
        {
            Name = "";
            Mark = 0;
            Date = new DateTime(1990,1,1);
        }
        public override string ToString()
        {
            return Name + " " + Mark.ToString() + " " + Date.ToShortDateString();
        }
        public virtual object DeepCopy()
        {
            Exam e = new Exam(Name, Mark, Date);
            return (object)e;
        }

    }
}
