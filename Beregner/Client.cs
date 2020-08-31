using System;
using System.Collections.Generic;
using System.Text;

namespace Beregner
{
    public class Client
    {
        public string Name { get; set; } = "Birges";
        public double Consumption { get; set; } = 100704.1;
        public double Income { get; set; } = 246585;

        public Client(){}
        public Client(string Name, double Consumption, double Income)
        {
            this.Name = Name;
            this.Consumption = Consumption;
            this.Income = Income;
        }
    }
}
