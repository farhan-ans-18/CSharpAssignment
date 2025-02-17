using System.Threading.Channels;

namespace MarraigeHall
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number of Halls: ");
            int numOfHalls = int.Parse(Console.ReadLine());
            List<Hall> list = new List<Hall>();
            for (int i = 0; i < numOfHalls; i++)
            {
                Console.WriteLine("Enter the Hall details {0,-15}{1,-10}{2,-10} (Hall Name, Cost, Owner): ");
                string[] details = Console.ReadLine().Split(',');
                Hall newHall = new Hall() {
                    Name = details[0],
                    CostPerDay = double.Parse(details[1]),
                    OwnerName = details[2],
                };
                list.Add(newHall);
            }
            Hall h1 = new Hall();
            h1.Display(list);
        }
    }

    class Hall 
    {
        public string Name { get; set; }
        public double CostPerDay { get; set; }
        public string OwnerName { get; set; }

       
        public void Display(List<Hall> list)
        {
            Console.WriteLine("Hall List:");
            Console.WriteLine("Name\tCost\tOwner");
            var sortedList = (list.OrderBy(e => e.OwnerName)).ToList();
            sortedList.ForEach(e =>
            Console.WriteLine($"{e.Name}\t{e.CostPerDay}\t{e.OwnerName:F2}"));
        }
    }
}
