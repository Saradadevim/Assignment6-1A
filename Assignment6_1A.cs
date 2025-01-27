using System;
using Assignment6_1A.Model;

namespace Assignment6_1A
{
    internal class Assignment6_1A
    {
        static void Main(string[] args)
        {
            // Create an instance of Account
            Account account = new Account();

            while (true)
            {
                // Display menu options
                Console.WriteLine("\n--- Bank Account Management ---");
                Console.WriteLine("1. Add Customer Details");
                Console.WriteLine("2. Display Customer Details");
                Console.WriteLine("3. Show Account Balance");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        // Add customer details
                        Console.Write("\nEnter Account Number: ");
                        int acNumber = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Account Holder Name: ");
                        string acHolderName = Console.ReadLine();

                        Console.Write("Enter Account Balance: ");
                        double acBalance = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Enter Account Type: ");
                        string acType = Console.ReadLine();

                        Console.Write("Enter Minimum Balance: ");
                        double acMinBalance = Convert.ToDouble(Console.ReadLine());

                        account.AddCustomerDetails(acNumber, acHolderName, acBalance, acType, acMinBalance);
                        break;

                    case "2":
                        // Display customer details
                        account.DisplayCustomerDetails();
                        break;

                    case "3":
                        // Show account balance
                        account.ShowAccountBalance();
                        break;

                    case "4":
                        // Exit the application
                        Console.WriteLine("Exiting...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
