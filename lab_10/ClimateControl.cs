using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_10
{
    class ClimateControl : DecoratorOptions
    {
        public ClimateControl(AutoBase p, string t) : base(p, t)
        {
            AutoProperty = p;
            Name = p.Name + ". Тёплый";
            Description = p.Description + ". " + this.Title + ". Система климат-контроля";


        }
        public override double GetCost()
        {
            return AutoProperty.GetCost() + 25;
        }
    }
}
