using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merchendise
{
    public class Article
    {
        public string Name;
        public double Price;
        public int Quantity;

        public Article(string Name,double Price,int Quantity)
        {
            this.Name = Name;
            this.Price = Price;
            this.Quantity = Quantity;
        }

        public virtual string Description()
        {
            StringBuilder description = new StringBuilder(Name+";"+Price+";"+Quantity+";");
            string ArticleDescription=description.ToString();
            return ArticleDescription;
        }
    }
}
