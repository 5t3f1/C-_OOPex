using System;

namespace employees
{
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
}
