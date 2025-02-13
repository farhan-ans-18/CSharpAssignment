namespace MobileNumberVerification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Mobile Number: ");
            long mobile = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Alternate Mobile Number: ");
            long alternateMobile = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Landline Number: ");
            long landline = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Email Id: ");
            string  email = Console.ReadLine();
            Console.WriteLine("Enter the Address: ");
            string address = Console.ReadLine();

            try
            {
                ContactDetail cd = new ContactDetail(mobile, alternateMobile, landline, email, address);
                ContactDetailBO bo = new ContactDetailBO();
                bo.Validate(cd);
            }
            catch (DuplicateNumberException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex) 
            { 
                Console.WriteLine(ex.Message);
            }


        }

        class ContactDetail
        {
            public long Mobile { get; set; }
            public long AlternateMobile { get; set; }
            public long Landline { get; set; }
            public string Email { get; set; }
            public string Address { get; set; }

            public ContactDetail(long mobile, long alternateMobile, long landline, string email, string address)
            {
                Mobile = mobile;
                AlternateMobile = alternateMobile;
                Landline = landline;
                Email = email;
                Address = address;
            }

            public override string ToString()
            {
                return $"Contact Details\n" +
                    $"Mobile: {Mobile}\n" +
                    $"Alternate Mobile: {AlternateMobile}\n" +
                    $"LandLine: {Landline}\n" +
                    $"Email Id: {Email}\n" +
                    $"Address: {Address}";
            }
        }

        class ContactDetailBO
        {
            public void Validate(ContactDetail cd)
            {
                if (cd.Mobile == cd.AlternateMobile)
                {
                    throw new DuplicateNumberException("Same Mobile number and Alternate Mobile number");
                }
                else
                {
                    Console.WriteLine(cd.ToString());
                }
            }
        }

        class DuplicateNumberException : Exception
        {
            public DuplicateNumberException(string message) : base(message)
            {

            }
        }
    }
}
