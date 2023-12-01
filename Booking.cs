using System;
using System.Numerics;

namespace Project
{
    public class Booking
    {
        private int BookingId = 1;
        private string Date;
        public Customer customer;
        public Flight flight;

        public Booking(Customer customer, Flight flight)
        {
            Date = DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt");
            this.customer = customer;
            this.flight = flight;
            this.BookingId = BookingId++;
        }

        public int getBookingId()
        {
            return BookingId;
        }
        public Customer getCustomer()
        {
            return customer;
        }
        public Flight getFlight()
        {
            return flight;
        }
        public override string? ToString()
        {
            string s = "";
            s += "\n--------------// Booking Information //----------------";
            s += "\nBooking_id: " + BookingId;
            s += "\nDate: " + Date;
            s += "\nCustomer id: " + customer.getCustomerId() + "\nCustomer Name: "  + customer.getfullname();
            s += "\nFlight Number: " + flight.getFlightNum() + "\nFlight Date: " + flight.getDateTime() +
                "\nOrigin: "+ flight.getOrigin() + "\nDestination: "+ flight.getDestination() + "\nMaximum Seats: "+ flight.getMaxseats()
                + "\nTotal No. Of Passengers: "+ flight.getNumofPassengers() ;
            return s;
        }



    }
}

