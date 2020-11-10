using System;
using System.Collections.Generic;


namespace employees
{
    class Manager : Employee
    {
        public List<Employee> Employees = new List<Employee>();

        private string _pin;
        public string Pin //restrictions
        {
            get
            {
                return _pin;
            }
            set
            {
                _pin = value;
            }
        }

        public void PrintManager()
        {
            Console.WriteLine("-Manager-");
            PrintEmpInfo();
            Console.WriteLine("Responsible for:");
            foreach (Employee emp in Employees)
            {
                emp.PrintEmpInfo();
            }
        }

        public override void SetWork()
        {
            WorkHours = 5;
            WorkDays = 30;
            //salary = salary * workHours * workDays;
        }

        public override int GetSalary()
        {

            Salary = Salary * WorkHours * WorkDays;
            Salary = Salary + (Employees.Count * Salary / 100);
            return Salary;
        }



    }
}
