using System;

namespace Beregner
{
    class Program
    {
        static void Main(string[] args)
        {
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
            double income = UserDefinedClientIncome();
            Client client = new Client(name, income, 345345);
            return client;
        }

        public static bool ClientTypeSelect()
        {
            Console.WriteLine("To create new user type press 'Y' or press 'N' or Enter to continue with a default user");
            Console.Write("Create new user?: ");
            string selection = Console.ReadLine();
            if (selection.ToLower() == "y")
                return true;
            return false;
        }

        private static string UserDefinedClientName()
        {
            Console.Write("Insert new username: ");
            string selection = Console.ReadLine();

            while (selection.Length < 3)
            {
                Console.Write("Username should contain min.3 characters. Try again: ");
                selection = Console.ReadLine();
            }
            return selection;
        }
        private static double UserDefinedClientIncome()
        {
            Console.Write("Insert Income: ");
            string selection = Console.ReadLine();
            double income;
            while (!double.TryParse(selection, out income)) 
            {
                Console.Write("Insert Income as decimal: ");
                selection = Console.ReadLine();
            }
            return income;
        }
    }
}
