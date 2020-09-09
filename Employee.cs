using System;

namespace employees
{
    public class Employee
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
            catch (Exeption e)
            {

            }
            return 0;
        }
    }

}