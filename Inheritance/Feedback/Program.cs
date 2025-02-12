namespace Feedback
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of customers: ");
            int n = int.Parse(Console.ReadLine());
            Customer[] customers = new Customer[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter details for customers {i+1}: ");
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter your mobile number");
                string number = Console.ReadLine();
                Console.WriteLine("Feedback Rating (out of 5)");
                double feedback = double.Parse(Console.ReadLine());

                customers[i]= new Customer(feedback, name, number);
            }

            double totalFeedback = 0;
            foreach (var customer in customers)
            {
                totalFeedback += customer.feedbackRating;
            }

            double avgFeedback = totalFeedback / n;
            Console.WriteLine("\nCustomer Feedback Details:");
            foreach (var customer in customers)
            {
                Console.WriteLine($"Name: {customer.name}\nMobile NUmber: {customer.mobileNumber}\nFeedback Rating: {customer.feedbackRating} / 5");

            }
            Console.WriteLine($"Average Feedback Rating : {avgFeedback:F2} out of 5");
        }

        class Customer
        {
            public double feedbackRating;
            public string mobileNumber;
            public string name;

            public Customer(double feedbackRating, string mobileNumber, string name)
            {
                this.feedbackRating = feedbackRating;
                this.mobileNumber = mobileNumber;
                this.name = name;
            }
        }
    }
}
