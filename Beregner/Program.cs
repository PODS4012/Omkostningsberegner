using System;

namespace Beregner
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(Date.Today.ToString("d"));
            Console.WriteLine(Date.FistDay.ToString("d"));
            Console.WriteLine(Date.CalculateDaysFormBeginningOfTheYear());
            bool clientType = ClientTypeSelect();

            var client = CreateClient(clientType);

            Console.WriteLine($"Name: {client.Name}, Income: {client.Income}, Consumption: {client.Consumption}");
        }

        public static Client CreateClient(bool type)
        {
            if (type)
            {
                var client = CreateUserDefinedClient();
                return client;
            }
            else
            {
                Client client = new Client();
                return client;
            }
        }
        public static Client CreateUserDefinedClient()
        {
            string name = UserDefinedClientName();
            double income = UserDefinedClientIncomeConsumption("Income");
            double consumption = UserDefinedClientIncomeConsumption("Consumption");
            Client client = new Client(name, income, consumption);
            return client;
        }

        public static bool ClientTypeSelect()
        {
            Console.WriteLine("To create new user type press 'Y' or press 'N' or Enter to continue with a default user");
            Console.Write("Create new user?: ");
            string input = Console.ReadLine();
            if (input.ToLower() == "y")
                return true;
            return false;
        }

        public static string UserDefinedClientName()
        {
            Console.Write("Insert new username: ");
            string input = Console.ReadLine();

            while (input.Trim().Length < 3)
            {
                Console.Write("Username should contain min.3 characters. Try again: ");
                input = Console.ReadLine();
            }
            return input;
        }
        public static double UserDefinedClientIncomeConsumption(string type)
        {
            Console.Write($"Insert {type}: ");
            string input = Console.ReadLine();
            double amount;
            while (!double.TryParse(input, out amount) || amount <= 0) 
            {
                Console.Write($"Insert {type} as decimal and above 0: ");
                input = Console.ReadLine();
            }
            return amount;
        }
    }
}
