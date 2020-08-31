using System;

namespace Beregner
{
    class Program
    {
        static void Main(string[] args)
        {
            bool askUser = AskUser();

            var client = CreateClient(askUser);

            Console.WriteLine($"Name: {client.Name}, Income: {client.Income}, Consumption: {client.Consumption}");
        }

        public static Client CreateClient(bool type)
        {
            if (!type)
            {
                Client client = new Client();
                return client;  
            }
            else
            {
                Client client = new Client();
                return client;
            }
        }

        public static bool AskUser()
        {
            Console.WriteLine("Create default client 0 or 1 for userdefined");
             bool selection = bool.Parse(Console.ReadLine());
            return selection;
        }
    }
}
