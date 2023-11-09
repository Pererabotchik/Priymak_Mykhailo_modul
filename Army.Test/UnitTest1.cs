using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using modul;

namespace Army.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Gnom_characters_eat()
        {
            // arrange
            int eat = 1 * 10;

            int expected_eat = 10;

            // act

            Gnom gn = new modul.Gnom(10);

            int actual_eat = gn.get_eat();

            //assert

            Assert.AreEqual(expected_eat, actual_eat);
        }

        [TestMethod]
        public void Gnom_characters_price()
        {
            // arrange
            int price = 2 * 10;

            int expected_price = 20;

            // act

            Gnom gn = new modul.Gnom(10);

            int actual_price = gn.get_price();

            //assert

            Assert.AreEqual(expected_price, actual_price);
        }

        [TestMethod]
        public void Dragon_characters_eat()
        {
            // arrange
            int eat = 1 * 10;

            int expected_eat = 10;

            // act

            Dragon dr = new Dragon(10);

            int actual_eat = dr.get_eat();

            //assert

            Assert.AreEqual(expected_eat, actual_eat);
        }

        [TestMethod]
        public void Dragon_characters_eat_w()
        {
            // arrange
            int eat_w = 1 * 10;

            int expected_eat_w = 10;

            // act

            Dragon dr = new Dragon(10);

            int actual_eat_w = dr.get_eat_w();

            //assert

            Assert.AreEqual(expected_eat_w, actual_eat_w);
        }

        [TestMethod]
        public void Gnom_on_the_top_characters_eat()
        {
            // arrange
            int eat = 1 * 10;

            int expected_eat = 10;

            // act

            Gnom_on_the_top tr = new Gnom_on_the_top(10);

            int actual_eat = tr.get_eat();

            //assert

            Assert.AreEqual(expected_eat, actual_eat);
        }

        public void Gnom_on_the_top_characters_price()
        {
            // arrange
            int price = 3 * 10;

            int expected_price = 30;

            // act

            Gnom_on_the_top tr = new Gnom_on_the_top(10);

            int actual_price = tr.get_price();

            //assert

            Assert.AreEqual(expected_price, actual_price);
        }
    }
}
