using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAssignment
{
    class Studentt
    {
        //Number5
        private string FullName { get; set; }
        private string Course;
        private string Subject;
        private string University;
        private string Email;
        private string PhoneNumber;
       
      public string GetFullName()
        {
            return FullName.ToUpper();
        }
        public void SetFullName(string fullname)
        {
            FullName = fullname;
        }
        public string GetCourse()
        {
            return Course;
        }
        public void SetCourse(string course)
        {
            Course = course;
        }
        public string Getsubject()
        {
            return Subject;
        }
        public void SetSubject(string subject)
        {
            Subject = subject;
        }
        public string GetUniversity()
        {
            return University;
        }
        public void SetUniversity(string university)
        {
            University = university;
        }
        public string GetEmail()
        {
            return Email;
        }
        public void SetEmail(string email)
        {
            Email = email;
        }
        public string GetPhoneNumber()
        {
            return PhoneNumber;
        }
        public void SetPhoneNumber(string phonenumber)
        {
            PhoneNumber = phonenumber;
        }

    }
}
