using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graduation_Example
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Major { get; set; }
        public double GPA { get; set; }
        public Address Address { get; set; }

        public Student()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            Major = string.Empty;
            GPA = 0;
            Address = new Address();
        }

        public Student(string firstName, string lastName, string major, double gpa)
        {
            FirstName = firstName;
            LastName = lastName;
            Major = major;
            GPA = gpa;
            Address = new Address();
        }

        public string Distinction()
        {
            string distinct;
            if (GPA >=3.80)
            {
                distinct = "SUMMA CUM LAUDE";
            }
            else if (GPA>= 3.60)
            {
                distinct = "MAGNA CUM LAUDE";
            }
            else if (GPA >= 3.40)
            {
                distinct = "CUM LAUDE";
            }
            else
            {
                distinct = "";
            }

            return distinct;
        }

        public void SetAddress(int streetNumber, string StreetName, string state, string city, int zipcode)
        {
            Address.StreetNumber = streetNumber;
            Address.StreetName = StreetName;
            Address.City = city;
            Address.Zipcode = zipcode;
            Address.State = state;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}, {Major}, {Distinction()}";
        }
    }
}
