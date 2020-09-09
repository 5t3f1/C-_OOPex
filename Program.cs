using System;
using System.Collections.Generic;

namespace employees
{
    class Program
    {
        
        public class Address
        {
            string country;
            string city;
            //string messageField;

            public Address(string addCountry,
                string addCity)
                //string addMessageField)
            {
                country = addCountry;
                city = addCity;
                //messageField = addMessageField;
            }

            public void Print()
            {
                Console.WriteLine("The address is {0}, {1}" , city, country);
            }
        }
        class Employee
        {
            //public:
            string name;
            string surname;
            string lastName;
            string birthDate;
            string sex;
            string egn;
            string email;
            int appointmentDate;
            
            Address address;
            int salary;
            int workDays;
            int workHours;

            //public Employee();
            public Employee(string empName,
                string empSurname,
                string emoLastName,
                string empBirthDate,
                string empSex,
                string empEgn,
                string empEmail,
                int empAppointmentDate,
                Address empAddress)
            {
                name = empName;
                surname = empSurname;
                lastName = emoLastName;
                birthDate = empBirthDate;
                sex = empSex;
                email = empEmail;
                egn = empEgn;
                appointmentDate = empAppointmentDate;
                address = empAddress;
            }

            public void PrintAddress()
            {
                address.Print();
            }

            public void PrintEmpInfo()
            {
                Console.WriteLine("Employee: {0} {1} {2}", name, surname, lastName);
                Console.WriteLine("Date of Birth: {0}", birthDate);
                Console.WriteLine("Sex: {0}", sex);
                Console.WriteLine("EGN: {0}", egn);
                Console.WriteLine("Email: {0}", email);
                Console.WriteLine("Appointed: {0}", appointmentDate);
                Console.WriteLine("Salary/hour {0}bgn " +
                    "for {1} days from month" +
                    "at {2} hours per day ", salary, workDays, workHours);
                
                PrintAddress();

                Console.WriteLine("\n");
                
            }

            public void SetWork()
            {
                workHours = 8;
                workDays = 20;
                //salary = salary * workHours * workDays;
            }
            public int GetSalary()
            {
                try
                {
                    salary = salary * workHours * workDays;
                }
                catch()
                {

                }
                return 0;
            }
        }

        class Manager : Employee
        {
            List<Employee> employees = new List<Employee>();
            string pin; //restrictions

            public Manager(List<Employee> mEmployees, string mPin, 
                string name,
                string surname,
                string lastName,
                string birthDate,
                string sex,
                string egn,
                string email,
                int appointmentDate,
                Address address) : base(name,
                surname,
                lastName,
                birthDate,
                sex,
                egn,
                email,
                appointmentDate,
                address)
            {
                
                employees = mEmployees;
                pin = mPin;
            }

            public void PrintManager()
            {
                Console.WriteLine("-Manager-");
                PrintEmpInfo();
                Console.WriteLine("Responsible for:");
                foreach(Employee emp in employees)
                {
                    emp.PrintEmpInfo();
                }
            }



        }

        class Course
        {
            string name;
            string startDate;
            string endDate;
            float rate;
            public Course(string course, string start, string end, float percent)
            {
                name = course;
                startDate = start;
                endDate = end;
                rate = percent;
            }

            public void PrintCourse()
            {
                Console.WriteLine("Course '{0}': " +
                    "started - {1}, ended - {2}" +
                    "percentage - {3}%");
            }
        }
        class Tech : Employee
        {
            Manager manager;
            List<Course> courses;
            public Tech(Manager tManager, List<Course> tCourse, 
                string name,
                string surname,
                string lastName,
                string birthDate,
                string sex,
                string egn,
                string email,
                int appointmentDate,
                Address address) : base(name,
                surname,
                lastName,
                birthDate,
                sex,
                egn,
                email,
                appointmentDate,
                address)
            {
                manager = tManager;
                courses = tCourse;
            }
            public void PrintTech()
            {
                Console.WriteLine("-Tech-");
                PrintEmpInfo();
                Console.WriteLine("Course/s:");
                foreach (Course c in courses)
                {
                    c.PrintCourse();
                }
            }
        }

        class Admin : Employee
        {
            public Admin(string name,
                string surname,
                string lastName,
                string birthDate,
                string sex,
                string egn,
                string email,
                int appointmentDate,
                Address address) : base(name,
                surname,
                lastName,
                birthDate,
                sex,
                egn,
                email,
                appointmentDate,
                address)
            { }

            public Manager CreateManager()
            {
                Address address = new Address("Bulgaria", "Sofia");
                List<Employee> empls = new List<Employee>();
                Manager m = new Manager(empls, "1234", "todor", "borsov", "mihailov", "5.7.1998", "male", "9807051221", "t.mih@gmail.com", 2016, address);

                m.PrintManager();
                return m;
            }
            public Tech CreateTech()
            {
                Tech t = new Tech();



                return t;
            }
        }

        static void Main()
        {
            List<Event> events = new List<Event>();

            List<Employee> empls = new List<Employee>();
            
            Address empAddress = new Address("Bulgaria", "Sofia");
            Employee emp1 = new Employee("ivan", 
                "petrov", 
                "ivanov",
                "12.08.2000",
                "male",
                "0048124783",
                "i.ivanov@gail.com",
                2018,
                empAddress);

            Employee emp2 = new Employee("peter",
                "ivanov",
                "petrov",
                "18.03.2000",
                "male",
                "0043184783",
                "p.petrovv@gail.com",
                2018,
                empAddress);

            empls.Add(emp1);
            empls.Add(emp2);

            Employee emp3 = new Employee("georgi",
                "georgiev",
                "georgiev",
                "30.01.1998",
                "male",
                "9901394783",
                "g.georgiev@gail.com",
                2016,
                empAddress);

            emp1.PrintEmpInfo();
            //empAddress.Print();

            Manager m1 = new Manager(empls, "2281", "georgi",
                "georgiev",
                "georgiev",
                "30.01.1998",
                "male",
                "9901394783",
                "g.georgiev@gail.com",
                2016,
                empAddress);

            //m1.PrintEmpInfo();
            m1.PrintManager();
        }
    }
}
