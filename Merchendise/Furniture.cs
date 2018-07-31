using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merchendise
{
    public class Furniture : Article
    {
        public string Collection;

        public Furniture(string Name,double Price,int Quantity,string Collection) : base(Name, Price, Quantity)
        {
            this.Collection = Collection;
        }

        public override string Description()
        {
            return base.Description() + Collection;
        }

    }
}
