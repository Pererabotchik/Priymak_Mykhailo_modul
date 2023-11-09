using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul
{
    public class Gnom_on_the_top : Army
    {
        private int price = 3;
        private int eat = 1;
        private int speed = 17;

        public Gnom_on_the_top(int count)
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
