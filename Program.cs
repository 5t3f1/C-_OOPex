using System;
using System.Collections.Generic;

namespace employees
{
    class Program
    {

        static void Main()
        {
            List<Event> events = new List<Event>();

            List<Employee> empls = new List<Employee>();

            //Address empAddress = new Address("Bulgaria", "Sofia");

            Employee emp1 = new Employee();

            emp1.Name = "Ivan";
            emp1.Surname = "Ivanov";
            emp1.LastName = "Petrov";
            emp1.BirthDate = "12.08.2000";
            emp1.Gender = "male";
            emp1.Egn = "0048124783";
            emp1.Email = "i.ivanov@gail.com";
            emp1.AppointmentDate = 2018;
            emp1.City = "Sofia";
            emp1.Country = "Bulgaria";

            emp1.PrintEmpInfo();

            Employee emp2 = new Employee();
            emp2.Name = "Peter";
            emp2.Surname = "Ivanov";
            emp2.LastName = "Petrov";
            emp2.BirthDate = "18.03.2000";
            emp2.Gender = "male";
            emp2.Egn = "0043184783";
            emp2.Email = "p.petrovv@gail.com";
            emp2.AppointmentDate = 2018;
            emp2.City = "Sofia";
            emp2.Country = "Bulgaria";

            emp2.PrintEmpInfo();

            empls.Add(emp1);
            empls.Add(emp2);

            Employee emp3 = new Employee();
            emp3.Name = "Georgi";
            emp3.Surname = "Georgiev";
            emp3.LastName = "Georgiev";
            emp3.BirthDate = "30.01.1998";
            emp3.Gender = "male";
            emp3.Egn = "9901394783";
            emp3.Email = "g.georgiev@gail.com";
            emp3.AppointmentDate = 2016;
            emp3.City = "Sofia";
            emp3.Country = "Bulgaria";

            Manager m1 = new Manager();
            m1.Employees = empls;
            m1.Pin = "2281";
            m1.Name = "Georgi";
            m1.Surname = "Georgiev";
            m1.LastName = "Georgiev";
            m1.BirthDate = "30.01.1998";
            m1.Gender = "male";
            m1.Egn = "9901394783";
            m1.Email = "g.georgiev@gail.com";
            m1.AppointmentDate = 2016;
            m1.City = "Sofia";
            m1.Country = "Bulgaria";


            //m1.PrintEmpInfo();
            m1.PrintManager();
        }
    }
}
