using System;
using System.Collections.Generic;
using AcuCafe.Domain;

namespace AcuCafe
{
    public  class AcuCafe
    {

        public  Drink OrderDrink(string type, bool hasMilk, bool hasSugar, bool hasMocha = false)
        {
            Drink drink ;

            switch (type)
            {
                case "Expresso":
                    drink = new Expresso
                    {
                        HasMilk = hasMilk,
                        HasSugar = hasSugar,
                        HasMocha = hasMocha
                    };
                    break;
                case "IceTea":
                    drink = new IceTea();
                    drink.HasMilk = hasMilk;
                    drink.HasSugar = hasSugar;
                    break;
                case "Tea":
                    drink = new Tea();
                    drink.HasMilk = hasMilk;
                    drink.HasSugar = hasSugar;
                    break;
                default:
                    throw new Exception("Wrong drink type");
            }

            
               
                drink.Prepare(type);
           

            return drink;
        }

    }
    
        
}
