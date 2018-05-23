using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcuCafe.Domain
{
    public interface IDrinkIngredientFactory
    {
         Milk AddMilk();
         Sugar AddSugar();
         Ice AddIce();

    }

    public class Ice
    {
    }

    public class Sugar
    {
    }

    public class Milk
    {
    }
}
