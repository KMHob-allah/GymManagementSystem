using System;
using System.Linq;

namespace GymManagementSystem.BLL.Entities
{
    public enum Gender
    {
        Male = 0,
        Female = 1
    }

    public abstract class Person
    {
        public int PersonID { get; protected set; }

        public string FirstName { get; protected set; }
        public string SecondName { get; protected set; }
        public string ThirdName { get; protected set; }
        public string LastName { get; protected set; }

        public string PhoneNumber { get; protected set; }

        public DateTime BirthDate { get; protected set; }

        public Gender Gender { get; protected set; }

        public string Area { get; protected set; }

        protected Person(int personID,string firstName,string secondName,string thirdName,
            string lastName,string phoneNumber,DateTime birthDate,Gender gender,string area)
        {
            PersonID = personID;
            FirstName = firstName;
            SecondName = secondName;
            ThirdName = thirdName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            BirthDate = birthDate;
            Gender = gender;
            Area = area;
        }

        public string FullName
        {
            get
            {
                return string.Join(" ",
                    new[]
                    {
                        FirstName,
                        SecondName,
                        ThirdName,
                        LastName
                    }
                    .Where(name => !string.IsNullOrWhiteSpace(name)));
            }
        }

        public int Age
        {
            get
            {
                int age = DateTime.Today.Year - BirthDate.Year;

                if (BirthDate.Date > DateTime.Today.AddYears(-age)) age--;

                return age;
            }
        }

        public bool IsMale  => Gender == Gender.Male;
    }
}

