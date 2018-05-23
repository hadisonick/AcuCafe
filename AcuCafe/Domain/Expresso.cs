using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcuCafe.Domain
{
    public class Expresso : Drink
    {
        public override string Description
        {
            get { return "Expresso"; }
        }

        public bool HasMocha { get; set; }

        public override double Cost()
        {
            double cost = 1.8;

            if (HasMilk)
                cost += MilkCost;

            if (HasSugar)
                cost += SugarCost;

            if (HasMocha)
                cost += Mocha;
            return cost;
        }

        public override void Prepare(string drink)
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

            if (HasMocha)
                message += "with mocha";
            else
                message += "without mocha";

            Console.WriteLine(message);
        }
    }


}
