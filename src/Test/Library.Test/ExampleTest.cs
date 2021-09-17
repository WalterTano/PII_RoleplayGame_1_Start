using NUnit.Framework;
using Library;
namespace Test.Library
{


    public class ExampleTest
    {

        [Test]
        public void dummyTest()
        {
            Assert.True(true);
        }


        // Lucas Giffuni
        [Test]
        public void TestRaza()
        {
            Raza r = new Raza("Ogro");
            string expected = "Ogro";
            Assert.AreEqual(expected, r.Nombre);
        }
        
        [Test]
        public void TestName()
        {
            Raza ogro = new Raza("Ogro");
            Personaje p = new Personaje("Uglúk", ogro, 1000, 200, 125);
            string expected = "Uglúk";
            Assert.AreEqual(expected, p.Nombre);
        }

        [Test]
        public void TestVida()
        {
            Raza ogro = new Raza("Ogro");
            Personaje p = new Personaje("Uglúk", ogro, 1000, 200, 125);
            int expected = 1000;
            Assert.AreEqual(expected, p.Vida);
        }

        [Test]
        public void TestAtaque()
        {
            Raza ogro = new Raza("Ogro");
            Personaje p = new Personaje("Uglúk", ogro, 1000, 200, 125);
            int expected = 200;
            Assert.AreEqual(expected, p.Ataque);
        }

        [Test]
        public void TestDefensa()
        {
            Raza ogro = new Raza("Ogro");
            Personaje p = new Personaje("Uglúk", ogro, 1000, 200, 125);
            int expected = 125;
            Assert.AreEqual(expected, p.Defensa);
        }

    }


}