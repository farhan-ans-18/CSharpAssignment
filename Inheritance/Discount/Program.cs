using System.Net;
using System.Xml.Linq;

namespace Discount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Previlege Customer");
            Console.WriteLine("2. Senior Citizen");
            Console.WriteLine("Enter Customer Type: ");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter The Age:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Address:");
            string address = Console.ReadLine();
            Console.WriteLine("Enter The MobileNUmber:");
            string number = Console.ReadLine();
            Console.WriteLine("Enter The Purchased Amount:");
            int amount = int.Parse(Console.ReadLine());

            if (choice == 1)
            { 
                PrivilegeCustomer p = new PrivilegeCustomer(name, address, number, age);
                p.DisplayCustomer();
                double discount = p.GenerateBillAmount(amount);
                Console.WriteLine("You are Previlage Customer !");
                Console.WriteLine($"Your bill amount is Rs {amount} and you have to pay Rs {discount} ");
            }
            else if (choice == 2)
            {
                SeniorCitizenCustomer s = new SeniorCitizenCustomer(name, address, number, age);
                s.DisplayCustomer();
                double discount = s.GenerateBillAmount(amount);
                Console.WriteLine("You are Senior Citizen Customer !");
                Console.WriteLine($"Your bill amount is Rs {amount} and you have to pay Rs {discount} ");
            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }
        }
    }

    class Customer
    {
        string _name;
        string _address;
        string _mobileNumber;
        int _age;

        public Customer(string _name, string _address, string _mobileNumber, int _age)
        {
            this._name = _name;
            this._address = _address;
            this._mobileNumber = _mobileNumber;
            this._age = _age;
        }

        public void DisplayCustomer()
        {
            Console.WriteLine("*******Customers Details**********");
            Console.WriteLine($"Name: {_name} \n Addresss: {_address} \n Mobile Number: {_mobileNumber} \n Age: {_age}");
            Console.WriteLine("************************8**********");
        }
    }

    class SeniorCitizenCustomer : Customer
    {
        public SeniorCitizenCustomer(string _name, string _address, string _mobileNumber, int _age) : base(_name, _address, _mobileNumber, _age)
        {

        }

        public double GenerateBillAmount(int amount)
        {
            return amount * 0.12;
        }


    }

    class PrivilegeCustomer : Customer
    {
        public PrivilegeCustomer(string _name, string _address, string _mobileNumber, int _age) : base(_name, _address, _mobileNumber, _age)
        {

        }

        public double GenerateBillAmount(int amount)
        {
            return amount * 0.3;
        }
    }


}