using NUnit.Framework;
using Library.Interfaces;
using Library.Negocio;

using System.Collections;
namespace Test.Library
{


    public class ExampleTest
    {

        // Lucas Giffuni
        [Test]
        public void TestRaza()
        {
            IRaza r = new RazaEnano("Ogro");
            string expected = "Ogro";
            Assert.AreEqual(expected, r.Nombre);
        }

        [Test]
        public void TestName()
        {
            IRaza r = new RazaEnano("Ogro");
            IPersonaje p = new Ogro("Uglúk", r, 1000, 200, 125);
            string expected = "Uglúk";
            Assert.AreEqual(expected, p.Nombre);
        }

        [Test]
        public void TestVida()
        {
            IRaza r = new RazaEnano("Ogro");
            IPersonaje p = new Ogro("Uglúk", r, 1000, 200, 125);
            int expected = 1000;
            Assert.AreEqual(expected, p.Vida);
        }

        [Test]
        public void TestAtaque()
        {
            IRaza r = new RazaEnano("Ogro");
            IPersonaje p = new Ogro("Uglúk", r, 1000, 200, 125);
            int expected = 200;
            Assert.AreEqual(expected, p.Ataque);
        }

        [Test]
        public void TestDefensa()
        {
            IRaza r = new RazaEnano("Ogro");
            IPersonaje p = new Ogro("Uglúk", r, 1000, 200, 125);
            int expected = 125;
            Assert.AreEqual(expected, p.Defensa);
        }

        // Walter Taño
        [Test]
        public void TestAtacarSinArma()
        {
            IRaza r1 = new RazaEnano("Ogro");
            IPersonaje p1 = new Ogro("Uglúk", r1, 1000, 200, 125);
            IRaza r2 = new RazaEnano("Ogro");
            IPersonaje p2 = new Ogro("Uglúk", r2, 1000, 300, 95);

            p1.atacar(p2);
            int expected = 975; // obj.Vida - (p.Ataque - obj.Defensa) = 1000 - 25 = 975
            Assert.AreEqual(expected, p2.Vida);
        }

        [Test]
        public void TestEquiparArma()
        {
            /*
            Raza enano = new Raza("Enano");
            ArrayList compatibleArma = new ArrayList();
            compatibleArma.Add(enano);
            Item arma = new Item("Hacha enana", compatibleArma, 150, 25);

            Personaje p = new Personaje("Gimli", enano, 1000, 150, 150);
            p.AgregarItem(arma);

            bool expected = true;
            Assert.AreEqual(expected, p.Inventario.Contains(arma));
            */
        }

        [Test]
        public void TestAtacarConArma()
        {
            /*
            Raza enano = new Raza("Enano");
            Raza ogro = new Raza("Ogro");
            ArrayList compatibleArma = new ArrayList();
            compatibleArma.Add(enano);
            Item arma = new Item("Hacha enana", compatibleArma, 150, 25);

            Personaje p = new Personaje("Gimli", enano, 1000, 150, 150);
            p.AgregarItem(arma);
            Personaje obj = new Personaje("Thrall", ogro, 1000, 200, 125);

            p.Atacar(obj);
            int expected = 825; // obj.Vida - (p.Ataque + arma.Ataque - obj.Defensa) = 1000 - 175 = 825
            Assert.AreEqual(expected, obj.Vida);
            */
        }

        //ezequiel
        [Test]
        public void TestDesequiparArma()
        {
            /*
                Raza guerrero = new Raza("Guerrero");
                ArrayList lista1 = new ArrayList();
                lista1.Add(guerrero);
                Item granEspada = new Item("Espada", lista1, 2, 5);
                Personaje guerreroSinEspada = new Personaje("Gran guerrero", guerrero, 53, 876, 12);
                guerreroSinEspada.AgregarItem(granEspada);
                guerreroSinEspada.QuitarItem(granEspada);
                Assert.AreEqual(false, guerreroSinEspada.Inventario.Contains(granEspada));
                */
        }

    }


}