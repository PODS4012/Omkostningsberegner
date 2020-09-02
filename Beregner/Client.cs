using System;
using System.Collections.Generic;
using System.Text;

namespace Beregner
{
    public class Client
    {
        public string Name { get; set; } = "Birges";
        public double Income { get; set; } = 246585;
        public double Consumption { get; set; } = 100704.1;
        
        public Client(){}
        public Client(string Name, double Income, double Consumption)
        {
            this.Name = Name;
            this.Consumption = Consumption;
            this.Income = Income;
        }
    }
}
