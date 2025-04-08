using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStructDemo
{
    public struct Person
    {
        // Personal details
        public string FirstName { get; }
        public string LastName { get; }
        public DateTime DateOfBirth { get; }
        public string Gender { get; }
        public string Nationality { get; }

        // Contact information
        public string Email { get; }
        public string PhoneNumber { get; }
        public string MobileNumber { get; }

        // Address
        public string StreetAddress { get; }
        public string City { get; }
        public string State { get; }
        public string PostalCode { get; }
        public string Country { get; }

        // Employment details
        public string JobTitle { get; }
        public string Company { get; }
        public DateTime EmploymentStartDate { get; }
        public DateTime EmploymentEndDate { get; }
        public decimal Salary { get; }

        // Education details
        public string HighestDegree { get; }
        public string University { get; }
        public DateTime GraduationDate { get; }

        // Additional attributes
        public string MaritalStatus { get; }
        public int NumberOfChildren { get; }
        public string[] LanguagesSpoken { get; }
        public string[] Hobbies { get; }
        public string[] Skills { get; }

        public Person(
            string firstName, string lastName, DateTime dateOfBirth, string gender, string nationality,
            string email, string phoneNumber, string mobileNumber,
            string streetAddress, string city, string state, string postalCode, string country,
            string jobTitle, string company, DateTime employmentStartDate, DateTime employmentEndDate, decimal salary,
            string highestDegree, string university, DateTime graduationDate,
            string maritalStatus, int numberOfChildren, string[] languagesSpoken, string[] hobbies, string[] skills)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            Nationality = nationality;
            Email = email;
            PhoneNumber = phoneNumber;
            MobileNumber = mobileNumber;
            StreetAddress = streetAddress;
            City = city;
            State = state;
            PostalCode = postalCode;
            Country = country;
            JobTitle = jobTitle;
            Company = company;
            EmploymentStartDate = employmentStartDate;
            EmploymentEndDate = employmentEndDate;
            Salary = salary;
            HighestDegree = highestDegree;
            University = university;
            GraduationDate = graduationDate;
            MaritalStatus = maritalStatus;
            NumberOfChildren = numberOfChildren;
            LanguagesSpoken = languagesSpoken;
            Hobbies = hobbies;
            Skills = skills;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}, {JobTitle} at {Company}";
        }
    }
}
