using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcuCafe.Domain
{
    public class IceTea : Drink
    {
        public override string Description
        {
            get { return "Ice tea"; }
        }

        public override double Cost()
        {
            double cost = 1.5;

            if (HasMilk)
                cost += MilkCost;

            if (HasSugar)
                cost += SugarCost;

            return cost;
        }

        public override void Prepare(string drink)
        {
            string message = "We are preparing the following drink for you: " + Description;
            if (HasMilk)
                throw new Exception("IceTea shouldn't be with Milk");
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
