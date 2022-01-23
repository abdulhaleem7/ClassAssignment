using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAssignment
{
    public class School
    {
        public const string NameOfSchool = "Government college ibadan";
        public const string Address = "wire&cable apata ibadan";

    }
    public class SchoolClass
    {
        public string Grade1 { get; set; }
        public string Grade2 { get; set; }
        public string Grade3 { get; set; }
        public string Grade4 { get; set; }
        public string Grade5 { get; set; }
        public string Grade6 { get; set; }


        public void GradeOneClass()
        {
            List<string> iGrade1s = new List<string>();

            foreach (var teacher in Teachers.teachers)
            {
                if (teacher.Level == Grade1)
                {

                    iGrade1s.Add($"{teacher.Name}    {teacher.Age}");
                }
            }
            foreach (var disciple in Disciples.disciples)
            {
                if (disciple.Level == Grade1)
                {

                    iGrade1s.Add($"{disciple.Name}    {disciple.Age}");
                }
            }
            foreach (var studentse in Students.stud)
            {
                if (studentse.Level == Grade1)
                {

                    iGrade1s.Add($"{studentse.Name}    {studentse.Age}");
                }
            }
        }
        public void GradtwoClass()
        {
            List<string> grade2 = new List<string>();

            foreach (var teacher in Teachers.teachers)
            {
                if (teacher.Level == Grade2)
                {

                    grade2.Add($"{teacher.Name}    {teacher.Age}   {teacher.TeachersId}");
                }
            }
            foreach (var disciple in Disciples.disciples)
            {
                if (disciple.Level == Grade2)
                {

                    grade2.Add($"{disciple.Name}    {disciple.Age}   {disciple.DicipleId}");
                }
            }
            foreach (var studentse in Students.stud)
            {
                if (studentse.Level == Grade2)
                {
                    grade2.Add($"{studentse.Name}    {studentse.Age}");
                }
            }

            foreach (var person in grade2)
            {
                Console.WriteLine(person);
            }
        }

    }
    public class Students
    {
        public static List<Students> stud = new List<Students>();
        public string Name { get; set; }
        public string Level { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        public Students(string name, string address, int age, string level)
        {
            Name = name;
            Address = address;
            Age = age;
            levels(level);


        }


        public string levels(string level)
        {
            Level = level;
            return Level;
        }


        public static void RegisterStudents()
        {

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your Address: ");
            string address = Console.ReadLine();
            Console.Write("Enter your Age");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter level: ");
            string level = Console.ReadLine();
            Students s = new Students(name, address, age, level);
            s.levels(level);
            stud.Add(s);
            Console.WriteLine("Welcome");
        }


        public static void ListStudents()
        {

            foreach (var f in stud)
            {
                Console.WriteLine($"Name: {f.Name}    Age:{f.Age}      Address:{f.Address}      Class:{f.Level}  ");
            }
        }



    }
    public class Teachers : Students
    {
        public static List<Teachers> teachers = new List<Teachers>();
        public string TeachersId { get; set; }
        public Teachers(string name, string address, int age, string level) : base(name, address, age, level)
        {
            TeachersId = Teacherid();
            Name = name;
            Address = address;
            Age = age;
            Levels(level);
        }


        public string Teacherid()
        {
            Random random = new Random();
            string id = random.Next(1, 100).ToString();
            return id;

        }

        public string Levels(string level)
        {
            Level = level;
            return Level;
        }


        public static void RegisterTeachers()
        {

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your Address: ");
            string address = Console.ReadLine();
            Console.Write("Enter your Age");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter your  class : ");
            string level = Console.ReadLine();
            Teachers s = new Teachers(name, address, age, level);
            s.Levels(level);
            string a = s.Teacherid();
            teachers.Add(s);
            Console.WriteLine($"Welcome your Id is {a}");
        }
        public static void ListTeachers()
        {
            foreach (var f in teachers)
            {
                Console.WriteLine($"Name: {f.Name }    Age:{f.Age}      Address:{f.Address}      Class:{f.Level}    Id:{f.TeachersId}");
            }
        }



    }
    public class Disciples : Students
    {
        public static List<Disciples> disciples = new List<Disciples>();
        public string DicipleId { get; set; }
        public Disciples(string name, string address, int age, string level) : base(name, address, age, level)
        {
            Name = name;
            Address = address;
            Age = age;
            DicipleId = Discipleid();
            Levels1(level);
        }

        public string Discipleid()
        {
            Random random = new Random();
            string id = random.Next(100, 200).ToString();
            return id;

        }

        public string Levels1(string level)
        {
            Level = level;
            return Level;
        }


        public static void RegisterDisciples()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your Address: ");
            string address = Console.ReadLine();
            Console.Write("Enter your Age");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter your  class : ");
            string level = Console.ReadLine();
            Disciples d = new Disciples(name, address, age, level);
            d.Levels1(level);
            string a = d.Discipleid();
            disciples.Add(d);
            Console.WriteLine($"Welcome your Id is {a}");
        }


        public static void ListDisciples()
        {
            foreach (var f in disciples)
            {
                Console.WriteLine($"Name: {f.Name }    Age:{f.Age}      Address:{f.Address}      Class:{f.Level}    Id:{f.DicipleId}");
            }
        }
    }
    public class TestSchool
    {
        public static void Test()
        {
            Disciples.RegisterDisciples();
            Teachers.RegisterTeachers();
            Students.RegisterStudents();
            Disciples.ListDisciples();
            Teachers.ListTeachers();
            Students.ListStudents();
        }
    }
}
