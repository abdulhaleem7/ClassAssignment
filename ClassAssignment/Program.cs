
using System;

namespace ClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Studenttest student1 = new Studenttest();
            student1.FullName = "haleem";
            student1.Course = "computer";
            student1.Email = "salaudenhaleem7@gmail.com";
            student1.Subject = "mathematics";
            student1.University = "unilorin";
            student1.PhoneNumber = "09023192701";
            Console.WriteLine($"my name is {student1.FullName} i went to {student1.University}. i studied" +
                $"  {student1.Course} my best subject is {student1.Subject} my email acc. is {student1.Email} and my " +
                $"contact info is :{student1.PhoneNumber} ");

            Console.WriteLine();

            Studenttest student2 = new Studenttest();
            student2.FullName = "ayomide";
            student2.Course = "computer science";
            student2.Email = "salaudenabdulhaleem7@gmail.com";
            student2.Subject = "english";
            student2.University = "funaab";
            student2.PhoneNumber = "09023142709";
            Console.WriteLine($"his name is {student2.FullName} he" +
                $" studied {student2.Course} in university {student2.University} his best subject is {student2.Subject} is" +
                $" gmail acc. is {student2.Email} and his contact info is {student2.PhoneNumber} ");*/

            /*            Studenttest.FullName = "haleem";
                        Studenttest.Course = "computerscience";
                        Studenttest.Email = "salaudenhaleem7@gmail.com";
                        Studenttest.Subject = "physics";
                        Studenttest.University = "funaab";
                        Studenttest.PhoneNumber = "09023192701";*/

            Libarary b = new Libarary("g", "h");
            b.AddBook();
            b.AddBook();
            b.RemoveBook();
            Libarary.ListBooks();

        }
    }
}
