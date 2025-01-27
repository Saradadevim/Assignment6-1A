using System;

namespace Assignment6_1A.Model
{
    public class Account
    {
        // Private fields
        private int _acNumber;
        private string _acHolderName;
        private double _acBalance;
        private string _acType;
        private double _acMinBalance;

        // Properties with appropriate accessors
        public int AcNumber
        {
            get { return _acNumber; }
            set { _acNumber = value; }
        }

        public string AcHolderName
        {
            get { return _acHolderName; }
            set { _acHolderName = value; }
        }

        public double AcBalance
        {
            get { return _acBalance; }
            set { _acBalance = value; }
        }

        public string AcType
        {
            get { return _acType; }
            set { _acType = value; }
        }

        public double AcMinBalance
        {
            get { return _acMinBalance; }
            set { _acMinBalance = value; }
        }

        // Default constructor
        public Account()
        {
        }

        // Parameterized constructor
        public Account(int acNumber, string acHolderName, double acBalance, string acType, double acMinBalance)
        {
            _acNumber = acNumber;
            _acHolderName = acHolderName;
            _acBalance = acBalance;
            _acType = acType;
            _acMinBalance = acMinBalance;
        }

        // Method to add customer details
        public void AddCustomerDetails(int acNumber, string acHolderName, double acBalance, string acType, double acMinBalance)
        {
            _acNumber = acNumber;
            _acHolderName = acHolderName;
            _acBalance = acBalance;
            _acType = acType;
            _acMinBalance = acMinBalance;
            Console.WriteLine("\nCustomer details added successfully.");
        }

        // Method to display customer details
        public void DisplayCustomerDetails()
        {
            Console.WriteLine("\n--- Customer Details ---");
            Console.WriteLine($"Account Number: {_acNumber}");
            Console.WriteLine($"Account Holder Name: {_acHolderName}");
            Console.WriteLine($"Account Balance: {_acBalance}");
            Console.WriteLine($"Account Type: {_acType}");
            Console.WriteLine($"Minimum Balance: {_acMinBalance}");
        }

        // Method to show account balance
        public void ShowAccountBalance()
        {
            Console.WriteLine($"\nAccount Balance: {_acBalance}");
        }
    }
}
