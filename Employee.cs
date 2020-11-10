using System;
using System.Numerics;

namespace employees
{
    public class Employee : Address
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        private string _surname;
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = value;
            }
        }
        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
        private string _birthDate;
        public string BirthDate
        {
            get
            {
                return _birthDate;
            }
            set
            {
                _birthDate = value;
            }
        }
        private string _gender;
        public string Gender
        {
            get
            {
                return _gender;
            }
            set
            {
                _gender = value;
            }
        }
        private string _egn;
        public string Egn
        {
            get
            {
                return _egn;
            }
            set
            {
                _egn = value;
            }
        }
        private string _email;
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }
        private int _appointmentDate;
        public int AppointmentDate
        {
            get
            {
                return _appointmentDate;
            }
            set
            {
                _appointmentDate = value;
            }
        }

        private int _salary;
        public int Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                _salary = value;
            }
        }
        private int _workDays;
        public int WorkDays
        {
            get
            {
                return _workDays;
            }
            set
            {
                _workDays = value;
            }
        }
        private int _workHours;
        public int WorkHours
        {
            get
            {
                return _workDays;
            }
            set
            {
                _workDays = value;
            }
        }


        //public Employee();

        public void PrintAddress()
        {
            Print();
        }

        public void PrintEmpInfo()
        {
            Console.WriteLine("Employee: {0} {1} {2}", Name, Surname, LastName);
            Console.WriteLine("Date of Birth: {0}", BirthDate);
            Console.WriteLine("Sex: {0}", Gender);
            Console.WriteLine("EGN: {0}", Egn);
            Console.WriteLine("Email: {0}", Email);
            Console.WriteLine("Appointed: {0}", AppointmentDate);
            Console.WriteLine("Salary/hour {0}bgn " +
                "for {1} days from month" +
                "at {2} hours per day ", Salary, WorkDays, WorkHours);


            PrintAddress();

            Console.WriteLine("\n");

        }

        public void SetWork()
        {
            WorkHours = 8;
            WorkDays = 20;
            //salary = salary * workHours * workDays;
        }
        public int GetSalary()
        {
            /*try
            {
                Salary = Salary * WorkHours * WorkDays;
            }
            catch (Exception e)
            {

            }*/
            return 0;
        }
    }

}