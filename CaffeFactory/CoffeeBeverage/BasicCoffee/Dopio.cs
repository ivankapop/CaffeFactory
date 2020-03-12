using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaffeFactory
{
    public class Dopio : Espresso
    {
        public override string GetDescription()
        {
            return base.GetDescription() + " double portions of espresso ";
        }

        public override int Cost()
        {
            return base.Cost() * 2;
        }
    }
}
