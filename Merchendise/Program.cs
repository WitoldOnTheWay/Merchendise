using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merchendise
{
    class Program
    {
        static void Main(string[] args)
        {
            Nail nail = new Nail("Krokwiak",2.50,100,300.0,8.0,"Flat Head");
            nail.Description();
            Console.WriteLine(nail.Description());
            Furniture furniture = new Furniture("Stołek", 50, 4, "barowy");
            Console.WriteLine(furniture.Description());

            Wardrobe wardrobe = new Wardrobe("Suzi", 1500.0, 1, "modern 2018", 180, 120, 80);
            Console.WriteLine(wardrobe.Description());
        }
    }
}
