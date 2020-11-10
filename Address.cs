using System;

namespace employees
{
    public class Address
    {
        private string _country;
        public string Country
        {
            get
            {
                return _country;
            }
            set
            {
                _country = value;
            }
        }
        private string _city;
        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                _city = value;
            }
        }

        //string messageField;

        public void Print()
        {
            Console.WriteLine("The address is {0}, {1}", City, Country);
        }
    }
}