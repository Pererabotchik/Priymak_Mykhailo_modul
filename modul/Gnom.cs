using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul
{
    public class Gnom : Army
    {
        private int price = 2;
        private int eat = 1;
        private int speed = 5;


        public Gnom(int count)
        {
            price = price * count;
            eat = eat * count;
            speed = speed * count;
        }

        public int get_price() { return price; }
        public int get_eat() { return eat; }
        public int get_speed() { return speed; }
    }
}
