using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Test: IDateAndCopy
    {
        public string Name { get; set; }
        public bool Mark { get; set; }
        public DateTime Date { get; set; }
        public Test (string N, bool M, DateTime D)
        {
            Name = N;
            Mark = M;
            Date = D;
        }
        public Test()
        {
            Name = "";
            Mark = false;
            Date = new DateTime(1190, 1, 1);
        }
        public override string ToString()
        {
            return Name+" "+Mark.ToString();
        }
        public virtual object DeepCopy()
        {
            Test t = new Test(Name, Mark, Date);
            return (object)t;
        }
    }
}
