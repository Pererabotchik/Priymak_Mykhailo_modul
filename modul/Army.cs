using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul
{
    public class Army
    {
        protected int all_price;
        protected int all_speed;
        protected int eat_b;
        protected int eat_al;
        protected int eat_korm;
        protected int eat_w;

        public void set(int price, int speed)
        {
            all_price = price;
            all_speed = speed;
        }

        public void count_eat_b(int eat)
        {
            eat_b = eat;
        }

        public void count_eat_al(int eat)
        {
            eat_al = eat;
        }

        public void count_eat_korm(int eat)
        {
            eat_korm = eat;
        }

        public void count_eat_w(int eat)
        {
            eat_w = eat;
        }

        public void count_arm(int count)
        {
            all_speed = all_speed / count;
        }

        public int get_allprice()
        {
            return all_price;
        }
        public int get_allspeed() 
        {
            return all_speed;
        }

        public int get_eat_b(){ return eat_b; }
        public int get_eat_al() {  return eat_al; }
        public int get_eat_korm() {  return eat_korm; }
        public int get_eat_w_ar() {  return eat_w; }

    }
}
