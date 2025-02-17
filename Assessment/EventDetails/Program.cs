using System.ComponentModel;

namespace EventDetails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of Events: ");
            int numOfEvents = int.Parse(Console.ReadLine());
            List<Event> events = new List<Event>();
            for (int i = 0; i < numOfEvents; i++)
            {
                try
                {
                    Console.WriteLine("Enter event details in CSV(Event Name,Organiser Name,Event Cost)");
                    string[] details = Console.ReadLine().Split(',');
                    Event newEvent = new Event()
                    {
                        EventName = details[0],
                        OrganiserName = details[1],
                        EventCost = double.Parse(details[2]),

                    };
                    events.Add(newEvent);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            Event e1 = new Event();
            e1.Display(events);
            
        }
    }

    class Event
    {
        public string EventName { get; set; }
        public string OrganiserName { get; set; }
        public double EventCost { get; set; }

       public  void Display(List<Event> eventList)
        {
            Console.WriteLine("List of Events: ");
            eventList.ForEach(e =>
             Console.WriteLine($"{e.EventName} | {e.OrganiserName} | {e.EventCost:F2}")
             );
        }
    }
}
