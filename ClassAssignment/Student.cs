using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAssignment
{
    public class Student
    {
        //Question1
        public string FullName;
        //Number 3
        public static int count;
        public string Course;
        public string Subject;
        public string University;
        public string Email;
        public string PhoneNumber;
       

        public Student()
        {
         
        }
        //Question2
        public Student(string fullname)
        {
            FullName = fullname;
        }
        public Student(string phonenumber, string course, string subject)
        {
            PhoneNumber = phonenumber;
            Course = course;
            Subject = subject;
        }
        public Student(string university, string email)
        {
            University = university;
            Email = email;

        }
        //Question 4
        public void StudentInfo(Student student)
        {
            FullName = student.FullName; 
            Console.WriteLine(student.FullName);
            Console.WriteLine(student.Course);
            Console.WriteLine(student.Subject);
            Console.WriteLine(student.University);
            Console.WriteLine(student.Email);
            Console.WriteLine(student.PhoneNumber);
        }
        //question 6
       
    }
    public class Studenttest 
    {
        public static string FullName;
        public static int count;
        public static string Course;
        public static string Subject;
        public static string  University;
        public static string Email;
        public static string PhoneNumber;
       
       
    }
}
