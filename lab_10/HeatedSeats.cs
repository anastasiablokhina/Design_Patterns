using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_10
{
    class HeatedSeats : DecoratorOptions
    {
        public HeatedSeats(AutoBase p, string t) : base(p, t)
        {
            AutoProperty = p;
            Name = p.Name + ". С подогревом";
            Description = p.Description + ". " + this.Title + ". Подогрев сидений";
        }
        public override double GetCost()
        {
            return AutoProperty.GetCost() + 15;
        }
    }
}
