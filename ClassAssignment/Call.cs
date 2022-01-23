using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAssignment
{
    public class logs
    {
        public string number { get; set; }
        public DateTime Date { get; set; }
        public DateTime Begin { get; set; }
        public DateTime End { get; set; }

        public logs(string num)
        {
            number = num;

            Date = DateTime.Now;
            Begin = DateTime.UtcNow;
            End = DateTime.UtcNow;
        }
        public string List()
        {
            string a = $"{number}   {Date} {Begin} {End}";
            return a;
        }
    }


    public class Call<T> where T : logs
    {

        public string Listlogs(T obj)
        {
            return (obj.List());
        }


    }


    public class lisTcall
    {
        public static void Enlist()
        {
            logs log = new logs("09876");
            Call<logs> s = new Call<logs>();
            Console.WriteLine(s.Listlogs(log));
        }


    }

}
