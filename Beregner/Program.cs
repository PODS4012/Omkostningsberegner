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
                //var client = CreateUserDefinedClient();
                Client client = new Client("Dariusz", 3453245, 345345);
                return client;  
            }
            else
            {
                Client client = new Client();
                return client;
            }
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
    }
}
