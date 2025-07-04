using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Customer_relationship_management
{
    internal class Program
    {
        #region Arrays
        #region Customer Arrays
        static int[] customerId = new int[20];
        static string[] customerName = new string[20];
        static string[] customerEmail = new string[20];
        static string[] customerphone = new string[20];

        #endregion

        #region Representative Arrays    
        static int[] assignedRepresentativeId = new int[20];
        static int[] representativeId = { 101, 102, 103 };
        static string[] representativeName = { "Ayşe YILMAZ", "Can DEMİR", "Elif KAYA" };
        #endregion

        #region Communication Arrays
        static string[] contactDates = new string[3];
        static string[] communicationTypes = new string[3];
        static string[] communicationDescriptions = new string[3];
        static int[] contactCustomerId = new int[20];
        #endregion
        #endregion
        static int customerNumber = 0;
        static int contactNumber = 0;
        static void Main(string[] args)
        {
            #region * Title
            string title = "Customer Relatıonshıp Management System CRM".ToUpper();
            int consoleWidht = Console.WindowWidth;
            int textLenght = title.Length;
            int average = (consoleWidht - textLenght) / 2;
            int cursortop = Console.CursorTop;
            Console.SetCursorPosition(average, cursortop);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(title);
            string title2 = "********************************************";
            int consoleWidht2 = Console.WindowWidth;
            int textLenght2 = title2.Length;
            int average2 = (consoleWidht2 - textLenght2) / 2;
            int cursortop2 = Console.CursorTop;
            Console.SetCursorPosition(average2, cursortop2 + 1);
            Console.WriteLine(title2);
            Console.ResetColor();
            #endregion

            #region Main Menü
            while (true)
            {
                Console.WriteLine("\n");
                Console.WriteLine("1. New Customer Add");
                Console.WriteLine("2. List Customers(With Representative Information)");
                Console.WriteLine("3. Update Customer Information");
                Console.WriteLine("4. Add Customer Contact Record");
                Console.WriteLine("5. View Customer's Communication History");
                Console.WriteLine("6. Search Customer (By Name)");
                Console.WriteLine("7. Exit");
                Console.WriteLine("\n");
                string vote = Console.ReadLine()!;
                int vote2;
                if (int.TryParse(vote, out vote2))
                {
                    switch (vote2)
                    {
                        case 1:
                            NewCustomerAdd();
                            break;
                        case 2:
                            ListCustomers();
                            break;
                        case 3:
                            UpdateCustomerInformation();
                            break;
                        case 4:

                            break;
                        case 5:

                            break;
                        case 6:

                            break;
                        case 7:
                            Console.WriteLine("Thank you for using our CRM system. Goodbye!");
                            PressAnyKeytoContinue();
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("You have made an incorrect keystroke. Please try again.");
                            PressAnyKeytoContinue();
                            break;
                    }

                }
                else
                {

                    Console.WriteLine("You have made an incorrect keystroke. Please try again.");
                    PressAnyKeytoContinue();
                }
            }
            #endregion

        }
        #region -- Press Any Key to Continue Method --
        static void PressAnyKeytoContinue()
        {
            Console.WriteLine("Press Any Key to Continue");
            Console.ReadKey();
        }
        #endregion 

        #region -- 1. New Customer Add Method --
        static void NewCustomerAdd()
        {
            if (customerNumber >= 20)
            {
                Console.WriteLine("Customer capacity is full, no more customers can be added!");
                PressAnyKeytoContinue();
                return;
            }
            else
            { 
                customerId[customerNumber] = customerNumber + 1000;
                Console.Write("\nEnter Your Name: ");
                string name = Console.ReadLine()!;
                Console.Write("Enter Your E-Mail: ");
                string email = Console.ReadLine()!;
                Console.Write("Enter Your Phone Number: ");
                string customerPhoneNumber = Console.ReadLine()!;           
                Console.WriteLine("");
                for (int i = 0; i < representativeId.Length; i++)
                {
                    int id = representativeId[i];
                    string ad = representativeName[i];
                    Console.WriteLine((i + 1) + ". " + id + " " + ad);
                }
                Console.WriteLine("Choose a Representative");
                string vote = Console.ReadLine()!;
                int vote2;
                if (int.TryParse(vote, out vote2))
                {
                    switch (vote2)
                    {
                        case 1:
                            Console.WriteLine("Selected Representative: " + representativeId[0] + " " + representativeName[0]);
                            assignedRepresentativeId[customerNumber] = representativeId[0];
                            break;
                        case 2:
                            Console.WriteLine("Selected Representative: " + representativeId[1] + " " + representativeName[1]);
                            assignedRepresentativeId[customerNumber] = representativeId[1];
                            break;
                        case 3:
                            Console.WriteLine("Selected Representative: " + representativeId[2] + " " + representativeName[2]);
                            assignedRepresentativeId[customerNumber] = representativeId[2];
                            break;
                        default:
                            Console.WriteLine("You have made an incorrect keystroke. Please try again.");
                            PressAnyKeytoContinue();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("You have made an incorrect keystroke. Please try again.");
                    PressAnyKeytoContinue();
                }
                customerName[customerNumber] = name;
                customerEmail[customerNumber] = email;
                customerphone[customerNumber] = customerPhoneNumber;
                Console.WriteLine("Customer added successfully! Customer ID: [" + customerId[customerNumber] + "]");
                customerNumber++;
                PressAnyKeytoContinue();
                Console.Clear();
               

            }
        }
        #endregion

        #region -- 2. List Customers --
        static void ListCustomers() 
        {
            if (customerNumber == 0) 
            {
                Console.WriteLine("There are no customers registered in the system yet.");
                PressAnyKeytoContinue();
                return;
            }
            else 
            {
                for (int i=0;i<customerNumber;i++) 
                {
                    int assignedRepresentative = assignedRepresentativeId[i];
                    int rrepresentativeid = representativeId[i];
                    string repname = representativeName[i];
                    Console.WriteLine("\n"+(i+1) + "No'lu Müşteri");
                    Console.WriteLine("\n");
                    Console.WriteLine("Customer ID: " + customerId[i]);
                    Console.WriteLine("Customer Name: "+ customerName[i]);
                    Console.WriteLine("Customer E-Mail: "  + customerEmail[i]);
                    Console.WriteLine("Customer Phone Number: " + customerphone[i]);
                    Console.WriteLine("Representative : " + representativeName[i]);
                    PressAnyKeytoContinue();
                    Console.Clear();
                }
            }
        }
        #endregion

        #region 3. Update Customer Information
        static void UpdateCustomerInformation() 
        {
            if (customerNumber == 0) 
            {
                Console.WriteLine("There is no customer record to update.");
                PressAnyKeytoContinue();
                Console.Clear();
                return;
            }
            else 
            {
                Console.WriteLine("Customer ID to be updated:");
                string update = Console.ReadLine()!;
                int update2;
                if (int.TryParse(update ,out update2)) 
                {
                    bool enteredId = customerId.Contains(update2);
                    if (enteredId) 
                    {
                        Console.WriteLine("What Information Do You Want to Update?");
                        Console.WriteLine("1. Name ");
                        Console.WriteLine("2. E-Mail ");
                        Console.WriteLine("3. Phone Number ");
                        Console.WriteLine("4. Assigned Representative");
                        string vote = Console.ReadLine()!;
                        int vote2;
                        int customerIndex = Array.IndexOf(customerId,update2);
                        if(int.TryParse(vote, out vote2)) 
                        {
                            switch (vote2)
                            {
                                case 1:
                                    Console.WriteLine("Enter New Name: ");
                                    string newName = Console.ReadLine()!;
                                    customerName[customerIndex] = newName;
                                    break;
                                case 2:
                                    Console.WriteLine("Enter New E-Mail: ");
                                    string newEmail = Console.ReadLine()!;
                                    customerEmail[customerIndex] = newEmail;
                                    break;
                                case 3:
                                    Console.WriteLine("Enter New Phone Number: ");
                                    string newPhoneNumber = Console.ReadLine()!;
                                    customerphone[customerIndex] = newPhoneNumber;
                                    break;
                                case 4:
                                    for (int i=0;i<representativeId.Length;i++) 
                                    {
                                        Console.WriteLine((i+1)+"- " + representativeName[i] +" " +representativeId[i]);                  
                                    }
                                    Console.WriteLine("Select:");
                                    string newAssignedRepresent = Console.ReadLine()!;
                                    int newAssignedRepresentt;
                                    if (int.TryParse(newAssignedRepresent, out newAssignedRepresentt))
                                    {
                                        int selectedRepresen = newAssignedRepresentt - 1;
                                        assignedRepresentativeId[customerNumber] = selectedRepresen;
                                    }
                                    else
                                    {
                                        Console.WriteLine("You have made an incorrect keystroke. Please try again.");
                                        PressAnyKeytoContinue();
                                        return;
                                    }
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("You have made an incorrect keystroke. Please try again.");
                            PressAnyKeytoContinue();
                            return;
                        }
                    }
                    else 
                    {
                        Console.WriteLine("Customer not found!");
                        PressAnyKeytoContinue();
                        return;
                    }
                }
                else 
                {
                    Console.WriteLine("You have made an incorrect keystroke. Please try again.");
                    PressAnyKeytoContinue();
                    return;
                }
            }
        }
        #endregion
    }
}
