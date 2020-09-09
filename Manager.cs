using System;

namespace employees
{
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
            foreach (Employee emp in employees)
            {
                emp.PrintEmpInfo();
            }
        }



    }
}