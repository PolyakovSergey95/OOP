using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Student: Person
    {
        public Education StudentEducation;
        private int GroupNumber;
        private System.Collections.ArrayList TestsArray;
        private Exam[] ExamArray;
        public Person PersonVal
        {
            get { return (Person)base.DeepCopy(); }
            set
            {
                base.NameVal = value.NameVal;
                base.SecondNameVal = value.SecondNameVal;
                base.Date = value.Date;
            }
        }
        public System.Collections.ArrayList TestsVal
        {
            get { return TestsArray; }
            set { TestsArray = value; }
        }
        public Exam[] ExamsVal
        {
            get { return ExamArray; }
            set { ExamArray = value; }
        }
        public double Middle
        {
            get
            {
                if (ExamArray != null)
                {
                    int summ = 0;
                    for (int i = 0; i < ExamArray.Length; i++)
                    {
                        if (ExamArray[i]!=null)
                        summ += ExamArray[i].Mark;
                    }
                    return summ / ExamArray.Length;
                }
                return 0;
            }
        }
        public int GroupNumberVal
        {
            get { return GroupNumber; }
            set
            {
                string Message = "Ошибка: Номер группы должен быть в диапозоне от 100 до 599";
                try
                {
                    if (value <= 100 || value > 599) throw new ArgumentOutOfRangeException(Message);
                    GroupNumber = value;
                }
                catch (ArgumentOutOfRangeException) 
                {
                    Console.WriteLine(Message);
                }
            }
        }
        private int n = 0;
        public void AddExams(Exam[] e)
        {
            for (int i = 0; i < e.Length; i++)
            {
                ExamArray[n] = e[i];
                n++;
            }
        }
        public void AddTests (Test[] t)
        {
            for (int i = 0; i < t.Length; i++)
                TestsArray.Add(t[i]);
        }

        public Student(String N, String SN, DateTime D, Education E, int Gn)
            : base(N, SN, D)
        {
            StudentEducation = E;   
            GroupNumber = Gn;
            ExamArray = new Exam[10];
            TestsArray = new System.Collections.ArrayList();
        }
        public Student():base()
        {
            StudentEducation = (Education)1;
            GroupNumber = 0;
            ExamArray = new Exam[10];
            TestsArray= new System.Collections.ArrayList();
        }
        public override string ToString()
        {
            return base.ToString() + " " + StudentEducation.ToString() + " " + GroupNumber.ToString() + " " + TestsArray.ToString() + " " + ExamArray.ToString();
        }
        public override string ToShortString()
        {
            return base.ToShortString() + " " + StudentEducation.ToString() + " " + GroupNumber.ToString() + " " + Middle.ToString();
        }
        public override object DeepCopy()
        {
            Person p = (Person)base.DeepCopy();
            Student s = new Student(p.NameVal, p.SecondNameVal, p.Date, StudentEducation, GroupNumber);
            s.TestsVal = TestsVal;
            s.ExamsVal = ExamsVal;
            return s;
        }
    }
}
