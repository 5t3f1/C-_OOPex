using System;
using System.Collections.Generic;

namespace employees
{
    class Admin : Manager
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
        public Tech CreateTech()
        {
            Tech t = new Tech();



            return t;
        }
    }
}
