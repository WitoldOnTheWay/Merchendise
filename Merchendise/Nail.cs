using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merchendise
{
    public class Nail : Article
    {
        public  double Length;
        public double Thickness;
        public string HeadType;

        public Nail(string Name, double Price, int Quantity,double Length,double Thickness,string HeadType) : base(Name, Price, Quantity)
        {
            this.Length = Length;
            this.Thickness = Thickness;
            this.HeadType = HeadType;
        }

        public override string Description()
        {
            StringBuilder description = new StringBuilder(Length + ";" + Thickness + ";" + HeadType + ";");
            string NailDescription = description.ToString();
            return base.Description() + NailDescription;



        }


    }
}
