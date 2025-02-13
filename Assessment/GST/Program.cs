namespace GST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter event name");
            string eName = Console.ReadLine();
            Console.WriteLine("Enter the cost per day");
            double cost = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of Days");
            int noOfDays = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the type of event \n 1.Exhibition\n2.StageEvent");
            int type = int.Parse(Console.ReadLine());
     
            if (type == 1)
            {
                Console.WriteLine("Enter the number of stalls");
                int noOfStalls = int.Parse(Console.ReadLine());
                Exhibition e1 = new Exhibition(eName,type,cost,noOfDays, noOfStalls);
                e1.display();
            } else if(type == 2)
            {
                Console.WriteLine("Enter the number of seats");
                int noOfSeats = int.Parse(Console.ReadLine());
                StageEvent e1 = new StageEvent(eName, type, cost, noOfDays, noOfSeats);
                e1.display();
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }

        class Event
        {
            public string name;
            public string type;
            public double costPerDay;
            public int noOfDays;
            public Event(string name, int type, double costPerDay, int noOfDays){
                this.name = name;
                this.type = (type == 1) ? "Exhibition":"Stage Event";
                this.costPerDay = costPerDay;
                this.noOfDays = noOfDays;
            }
        }

        class Exhibition : Event
        {
            static int gst = 5;
            int noOfStalls;
            public Exhibition(string name, int type, double costPerDay, int noOfDays, int noOfStalls) : base(name, type, costPerDay, noOfDays)
            {
                this.noOfStalls = noOfStalls;
            }
            public double TotalCost()
            {
                double totalCost = (costPerDay * noOfDays);
                return totalCost + (totalCost * 0.05);
            }

            public void display()
            {
                Console.WriteLine("Event Details");
                Console.WriteLine($"Name: {name}\nType: {type}\nNumber of stalls:{noOfStalls}");
                double totalCost = TotalCost();
                Console.WriteLine($"Total Amount: {totalCost:F2}");
            }
        }

        class StageEvent : Event
        {
            static int gst = 15;
            int noOfSeats;
            public StageEvent(string name, int type, double costPerDay, int noOfDays, int noOfSeats) : base(name, type, costPerDay, noOfDays)
            {
                this.noOfSeats = noOfSeats;
            }

            public double TotalCost()
            {
                double totalCost = (costPerDay * noOfDays);
                return totalCost + (totalCost * 0.15);
            }
            public void display()
            {
                Console.WriteLine("Event Details");
                Console.WriteLine($"Name: {name}\nType: {type}\nNumber of stalls:{noOfSeats}");
                double totalCost = TotalCost();
                Console.WriteLine($"Total Amount: {totalCost:F2}");
            }

        }
    }
}
