namespace AccountDetails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter User Details(HolderName, AccountNumber, IFSC code, Contact Number)");
            string name = Console.ReadLine();
            long accountNum = long.Parse(Console.ReadLine());
            string ifsc = Console.ReadLine();
            long contactNum = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter Account Type");
            string accType = Console.ReadLine().ToLower();

            if(accType == "saving")
            {
                Console.WriteLine("Enter Interest Rate: ");
                double intRate = double.Parse(Console.ReadLine());
                SavingAccount s1 = new SavingAccount(name, accountNum, ifsc, contactNum, intRate);
                s1.Display();
            } else if(accType == "current")
            {
                Console.WriteLine("Enter Organization Name:");
                string orgName = Console.ReadLine();
                Console.WriteLine("Enter TIN number: ");
                int tin = int.Parse(Console.ReadLine());

                CurrentAccount c1 = new CurrentAccount(name, accountNum, ifsc, contactNum, orgName, tin);
                c1.Display();
            }

        }

        class Account
        {
            string holderName;
            long accountNumber;
            string IFSCCode;
            long contactNumber;

            public Account(string holderName, long accountNumber, string IFSCCode, long contactNumber)
            {
                this.holderName = holderName;
                this.accountNumber = accountNumber;
                this.IFSCCode = IFSCCode;
                this.contactNumber = contactNumber;
            }

            public virtual void Display()
            {
                Console.WriteLine("****Your Contact Detaisl****");
                Console.WriteLine($"Holder Name : {holderName} \n Account Number : {accountNumber} \n IFSC CODE: {IFSCCode} \n Contact Number: {contactNumber}");
            }
        }

        class SavingAccount : Account
        {
            double interestRate;
            public SavingAccount(string holderName, long accountNumber, string IFSCCode, long contactNumber, double interestRate) : base(holderName, accountNumber, IFSCCode, contactNumber)
            {
                this.interestRate = interestRate;
            }

    
                public override void Display()
            {
                base.Display();
                Console.WriteLine($"Interest Rate is {interestRate}");
            }

        }

        class CurrentAccount : Account
        {
            string organizationName;
            long TIN;
            public CurrentAccount(string holderName, long accountNumber, string IFSCCode, long contactNumber, string organizationName, long TIN) : base(holderName, accountNumber, IFSCCode, contactNumber)
            {
                this .organizationName = organizationName;
                this .TIN = TIN;
            }

            public override void Display()
            {
                base.Display();
                Console.WriteLine($"\n Orgaization Name : {organizationName} \n TIN: {TIN}");
            }

        }
    }
}
