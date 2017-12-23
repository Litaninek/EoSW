﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication27;
using NUnit.Framework;

namespace TestLibrary
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void BaseTest()
        {
            Goods fanta = new Regular("Fanta");
            Goods snikers = new Sale("Snikers");
            int price_for_fanta = 45;
            int price_for_snikers = 33;
            Item i1 = new Item(fanta, 2, price_for_fanta);
            Item i2 = new Item(snikers, 3, price_for_snikers);
            Customer Denis = new Customer("Denis", 10);
            Bill b1 = new Bill(Denis);
            b1.addGoods(i1);
            b1.addGoods(i2);
            string bill = b1.statement();
            double actual = b1.f;
            double exepted = 186.03;
            Assert.AreEqual(exepted, actual);
        }
        [Test]
        public void BaseTest2()
        {
            Goods cola = new Special("Cola");
            Goods pepsi = new Sale("Pepsi");
            Item i1 = new Item(cola, 6, 65);
            Item i2 = new Item(pepsi, 3, 50);
            Customer x = new Customer("test", 10);
            Bill b1 = new Bill(x);
            b1.addGoods(i1);
            b1.addGoods(i2);
            string bill = b1.statement();
            double actual = b1.f;
            double exepted = 521.60000000000002;
            Assert.AreEqual(exepted, actual);
        }
        [Test]
        public void Test_with_three()
        {
            Goods pivo = new Sale("Pivo");
            Goods chipsi = new Special("Chipsi");
            Goods nuts = new Sale("Nuts");
            Item i1 = new Item(pivo, 2, 67);
            Item i2 = new Item(chipsi, 4, 45);
            Item i3 = new Item(nuts, 2, 27);
            Customer x = new Customer("Denis", 15);
            Bill b1 = new Bill(x);
            b1.addGoods(i1);
            b1.addGoods(i2);
            b1.addGoods(i3);
            string bill = b1.statement();
            double actual = b1.f;
            double exepted = 351.19999999999999;
            Assert.AreEqual(exepted, actual);
        }
        [Test]
        public void BonusBallTest_Base()
        {
            Goods cola = new Regular("Cola");
            Goods pepsi = new Regular("Pepsi");
            Item i1 = new Item(cola, 6, 65);
            Item i2 = new Item(pepsi, 3, 50);
            Customer x = new Customer("test", 10);
            Bill b1 = new Bill(x);
            b1.addGoods(i1);
            b1.addGoods(i2);
            string bill = b1.statement();
            double actual = b1.bonus;
            double exepted = 10;
            Assert.AreEqual(exepted, actual);
        }
        [Test]
        public void BonusBallTest2_Base()
        {
            Goods fanta = new Goods("Fanta");
            Goods snikers = new Goods("Snikers");
            int price_for_fanta = 45;
            int price_for_snikers = 33;
            Item i1 = new Item(fanta, 2, price_for_fanta);
            Item i2 = new Item(snikers, 3, price_for_snikers);
            Customer Denis = new Customer("Denis", 10);
            Bill b1 = new Bill(Denis);
            b1.addGoods(i1);
            b1.addGoods(i2);
            string bill = b1.statement();
            double actual = b1.bonus;
            double exepted = 0;
            Assert.AreEqual(exepted, actual);
        }
    }
}
