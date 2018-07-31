using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merchendise
{
    public class Sandpaper : Article
    {
        public double Width;
        public int Granulation;

        public Sandpaper(string Name, double Price, int Quantity, double Width, int Granulation) : base(Name, Price, Quantity)
        {
            this.Width = Width;
            this.Granulation = Granulation;
        }
        public override string Description()
        {
            StringBuilder description = new StringBuilder(Width + ";" + Granulation + ";");
            string SandpaperDescription=description.ToString();
            return base.Description() + SandpaperDescription;
        }

    }
}
