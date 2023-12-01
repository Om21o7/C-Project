using System;
using System.Numerics;

namespace Project
{
    public class Flight
    {
        private int FlightNumber;
        private DateTime DateTime;
        private string Origin;
        private string Destination;
        private int MaximumSeats;
        private int NumberOfPassengers;

        public Flight(int fnumber, DateTime datetime, string origin, string dest, int maxSeats)
        {
            this.FlightNumber = fnumber;
            this.DateTime = datetime;
            this.Origin = origin;
            this.Destination = dest;
            this.MaximumSeats = maxSeats;
        }

        public int getFlightNum()
        {
            return FlightNumber;
        }
        public void setOrigin(string origin)
        {
            this.Origin = origin;
        }
        public string getOrigin()
        {
            return Origin;
        }
        public void setDestination(string dest)
        {
            this.Destination = dest;
        }
        public string getDestination()
        {
            return Destination;
        }
        public int getMaxseats()
        {
            return MaximumSeats;
        }
        public int getNumofPassengers()
        {
            return NumberOfPassengers;
        }
        public void setNumofPassengers(int NumberOfPassengers)
        {
            this.NumberOfPassengers = NumberOfPassengers;
        }
        public DateTime getDateTime()
        {
            return DateTime;
        }

        public override string? ToString()
        {
            string s = "";
            s += "\tFlight Number: " + FlightNumber;
            s += "\tDate: " + DateTime;
            s += "\tOrigin: " + Origin;
            s += "\tDestination: " + Destination;
            s += "\tMaximum Seats: " + MaximumSeats;
            return s;
        }
    }
}

