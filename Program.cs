using System.Globalization;
using Project;

public class Program
{
    static void PrintMainMenu()
    {
       
        Console.WriteLine("XYZ AirLines Limited");
        Console.WriteLine("Please Select a choice from the menu Below");
        Console.WriteLine("1:Customers");
        Console.WriteLine("2:Flights");
        Console.WriteLine("3:Bookings");
        Console.WriteLine("4:Exit\n");
    }
    public static void AddRandomData(CustomerManager cm, FlightManager fm)
    {
        // Add random customers
        cm.addCustomer("John", "Doe", "123456789");
        cm.addCustomer("Jane", "Smith", "987654321");
        cm.addCustomer("Alice", "Johnson", "5551234567");
        cm.addCustomer("Bob", "Williams", "7890123456");
        cm.addCustomer("Eva", "Taylor", "4567890123");
        cm.addCustomer("David", "Anderson", "3216549870");
        cm.addCustomer("Sophia", "Miller", "8765432109");
        cm.addCustomer("Michael", "Jones", "2345678901");
        cm.addCustomer("Olivia", "White", "6789012345");
        cm.addCustomer("William", "Brown", "8901234567");

        // Add random flights
        DateTime now = DateTime.Now;

        fm.addFlight(101, now.AddHours(1), "New York", "Los Angeles", 2);
        fm.addFlight(102, now.AddHours(2), "Chicago", "Miami", 120);
        fm.addFlight(103, now.AddHours(3), "San Francisco", "Seattle", 180);
        fm.addFlight(104, now.AddHours(4), "Denver", "Houston", 130);
        fm.addFlight(105, now.AddHours(5), "Boston", "Atlanta", 160);
        fm.addFlight(106, now.AddHours(6), "Dallas", "Phoenix", 140);
        fm.addFlight(107, now.AddHours(7), "Las Vegas", "Orlando", 170);
        fm.addFlight(108, now.AddHours(8), "Detroit", "Minneapolis", 110);
        fm.addFlight(109, now.AddHours(9), "Philadelphia", "San Diego", 200);
        fm.addFlight(110, now.AddHours(10), "Portland", "Austin", 190);
    }



    static void PrintCustomerMenu()
    {
        Console.WriteLine("XYZ AirLines Limited");
        Console.WriteLine("Customer Menu");
        Console.WriteLine("Please Select a choice from the menu Below");
        Console.WriteLine("1:Add Customer");
        Console.WriteLine("2:View Customer");
        Console.WriteLine("3:Delete Customer");
        Console.WriteLine("4:Back to main menu");
    }

    static void PrintFlightMenu()
    {
        Console.WriteLine("XYZ AirLines Limited");
        Console.WriteLine("Flight Menu");
        Console.WriteLine("Please Select a choice from the menu Below\n");
        Console.WriteLine("1:Add Flight");
        Console.WriteLine("2:View Flights");
        Console.WriteLine("3.Remove Flght");
        Console.WriteLine("4:Back to main menu");
    }
    static void PrintBookingMenu()
    {
        Console.WriteLine("\nXYZ AirLines Limited");
        Console.WriteLine("Booking Menu");
        Console.WriteLine("Please Select a choice from the menu Below\n");
        Console.WriteLine("1:Make Booking");
        Console.WriteLine("2:View Booking");
        Console.WriteLine("3:Back to main menu");
    }

    static void PrintViewCustomerMenu()
    {
        Console.WriteLine("\nCustomer View Menu");
        Console.WriteLine("Please select the view option from below choices");
        Console.WriteLine("1.View All Customers");
        Console.WriteLine("2.View Customer by Id");
        Console.WriteLine("3.View Customer by First name");
        Console.WriteLine("4.View Customer by Last name");
        Console.WriteLine("5.View Customer by Phone Number");
        Console.WriteLine("6.Back to The Customer Menu");
    }

    static void PrintViewFlightMenu()
    {
        Console.WriteLine("\nFlight View Menu");
        Console.WriteLine("Please select the view option from below choices");
        Console.WriteLine("1.View All Flights ");
        Console.WriteLine("2.View Flight by FlightNumber");
        Console.WriteLine("3.View Flight by Origin");
        Console.WriteLine("4.View Flight by Destination");
        Console.WriteLine("5.Back to The Flight Menu");
    }

    public void Datefunc()
    {

    }
  
    public static void Main(String[] args)
    {
        CustomerManager cm = new CustomerManager(1000);
        FlightManager fm = new FlightManager(1000);
        BookingManager bm = new BookingManager(1000, cm, fm);
        AddRandomData(cm, fm);
        while (true)
        {
            Console.Clear();
            PrintMainMenu();
            Console.Write("Enter your choice: ");
            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":


                    while (true)
                    {
                        PrintCustomerMenu();
                        Console.Write("Enter your choice: ");
                        string? option = Console.ReadLine();
                        if (option == "4") { break; }

                        switch (option)
                        {
                            case "1":
                              
                                Console.WriteLine("\nEnter The Details of the Following : ");
                                Console.WriteLine("\nEnter First Name");
                                string? fname = Console.ReadLine();
                                Console.WriteLine("\nEnter Last Name");
                                string? lname = Console.ReadLine();
                                Console.WriteLine("\nEnter Phone Number");
                                string? phone = Console.ReadLine();

                                if (fname != null && lname != null && phone != null)
                                {
                                    cm.addCustomer(fname,lname,phone);
                                    //Customer C = new Customer(fname, lname, phone);
                                    //cm.addCustomer(C.getfname(), C.getlname(), C.getphone());
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input. Please make sure to enter values for all fields.");
                                }
                                break;

                            case "2":
                                while (true)
                                {
                                    Console.Clear();
                                    PrintViewCustomerMenu();
                                    Console.WriteLine("Enter your choice");
                                    string? op = Console.ReadLine();
                                    if (op == "6") { break; }


                                    switch (op)
                                    {

                                        case "1":
                                            Console.Clear();
                                            string vc = cm.ViewAllCustomer();
                                            Console.WriteLine(vc);
                                            Console.WriteLine("Press any key to continue ");
                                            Console.ReadKey();

                                            break;

                                        case "2":
                                            Console.Clear();
                                            Console.WriteLine("Search Customer by Id");
                                            Console.WriteLine("Enter Id of the Customer");

                                            // Use Console.ReadLine() to read the entire line as a string
                                            string? inputId = Console.ReadLine();

                                            // Parse the string input into an integer
                                            if (int.TryParse(inputId, out int CID))
                                            {
                                                string ci = cm.ViewCustomerbyId(CID);
                                                Console.WriteLine(ci);
                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid input. Please enter a valid integer for Customer Id.");
                                            }
                                            Console.WriteLine("Press any key to continue ");
                                            Console.ReadKey();
                                            break;

                                        case "3":
                                            Console.WriteLine("Search Customer by First Name");
                                            Console.WriteLine("Enter First Name of the Customer");
                                            string? firstname = Console.ReadLine();
                                            string? fn = cm.ViewCustomerbyFname(firstname);
                                            Console.WriteLine(fn);
                                            break;

                                        case "4":
                                            Console.WriteLine("Search Customer by Last Name");
                                            Console.WriteLine("Enter Last Name of the Customer");
                                            string? lastname = Console.ReadLine();
                                            string? ln = cm.ViewCustomerbyLname(lastname);
                                            Console.WriteLine(ln);
                                            break;

                                        case "5":
                                            Console.WriteLine("!!--- Search Customer by Phone ---!! ");
                                            Console.WriteLine("Enter Phone of the Customer");
                                            string? p = Console.ReadLine();
                                            string? pn = cm.ViewCustomerbyPhone(p);
                                            Console.WriteLine(pn);
                                            break;

                                        default:
                                            Console.WriteLine("Invalid choice. Please try again.");
                                            break;

                                    }

                                }
                                break;


                            case "3":
                                Console.WriteLine("Enter the id of the Customer you want to delete:");
                                int id = Console.Read();
                                cm.DeleteCustomer(id);
                                break;

                            case "4":
                                break;
                            default:
                                Console.WriteLine("Invalid choice. Please try again.");
                                break;

                        }



                    }
                    break;


                case "2":
                    while (true)
                    {
                       
                        PrintFlightMenu();
                        string? option = Console.ReadLine();
                        Console.Write("Enter your choice: ");
                        if (option == "4") { break; }

                        switch (option)
                        {
                            case "1":
                                Console.WriteLine("\n ----------- Add Flight -----------");
                                Console.WriteLine("\nEnter Flight Number:");
                                if (!int.TryParse(Console.ReadLine(), out int flightNum))
                                {
                                    Console.WriteLine("Invalid Flight Number. Please enter a valid integer.");
                                    break;
                                }

                                bool isValidDateTime = false;
                                DateTime datetime = DateTime.MinValue;

                                while (!isValidDateTime)
                                {
                                    Console.WriteLine("Enter the DateTime of the Flight in the format of MM/dd/yyyy HH:mm:ss");
                                    string? datetimeInput = Console.ReadLine();

                                    if (string.IsNullOrWhiteSpace(datetimeInput))
                                    {
                                        Console.WriteLine("Please enter a valid DateTime.");
                                        continue;  // Restart the loop
                                    }

                                    if (DateTime.TryParseExact(datetimeInput, "MM/dd/yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out datetime))
                                    {
                                        // Valid DateTime input
                                        isValidDateTime = true;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid DateTime format. Please enter the correct format.");
                                    }
                                }

                                Console.WriteLine("Enter Origin");
                                string? origin = Console.ReadLine();
                                Console.WriteLine("Enter Destination");
                                string? destination = Console.ReadLine();
                                Console.WriteLine("Enter Maximum Seats");

                                if (int.TryParse(Console.ReadLine(), out int maxseats))
                                {
                                    Flight F = new Flight(flightNum, datetime, origin, destination, maxseats);
                                    fm.addFlight(F.getFlightNum(), F.getDateTime(), F.getOrigin(), F.getDestination(), F.getMaxseats());
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input for Maximum Seats. Please enter a valid integer.");
                                }
                                break;


                            case "2":
                                while (true)
                                {
                                    PrintViewFlightMenu();
                                    Console.WriteLine("Enter your choice");
                                    string? op = Console.ReadLine();
                                    if (op == "5") { break; }

                                    switch (op)
                                    {
                                        case "1":
                                            Console.Clear();
                                            string a = fm.ViewAllFlights();
                                            Console.WriteLine(a);
                                            break;
                                        case "2":
                                            Console.WriteLine("Enter Number of the Flight");

                                            // Use Console.ReadLine() to read the entire line as a string
                                            string? inputId = Console.ReadLine();

                                            // Parse the string input into an integer
                                            if (int.TryParse(inputId, out int FID))
                                            {
                                                string? ci = fm.ViewFlightbyParticularFlightbyId(FID);
                                                Console.WriteLine(ci);
                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid input. Please enter a valid integer for FlightNum.");
                                            }
                                            break;
                                        case "3":
                                            Console.WriteLine("Enter Origin of the Flight");
                                            string? ori = Console.ReadLine();
                                            string? ln = fm.ViewFlightbyParticularOrigin(ori);
                                            Console.WriteLine(ln);
                                            break;
                                        case "4":
                                            Console.WriteLine("Enter Destination of the Flight");
                                            string? d = Console.ReadLine();
                                            string? pn = fm.ViewFlightbyParticularDestination(d);
                                            Console.WriteLine(pn);
                                            break;
                                        default:
                                            Console.WriteLine("Invalid choice. Please try again.");
                                            break;
                                    }
                                }


                                break;

                            case "3":
                                Console.Clear();
                                Console.WriteLine("Enter the flight number you want to remove:");
                                if (int.TryParse(Console.ReadLine(), out int flnum))
                                {
                                    fm.DeleteFlight(flnum);
                                }
                                else
                                {
                                    Console.WriteLine("Invalid flight number. Please enter a valid integer.");
                                }
                                break;

                            default:
                                Console.WriteLine("Invalid choice. Please try again.");
                                break;
                        }
                    }
                    break;


                case "3":
                    while (true)
                    {
                      
                        PrintBookingMenu();
                        string? option = Console.ReadLine();
                        Console.Write("Enter your choice: ");
                        if (option == "3") { break; }

                        switch (option)
                        {
                            case "1":

                                string a = fm.ViewAllFlights();
                                Console.WriteLine(a);
                                string vc = cm.ViewAllCustomer();
                                Console.WriteLine(vc);
                                Console.WriteLine("Enter the Customer Id");
                                int Cid;
                                if (int.TryParse(Console.ReadLine(), out Cid))
                                {
                                    Console.WriteLine("Enter the Flight Number");
                                    int Fid;
                                    if (int.TryParse(Console.ReadLine(), out Fid))
                                    {
                                        bm.addBooking(Cid, Fid);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid Flight Number. Please enter a valid integer.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Invalid Customer Id. Please enter a valid integer.");
                                }
                                break;

                            case "2":
                                Console.Clear();
                                string cma = bm.ViewAllBooking();
                                Console.WriteLine(cma);
                                break;

                            case "3":
                                Console.Clear();
                                Console.WriteLine("Enter Booking Id you want to delete");
                                if (int.TryParse(Console.ReadLine(), out int bookingId))
                                {
                                    bm.DeleteBooking(bookingId);
                                }
                                else
                                {
                                    Console.WriteLine("Invalid Booking Id. Please enter a valid integer.");
                                }
                                break;

                        }
                    }
                    break;


                case "4":

                    Environment.Exit(0);
                    break;

            }
        }
    }

}
