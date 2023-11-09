using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul
{
    public class Dragon : Army
    {
        private int price = 0;
        private int eat = 1;
        private int eat_w = 1;
        private int speed = 60;

        public Dragon(int count)
        {
            price = price * count;
            eat = eat * count;
            speed = speed * count;
            eat_w = eat_w * count;
        }

        public int get_price() { return price;}
        public int get_eat() {  return eat; }   
        public int get_eat_w() {  return eat_w;}
        public int get_speed() { return speed;}
    }
}
