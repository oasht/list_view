using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_04_2023
{
    public class Tovar
    {
        public string name;
        public int price;
        public int count;
        public Tovar(string name, int price, int count)
        {
            this.name = name;
            this.price = price;
            this.count = count;
        }
    }
}
