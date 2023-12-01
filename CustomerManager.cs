using System;
namespace Project
{
    public class CustomerManager
    {
 
        private int numCustomers;
        private int maxCustomers;
        private Customer[] CustomerList;
        public CustomerManager(int maxCustomers)
        {
            this.numCustomers = 0;
            this.maxCustomers = maxCustomers;
            CustomerList = new Customer[maxCustomers];
        }

        public bool addCustomer(string fname, string lname, string phone)
        {
            if (numCustomers < maxCustomers && !IsCustomerExist(fname, lname, phone))
            {
                CustomerList[numCustomers] = new Customer(fname, lname, phone);
                numCustomers++;
                Console.WriteLine("Customer Added with ID: " + CustomerList[numCustomers - 1].getCustomerId());
                return true;
            }
            else if(numCustomers > maxCustomers)
            {
                Console.WriteLine("Can not add the customer, no space left");
                return true;
            }
            else
            {
                Console.WriteLine("Cannot add the Customer. Customer with the same details already exists.");
                return false;
            }
        }

        private bool IsCustomerExist(string fname, string lname, string phone)
        {
            foreach (Customer customer in CustomerList)
            {
                if (customer != null && customer.getfname().Equals(fname, StringComparison.OrdinalIgnoreCase) &&
                    customer.getlname().Equals(lname, StringComparison.OrdinalIgnoreCase) &&
                    customer.getphone().Equals(phone, StringComparison.OrdinalIgnoreCase))
                {
                    return true; // Customer with the same details already exists
                }
            }
            return false; // Customer does not exist with the same details
        }
        public Customer GetCustomerByCustomerId(int CustId)
        {
            if (SearchCustomerbyId(CustId) != -1)
            {
                return CustomerList[SearchCustomerbyId(CustId)];
            }
            return null;
        }
        private int SearchCustomerbyPhone(string phone)
        {
            for (int i = 0; i < numCustomers; i++)
            {
                if (phone == CustomerList[i].getphone())
                {
                    return i;
                }
            }
            return -1;
        }

        public int SearchCustomerbyId(int Id)
        {
            for (int i = 0; i < numCustomers; i++)
            {
                if (Id == CustomerList[i].getCustomerId())
                {
                    return i;
                }
            }
            return -1;
        }

        

        public string? ViewCustomerbyPhone(string phone)
        {
            if (SearchCustomerbyPhone(phone) != -1)
            {
                return CustomerList[SearchCustomerbyPhone(phone)].ToString();
            }
            return "Customer not found...";
        }

        public string? ViewCustomerbyId(int Id)
        {
            if (SearchCustomerbyId(Id) != -1)
            {
                return CustomerList[SearchCustomerbyId(Id)].ToString();
            }
            return "Customer not found...";
        }

        public string? ViewCustomerbyFname(string fname)
        {
            string s = "";
            for(int i=0; i < numCustomers; i++)
            {
                if(fname == CustomerList[i].getfname())
                {
                    s += CustomerList[i];
                }

            }
            return s;
        }

        public string? ViewCustomerbyLname(string lname)
        {
            string s = "";
            for (int i = 0; i < numCustomers; i++)
            {
                if (lname == CustomerList[i].getlname())
                {
                    s += CustomerList[i];
                }

            }
            return s;
        }

        public void DeleteCustomer(int Id)
        {
            if (SearchCustomerbyId(Id) != -1)
            {

                for (int a = SearchCustomerbyId(Id); a < numCustomers - 1; a++)
                {
                    CustomerList[a] = CustomerList[a + 1];

                }
                numCustomers--;
                Console.WriteLine("Customer Deleted");
            }
            else
            {
                Console.WriteLine("Cant Delete the Customer.");
            }

        }


        public string ViewAllCustomer()
        {
            string s = "----------- List of Customers ------------\n";
            for (int x = 0; x < numCustomers; x++)
            {
                s = s + "\n" + CustomerList[x].ToString();
                s = s + "\n";

            }
            return s;
        }


    }
}




