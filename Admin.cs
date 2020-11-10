using System;
using System.Collections.Generic;

namespace employees
{
    class Admin : Manager, Tech //тук не съм много сигурна как да го направя
    {

        public Manager CreateManager(Employee emp, List<Employee> empls)
        {

            Manager m = new Manager();

            m.Name = emp.Name;
            m.Surname = emp.Surname;
            m.LastName = emp.LastName;
            m.BirthDate = emp.BirthDate;
            m.Gender = emp.Gender;
            m.Egn = emp.Egn;
            m.Email = emp.Email;
            m.AppointmentDate = emp.AppointmentDate;
            m.City = emp.City;
            m.Country = emp.Country;
            m.Employees = empls;

            m.PrintManager();
            return m;
        }
        public Tech CreateTech(Employee emp, Manager m, List<Course> c)
        {
            Tech t = new Tech();

            t.Name = emp.Name;
            t.Surname = emp.Surname;
            t.LastName = emp.LastName;
            t.BirthDate = emp.BirthDate;
            t.Gender = emp.Gender;
            t.Egn = emp.Egn;
            t.Email = emp.Email;
            t.AppointmentDate = emp.AppointmentDate;
            t.City = emp.City;
            t.Country = emp.Country;
            t.manager = m;
            t.courses = c;

            t.PrintTech();
            return t;


            return t;
        }

        public override void SetWork()
        {
            WorkHours = 12;
            WorkDays = 10;
            //salary = salary * workHours * workDays;
        }
    }
}
