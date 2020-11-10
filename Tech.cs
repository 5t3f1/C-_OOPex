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
    }
}
