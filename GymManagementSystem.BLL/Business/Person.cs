
using System;
using System.Linq;

namespace GymManagementSystem.BLL.Entities
{
    public enum Gender { Male, Female }

    public abstract class Person
    {
        protected enum eMode { Add, Update };

        private int _areaID;
        private Area _area;
        private bool _areaLoaded;

        public int PersonID { get; set; }

        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime BirthDate { get; set; }

        public Gender Gender { get; set; }

        public int AreaID
        {
            get => _areaID;
            set
            {
                if (_areaID == value)
                    return;

                _areaID = value;

                _area = null;
                _areaLoaded = false;
            }
        }

        public Area Area
        {
            get
            {
                if (!_areaLoaded)
                {
                    _area = GymManagementSystem.BLL.Entities.Area.GetByID(_areaID);
                    _areaLoaded = true;
                }

                return _area;
            }
        }

        protected Person(
            int personID,
            string firstName,
            string secondName,
            string thirdName,
            string lastName,
            string phoneNumber,
            DateTime birthDate,
            Gender gender,
            int areaID)
        {
            PersonID = personID;
            FirstName = firstName;
            SecondName = secondName;
            ThirdName = thirdName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            BirthDate = birthDate;
            Gender = gender;
            AreaID = areaID;
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

                if (BirthDate.Date > DateTime.Today.AddYears(-age))
                    age--;

                return age;
            }
        }

        public bool IsMale => Gender == Gender.Male;
    }
}
