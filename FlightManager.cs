using System;
namespace Project
{
    public class FlightManager
    {
        private int numFlights;
        private int maxFlights;
        private Flight[] FlightList;

        public FlightManager(int maxFlights)
        {
            this.numFlights = 0;
            this.maxFlights = maxFlights;
            FlightList = new Flight[maxFlights];
        }

        public bool addFlight(int fnumber, DateTime DateTime, string origin, string dest, int maxSeats)
        {

            if (numFlights < maxFlights)
            {
                FlightList[numFlights] = new Flight(fnumber, DateTime, origin, dest, maxSeats);
                numFlights++;
                Console.WriteLine("Flight Added");
                return true;
            }
            return false;
        }

        public int SearchFlightbyFnumber(int fnumber)
        {
            for (int i = 0; i < numFlights; i++)
            {
                if (fnumber == FlightList[i].getFlightNum())
                {
                    return i;
                }
            }
            return -1;
        }

        public int SearchFlightbyDate(DateTime dt)
        {
            for (int i = 0; i < numFlights; i++)
            {
                if (DateTime.Compare(dt, FlightList[i].getDateTime()) == 0)
                {
                    return i;
                }
            }
            return -1;
        }

        public Flight GetFlightbyFlightNumber(int FlightNumber)
        {
            if (SearchFlightbyFnumber(FlightNumber) != -1)
            {
                return FlightList[SearchFlightbyFnumber(FlightNumber)];
            }
            return null;
        }
        public string ViewAllFlights()
        {
            string s = "------------- List of Flights ----------------\n";
            for (int x = 0; x < numFlights; x++)
            {
                s = s + "\n" + FlightList[x].ToString();
                s = s + "\n";

            }
            return s;
        }


        public string? ViewFlightbyParticularOrigin(string origin)
        {
            string s = " ";
            for(int i = 0; i < numFlights; i++)
            {
                if(origin == FlightList[i].getOrigin())
                {
                    s += FlightList[i];
                }
            }
            return s;
        }

        public string? ViewFlightbyParticularDestination(string origin)
        {
            string s = " ";
            for (int i = 0; i < numFlights; i++)
            {
                if (origin == FlightList[i].getDestination())
                {
                    s += FlightList[i];
                }
            }
            return s;
        }


        public string? ViewFlightbyParticularFlightbyId(int fnumber)
        {
            if (SearchFlightbyFnumber(fnumber) != -1)
            {
                return FlightList[SearchFlightbyFnumber(fnumber)].ToString();
            }
            return "No such Flight found.";
        }


        public void DeleteFlight(int fnumber)
        {
            if (SearchFlightbyFnumber(fnumber) != -1)
            {
                for (int a = SearchFlightbyFnumber(fnumber); a < numFlights; a++)
                {
                    FlightList[a] = FlightList[a + 1];
                }
                numFlights--;
                Console.WriteLine("Flight deleted");
            }

        }




    }
}

