using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2
{
    public class Toy
    {
        public string Manufactuer { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        private string Aisle { get; set; }

        public Toy()
        {
            Manufactuer = string.Empty;
            Name = string.Empty;
            Price = 0.0;
            Image = string.Empty;
            Aisle = string.Empty;
        }
        public string GetAisle()
        {
            string M = Manufactuer.ToUpper();
            string thing = $"{M[0]}, {Price.ToString("")}";
            return thing;
        }
        public override string ToString()
        {
            string o = Manufactuer + "-" + Name;
            return o;
        }
    }
}
