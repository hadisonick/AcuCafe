using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcuCafe.Domain
{
    public abstract class Drink
    {
        public const double MilkCost = 0.5;
        public const double SugarCost = 0.5;
        public const double Mocha = 0.5;

        public bool HasMilk { get; set; }

        public bool HasSugar { get; set; }
        public virtual string Description { get; }

        public abstract double Cost();
        

        public virtual void Prepare(string drink)
        {
            string message = "We are preparing the following drink for you: " + Description;
            if (HasMilk)
                message += "with milk";
            else
                message += "without milk";

            if (HasSugar)
                message += "with sugar";
            else
                message += "without sugar";

            Console.WriteLine(message);
        }
    }
}
