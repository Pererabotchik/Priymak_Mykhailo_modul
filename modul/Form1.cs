using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int troll = 0;
            int dragon = 0;
            int gnom = 0;

            troll = Convert.ToInt32(textBox_trol.Text);
            dragon = Convert.ToInt32(textBox_dragon.Text);
            gnom =  Convert.ToInt32(textBox_gnom.Text);

            Gnom tr = new Gnom(troll);
            Dragon dr = new Dragon(dragon);
            Gnom_on_the_top gn = new Gnom_on_the_top(gnom);

            Army arm = new Army();

            arm.count_eat_b(tr.get_eat());
            arm.count_eat_korm(dr.get_eat());
            arm.count_eat_w(dr.get_eat_w());
            arm.count_eat_al(gn.get_eat());

            arm.set(tr.get_price() + gn.get_price() + dr.get_price(), tr.get_speed() + dr.get_speed() + gn.get_speed());
            arm.count_arm(troll + dragon + gnom);

            label_count_all.Text = Convert.ToString(troll + dragon + gnom);
            label_gold.Text = Convert.ToString(arm.get_allprice());
            label_speed.Text = Convert.ToString(arm.get_allspeed());

            label_alcoholo.Text = Convert.ToString(arm.get_eat_al());
            label_baran.Text = Convert.ToString(arm.get_eat_b());
            label_women.Text = Convert.ToString(arm.get_eat_w_ar());
            label_eat_k.Text = Convert.ToString(arm.get_eat_korm());


        }
    }
}
