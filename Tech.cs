using System;

namespace employees
{
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
}
