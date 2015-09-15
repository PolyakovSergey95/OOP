using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    enum Education { Specialist, Bachelor, SecondEducation }
    class Program
    {
        static void Main(string[] args)
        {
            Student S1 = new Student();
            Console.WriteLine(S1.ToShortString());
            S1.PersonVal = new Person("Sergey", "Polyakov", new DateTime(1995, 4, 9));
            S1.StudentEducation = Education.Specialist;
            S1.GroupNumberVal = 232;
            S1.ExamsVal = new Exam[4];
            S1.TestsVal = new System.Collections.ArrayList();
            Console.WriteLine(S1.ToString());
            Exam[] buf = new Exam[] { new Exam("Programming", 5, new DateTime(2015, 12, 01)), new Exam("Economics", 5, new DateTime(2015, 12, 11)),
            new Exam("Math", 5, new DateTime(2015, 12, 14)), new Exam("Foreign language", 4, new DateTime(2015, 12, 20))};
            S1.AddExams(buf);
            Console.WriteLine(S1.ToString());
            Person p1 = new Person("Name", "SName", new DateTime(1998, 1, 1));
            Person p2 = new Person("Name", "SName", new DateTime(1998, 1, 1));
            Console.WriteLine(p1==p2);
            Console.WriteLine(p1.Equals(p2));
            Console.WriteLine(p1.GetHashCode().ToString()+" "+p2.GetHashCode().ToString());
            Student S2 = new Student("Ivan", "Ivanov", new DateTime(1994, 4, 5), Education.Bachelor, 432);
            S2.AddExams(new Exam[] {new Exam("Math", 5, new DateTime(2015,4,30)), new Exam("Biology", 4 ,new DateTime(2015,4,25))});
            S2.AddTests(new Test[] { new Test("Philosophy", true, new DateTime(2015, 4, 15)), new Test("Social", true, new DateTime(2015, 4, 10)) });
            Console.WriteLine(S2.ToString());
            Student S21 = (Student)S2.DeepCopy();
            S2.NameVal = "Petr";
            S2.SecondNameVal = "Petrov";
            Console.WriteLine(S2.ToString());
            Console.WriteLine(S21.ToString());
            S2.GroupNumberVal = 1000;
            foreach (Exam Ex in S2.ExamsVal)
            {
                if (Ex!=null)
                    Console.WriteLine(Ex.ToString());
            }
            foreach (Test Ts in S2.TestsVal)
            {
                if (Ts != null)
                    Console.WriteLine(Ts);
            }
            foreach (Exam Ex in S2.ExamsVal)
            {
                if ((Ex != null) && (Ex.Mark>3))
                    Console.WriteLine(Ex.ToString());
            }

        }
    }
}
