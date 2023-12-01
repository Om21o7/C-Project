using System;
namespace Project
{
    public class BookingManager
    {
        private int numBookings;
        private int maxBookings;
        private Booking[] Bookinglist;
        private CustomerManager cm;
        private FlightManager fm;
        public BookingManager(int max, CustomerManager cm, FlightManager fm)
        {
            this.numBookings = 0;
            this.maxBookings = max;
            Bookinglist = new Booking[max];
            this.cm = cm;
            this.fm = fm;
        }
        public bool addBooking(int CustId, int FlightId)
        {
            Flight f1 = fm.GetFlightbyFlightNumber(FlightId);
            Customer c1 = cm.GetCustomerByCustomerId(CustId);

            if (numBookings < maxBookings)
            {
                if (f1 != null && c1 != null && f1.getNumofPassengers() < f1.getMaxseats())
                {
                    Bookinglist[numBookings] = new Booking(c1, f1);
                    f1.setNumofPassengers(f1.getNumofPassengers() + 1);
                }
                numBookings++;
                c1.getnumbookings();
                Console.WriteLine("The booking is successfully made.");
                return true;
            }
            return false;
        }

        public int SearchBookingbyBookingNumber(int BID)
        {
            for (int i = 0; i < numBookings; i++)
            {
                if (BID == Bookinglist[i].getBookingId())
                {
                    return i;
                }
            }
            return -1;
        }

        public int SearchBookingbyCustomerId(int CustId)
        {
            Customer c1 = cm.GetCustomerByCustomerId(CustId);
            for (int i = 0; i < numBookings; i++)
            {
                if (CustId == Bookinglist[i].getCustomer().getCustomerId())
                {
                    return i;
                }
            }
            return -1;
        }

        public int SearchBookingbyFlightNumber(int FlightNumber)
        {
            Flight f1 = fm.GetFlightbyFlightNumber(FlightNumber);
            for (int i = 0; i < numBookings; i++)
            {
                if (FlightNumber == Bookinglist[i].getFlight().getFlightNum())
                {
                    return i;
                }
            }
            return -1;
        }

        public string ViewBookingbyBookingId(int BookingId)
        {
            if (SearchBookingbyBookingNumber(BookingId) != -1)
            {
                return "Booking Found: \t" + Bookinglist[SearchBookingbyBookingNumber(BookingId)].ToString();
            }
            return "Booking Id not Found";
        }

        public string ViewBookingbyCustomerId(int CustId)
        {
            if (SearchBookingbyCustomerId(CustId) != -1)
            {
                return "Booking Found: \t" + Bookinglist[SearchBookingbyCustomerId(CustId)].ToString();
            }
            return "Booking Id not Found";
        }

        public string ViewBookingbyFlightNumber(int FlightNum)
        {
            if (SearchBookingbyFlightNumber(FlightNum) != -1)
            {
                return "Booking Found: \t" + Bookinglist[SearchBookingbyFlightNumber(FlightNum)].ToString();
            }
            return "Booking Id not Found";
        }

        public string? ViewAllBooking()
        {
            string s = "List of Bookings\n";
            for (int x = 0; x < numBookings; x++)
            {
                s = s + "\n" + Bookinglist[x].ToString();
                s = s + "\n";

            }
            return s;
        }
        public void DeleteBooking(int BookingId)
        {
            if (SearchBookingbyBookingNumber(BookingId) != -1)
            {
                for (int i = 0; i < numBookings; i++)
                {
                    Bookinglist[i] = Bookinglist[i + 1];
                }
                numBookings--;
                Console.WriteLine("Booking Deleted");
            }
            Console.WriteLine("Booking not deleted");
        }

    }
}