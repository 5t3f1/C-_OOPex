using System;

namespace employee
{
    public class Address
    {
        string country;
        string city;
        //string messageField;

        public Address(string addCountry,
            string addCity)
        //string addMessageField)
        {
            country = addCountry;
            city = addCity;
            //messageField = addMessageField;
        }

        public void Print()
        {
            Console.WriteLine("The address is {0}, {1}", city, country);
        }
    }
}