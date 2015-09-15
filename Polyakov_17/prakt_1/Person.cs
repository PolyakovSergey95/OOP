using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Person: IDateAndCopy
    {
        private string Name;
        private string SecondName;
        private DateTime DateOfBorn;
        public string NameVal
        {
            get { return Name; }
            set { Name = value; }
        }
        public string SecondNameVal
        {
            get { return SecondName; }
            set { SecondName = value; }
        }
        public DateTime Date
        {
            get { return DateOfBorn; }
            set { DateOfBorn = value; }
        }
        public int YearVal
        {
            get { return DateOfBorn.Year; }
            set { DateOfBorn = new DateTime(value, DateOfBorn.Month, DateOfBorn.Day);}
        }
        public Person ()
        {
            Name = "Иван";
            SecondName = "Иванов";
            DateOfBorn = new DateTime(1990, 1, 1);
        }
        public Person(string N, string SN, DateTime DoB)
        {
            Name = N;
            SecondName = SN;
            DateOfBorn = DoB;
        }
        public override string ToString()
        {
            return Name + " " + SecondName + " " + DateOfBorn.ToShortDateString();
        }
        public virtual string ToShortString()
        {
            return Name + " " + SecondName;
        }
        public override bool Equals(System.Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Person p = obj as Person;
            if ((System.Object)p == null)
            {
                return false;
            }
            return (Name == p.Name) && (SecondName == p.SecondName) && (DateOfBorn == p.DateOfBorn);
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ SecondName.GetHashCode() ^ DateOfBorn.GetHashCode();
        }

        public static bool operator ==(Person a, Person b)
        {
            if (a.Name == b.Name && a.SecondName == b.SecondName && a.DateOfBorn == b.DateOfBorn)
                return true;
            return false;
        }
        public static bool operator !=(Person a, Person b)
        {
            if (a.Name != b.Name && a.SecondName != b.SecondName && a.DateOfBorn != b.DateOfBorn)
                return true;
            return false;
        }

        public virtual object DeepCopy()
        {
            Person p = new Person(Name, SecondName, DateOfBorn);
            return p;
        }
    }
}
