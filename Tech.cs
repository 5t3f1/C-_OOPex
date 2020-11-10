using System;
using System.Collections.Generic;


namespace employees
{

    class Tech : Employee
    {
        public Manager manager;
        public List<Course> courses;

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
        public override void SetWork()
        {
            WorkHours = 8;
            WorkDays = 20;
            //salary = salary * workHours * workDays;
        }

        public override int GetSalary()
        {

            Salary = Salary * WorkHours * WorkDays;
            Salary = Salary + (10 * (2020 - AppointmentDate) * Salary / 100);
            return Salary;
        }
    }
}
