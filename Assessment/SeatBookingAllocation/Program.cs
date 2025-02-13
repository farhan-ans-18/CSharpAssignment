namespace SeatBookingAllocation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the booking Details");
                string seats = Console.ReadLine();
                Console.WriteLine("Enter the seat number to Book: ");
                int numOfSeats = int.Parse(Console.ReadLine());

                if (seats[numOfSeats - 1].Equals('0'))
                {
                    Console.WriteLine("booked");
                }
                else
                {
                    throw new SeatNotAvailableException("Seat ot Available");
                }
            }
            catch (SeatNotAvailableException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        class SeatNotAvailableException : Exception
        {
            public SeatNotAvailableException(string message) : base(message)
            {
                
            }
        }
    }
}
