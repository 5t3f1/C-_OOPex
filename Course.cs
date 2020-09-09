using System;

namespace employees
{
    class Course
    {
        string name;
        string startDate;
        string endDate;
        float rate;
        public Course(string course, string start, string end, float percent)
        {
            name = course;
            startDate = start;
            endDate = end;
            rate = percent;
        }

        public void PrintCourse()
        {
            Console.WriteLine("Course '{0}': " +
                "started - {1}, ended - {2}" +
                "percentage - {3}%");
        }
    }
}
