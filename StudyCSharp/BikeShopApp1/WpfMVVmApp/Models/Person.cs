using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WpfMVVmApp.Helpers;

namespace WpfMVVmApp.Models
{
    public class Person
    {
        public string FirstName { get; set; } // table 상 필드
        public string LastName { get; set; } // table 상 필드

        string email; // table 상 필드

        public string Email
        {
            get{ return email; }
            set
            {
                if (Commons.IsValidEmail(value))
                    email = value;
                else
                    throw new Exception("Invalid Email");
            }
        }


        DateTime date;

        public DateTime Date
        {
            get { return date; }
            set 
            {
                var result = Commons.CalcAge(value); //나이
                if (result > 150 || result < 0)
                    throw new Exception("Invalid Age");
                else
                    date = value; 
            }
        }

        public Person(string firstName, string lastName, string email, DateTime date)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Date = date;
        }
        public bool IsBirthDay
        {
            get
            {
                return DateTime.Now.Month == Date.Month && DateTime.Now.Day == Date.Day;
            }
        }

        public bool IsAdult
        {
            get
            {
                return Commons.CalcAge(date) > 18;
            }
        }
        public string ChnZodiac
        {
            get
            {
                return Commons.GetChinesZodiac(Date);
            }
        }

        public string Zodiac
        {
            get
            {
                return Commons.GetZodiac(Date);
            }
        }
    }

}
