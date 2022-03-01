using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2_Practice
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

        public Student(string firstname, string lastname, string major, double gpa)
        {
            FirstName = firstname;
            LastName = lastname;
            Major = major;
            GPA = gpa;
            Address = new Address();
        }

        public string CalculateDistinction()
        {
            string Distinct;
            if (GPA >= 3.80)
            {
                Distinct = "summa cum laude";
            }
            else if (GPA >= 3.60)
            {
                Distinct = "magna cum laude";
            }
            else if (GPA >= 3.40)
            {
                Distinct = "cum laude";
            }
            else
            {
                Distinct = "";
            }

            return Distinct;
        }
        public void SetAddress(int streetNumber, string streetName, string state, string city, int zipcode)
        {
            Address.StreetNumber = streetNumber;
            Address.StreetName = streetName;
            Address.City = city;
            Address.Zipcode = zipcode;
            Address.State = state;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}, {Major}, {CalculateDistinction()}";
        }
    }
}
