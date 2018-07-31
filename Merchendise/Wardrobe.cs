using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merchendise
{
    public class Wardrobe : Furniture
    {
        public int Height;
        public int Width;
        public int Depth;

        public Wardrobe(string Name,double Price, int Quantity, string Collection,int Height,int Width,int Depth) : base(Name, Price, Quantity, Collection)
        {
            this.Height = Height;
            this.Width = Width;
            this.Depth = Depth;
        }

        public override string Description()
        {
            StringBuilder description = new StringBuilder(";" + Height + ";" + Width + ";" + Depth);
            string WardrobeDescription = description.ToString();
            return base.Description() + WardrobeDescription;
        }
    }
}
