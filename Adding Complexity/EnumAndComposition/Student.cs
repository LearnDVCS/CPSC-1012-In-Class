using System;

namespace EnumAndComposition
{
    public class Student
    {
        #region Fields
        private string _name; // The full name of the student
        private string _program; // The course program; e.g.: "DMIT"
        private double _gradePointAverage; // GPA is from 1.0 to 9.0
        private Address _homeAddress;
        #endregion

        #region Properties
        public int StudentId { get; private set; }
        public bool IsFullTime { get; set; }
        public Gender Gender { get; set; }

        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Name cannot be empty");
                _name = value.Trim();
            }
        }

        public string Program
        {
            get { return _program; }
            set
            {
                if (string.IsNullOrEmpty(value) ||
                    string.IsNullOrEmpty(value.Trim()))
                    throw new Exception("Program cannot be empty");
                _program = value.Trim();
            }
        }

        public Address HomeAddress
        {
            get { return _homeAddress; }
            set
            {
                if (value == null)
                    throw new Exception("Address is required");
                _homeAddress = value;
            }
        }

        public double GradePointAverage
        {
            get { return _gradePointAverage; }
            set
            {
                if (value < 1.0 || value > 9.0)
                    throw new Exception("GPA must be between 1 and 9 inclusive");
                _gradePointAverage = value;
            }
        }
        #endregion

        #region Constructors
        // Greedy Constructor
        public Student(int id, 
                       string fullName,
                       Gender gender,
                       Address homeAddress,
                       string programOfStudy,
                       double gradePointAverage,
                       bool isFullTime = true)
        {
            // My job is to ensure that "valid values" are in all
            // the properties/fields
            if (id < 100000000 || id > 999999999)
                throw new Exception("Student Ids must be 9 digits");
            StudentId = id;
            Name = fullName;
            Gender = gender;
            HomeAddress = homeAddress;
            Program = programOfStudy;
            GradePointAverage = gradePointAverage;
            IsFullTime = isFullTime;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"({StudentId}) {Name}";
        }
        #endregion
    }
}
