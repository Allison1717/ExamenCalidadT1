using CalidadT1;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebasCalidadT1
{
    public class RomanoGeneratorTest
    {
        [Test]
        public void Caso01RomanoGeneratorTest()
        {
            var numromano = RomanoGenerator();
            var test = numromano.GetRomano(100);
            Assert.AreEqual("C", test);
        }

        [Test]
        public void Caso02RomanoGeneratorTest()
        {
            var numromano = RomanoGenerator();
            var test = numromano.GetRomano(25);
            Assert.AreEqual("XXV", test);
        }
        [Test]
        public void Caso03RomanoGeneratorTest()
        {
            var numromano = RomanoGenerator();
            var test = numromano.GetRomano(50);
            Assert.AreEqual("L", test);
        }
        [Test]
        public void Caso04RomanoGeneratorTest()
        {
            var numromano = RomanoGenerator();
            var test = numromano.GetRomano(5);
            Assert.AreEqual("V", test);
        }
        [Test]
        public void Caso05RomanoGeneratorTest()
        {
            var numromano = RomanoGenerator();
            var test = numromano.GetRomano(38);
            Assert.AreEqual("XXXVIII", test);
        }
        [Test]
        public void Caso06RomanoGeneratorTest()
        {
            var numromano = RomanoGenerator();
            var test = numromano.GetRomano(62);
            Assert.AreEqual("LXII", test);
        }
        [Test]
        public void Caso07RomanoGeneratorTest()
        {
            var numromano = RomanoGenerator();
            var test = numromano.GetRomano(16);
            Assert.AreEqual("XVI", test);
        }
        [Test]
        public void Caso08RomanoGeneratorTest()
        {
            var numromano = RomanoGenerator();
            var test = numromano.GetRomano(81);
            Assert.AreEqual("LXXXI", test);
        }
        [Test]
        public void Caso09RomanoGeneratorTest()
        {
            var numromano = RomanoGenerator();
            var test = numromano.GetRomano(12);
            Assert.AreEqual("XII", test);
        }
        [Test]
        public void Caso10RomanoGeneratorTest()
        {
            var numromano = RomanoGenerator();
            var test = numromano.GetRomano(70);
            Assert.AreEqual("LXX", test);
        }
        [Test]
        public void Caso11RomanoGeneratorTest()
        {
            var numromano = RomanoGenerator();
            var test = numromano.GetRomano(-5);
            Assert.AreEqual("Error", test);
        }
        [Test]
        public void Caso12RomanoGeneratorTest()
        {
            var numromano = RomanoGenerator();
            var test = numromano.GetRomano(0);
            Assert.AreEqual("Error", test);
        }
        [Test]
        public void Caso13RomanoGeneratorTest()
        {
            var numromano = RomanoGenerator();
            var test = numromano.GetRomano(23);
            Assert.AreEqual("XXIII", test);

        }
        [Test]
        public void Caso14RomanoGeneratorTest()
        {
            var numromano = RomanoGenerator();
            var test = numromano.GetRomano(99);
            Assert.AreEqual("XCIX", test);

        }
        [Test]
        public void Caso15RomanoGeneratorTest()
        {
            var numromano = RomanoGenerator();
            var test = numromano.GetRomano(8);
            Assert.AreEqual("VIII", test);

        }
        [Test]
        public void Caso16RomanoGeneratorTest()
        {
            var numromano = RomanoGenerator();
            var test = numromano.GetRomano(33);
            Assert.AreEqual("XXXIII", test);

        }
        [Test]
        public void Caso17RomanoGeneratorTest()
        {
            var numromano = RomanoGenerator();
            var test = numromano.GetRomano(1);
            Assert.AreEqual("I", test);

        }
        [Test]
        public void Caso18RomanoGeneratorTest()
        {
            var numromano = RomanoGenerator();
            var test = numromano.GetRomano(520);
            Assert.AreEqual("DXX", test);

        }
        [Test]
        public void Caso19RomanoGeneratorTest()
        {
            var numromano = RomanoGenerator();
            var test = numromano.GetRomano(101);
            Assert.AreEqual("CI", test);

        }
        [Test]
        public void Caso20RomanoGeneratorTest()
        {
            var numromano = RomanoGenerator();
            var test = numromano.GetRomano(962);
            Assert.AreEqual("CMLXII", test);

        }
        [Test]
        public void Caso21RomanoGeneratorTest()
        {
            var numromano = RomanoGenerator();
            var test = numromano.GetRomano(-18);
            Assert.AreEqual("Error", test);

        }
        [Test]
        public void Caso22RomanoGeneratorTest()
        {
            var numromano = RomanoGenerator();
            var test = numromano.GetRomano(40);
            Assert.AreEqual("XL", test);

        }
        [Test]
        public void Caso23RomanoGeneratorTest()
        {
            var numromano = RomanoGenerator();
            var test = numromano.GetRomano(19);
            Assert.AreEqual("XIX", test);

        }
        [Test]
        public void Caso24RomanoGeneratorTest()
        {
            var numromano = RomanoGenerator();
            var test = numromano.GetRomano(17);
            Assert.AreEqual("XVII", test);

        }
        [Test]
        public void Caso25RomanoGeneratorTest()
        {
            var numromano = RomanoGenerator();
            var test = numromano.GetRomano(500);
            Assert.AreEqual("D", test);

        }
     
    }
}