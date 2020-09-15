using System;
using System.Text;

namespace Beregner
{
    class Program
    {
        static void Main(string[] args)
        {
            bool clientType = ClientTypeSelect();
            var client = CreateClient(clientType);
            Console.WriteLine(PrintResuts(client));
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
        public static string PrintResuts(Client client)
        {
            var sb = new StringBuilder();
            sb.AppendLine("");
            sb.AppendLine($"Client Name: {client.Name}, Total Income: {client.Income.ToString("C2")}, Total Consumption: {client.Consumption.ToString("C2")}");
            sb.AppendLine("");
            sb.AppendLine($"Total days from beginning of the year: {Date.CalculateDaysFormBeginningOfTheYear()}");
            sb.AppendLine("");
            sb.AppendLine($"Total months from beginning of the year: {Date.CalculateMonthsFormBeginningOfTheYear().ToString("F2")}");
            sb.AppendLine("");
            sb.AppendLine($"Average Income: {Calculator.AverageIncome(client.Income, Date.CalculateMonthsFormBeginningOfTheYear()).ToString("C2")}");
            sb.AppendLine("");
            sb.AppendLine($"Average Consumption: {Calculator.AverageConsumption(client.Consumption, Date.CalculateMonthsFormBeginningOfTheYear()).ToString("C2")}");
            sb.AppendLine("");
            sb.AppendLine($"Savings Rate: {Calculator.SavingsRate(client.Income, client.Consumption).ToString("P")}");
            return sb.ToString();
        }
    }
}
