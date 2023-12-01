using System;
namespace Project
{
    public class Customer
    {
        private static int NextCustomerId = 0;
        private int CustomerId ;
        private string firstName;
        private string lastName;
        private string phone;
        private int numOfBookings;

        public Customer(string firstName, string lastName, string phone)
        {
            this.CustomerId = ++NextCustomerId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.phone = phone;
            this.numOfBookings = 0;
        }

        public int getCustomerId()
        {
            return CustomerId;
        }
       
        public string getfname() { return firstName; }
        public string getlname() { return lastName; }
        public string getphone() { return phone; }
        public string getfullname() { return firstName + " " + lastName; }
        public int getnumbookings() { return numOfBookings++; }


        public override string? ToString()
        {
            string s = "\n";
            s += "\tCustomer Id:" + getCustomerId();
            s += "\tName: " + firstName + " " + lastName;
            s += "\tPhone: " + phone;
            s += "\tTotal Number of Booking made: " + numOfBookings;
            return s;
        }
    }
}

