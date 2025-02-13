namespace InvalidDateException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Enter the starting date-time (dd/MM/yyyy hh:mm:ss tt): ");
                DateTime startDateTime = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy hh:mm:ss tt", null);
                Console.WriteLine("Enter the ending date-time (dd/MM/yyyy hh:mm:ss tt): ");
                DateTime endDateTime = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy hh:mm:ss tt", null);

                Console.WriteLine($"StartDateTime: { startDateTime}");
                Console.WriteLine($"EndDateTime: {endDateTime}");
            }
            catch (FormatException ex)
            {
                
                Console.WriteLine("Invalid input");
            }





        }
    }
}
