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
            IRaza r = new RazaEnano();
            string expected = "Enano";
            Assert.AreEqual(expected, r.Nombre);
        }

        [Test]
        public void TestName()
        {
            IRaza r = new RazaEnano();
            IPersonaje p = new Ogro("Uglúk", r, 1000, 200, 125);
            string expected = "Uglúk";
            Assert.AreEqual(expected, p.Nombre);
        }

        [Test]
        public void TestVida()
        {
            IRaza r = new RazaEnano();
            IPersonaje p = new Ogro("Uglúk", r, 1000, 200, 125);
            int expected = 1000;
            Assert.AreEqual(expected, p.Vida);
        }

        [Test]
        public void TestAtaque()
        {
            IRaza r = new RazaEnano();
            IPersonaje p = new Ogro("Uglúk", r, 1000, 200, 125);
            int expected = 200;
            Assert.AreEqual(expected, p.Ataque);
        }

        [Test]
        public void TestDefensa()
        {
            IRaza r = new RazaEnano();
            IPersonaje p = new Ogro("Uglúk", r, 1000, 200, 125);
            int expected = 125;
            Assert.AreEqual(expected, p.Defensa);
        }

        // Walter Taño
        [Test]
        public void TestAtacarSinArma()
        {
            IRaza r1 = new RazaEnano();
            IPersonaje p1 = new Ogro("Uglúk", r1, 1000, 200, 125);
            IRaza r2 = new RazaEnano();
            IPersonaje p2 = new Ogro("Uglúk", r2, 1000, 300, 95);

            p1.Atacar(p2);
            int expected = 895; // 1000 - 200 + 95
            Assert.AreEqual(expected, p2.Vida);
        }

        [Test]
        public void TestEquiparArma()
        {
            IRaza enano = new RazaEnano();
            ArrayList compatibleArma = new ArrayList();
            compatibleArma.Add(enano);
            ITem arma = new MartilloDeGuerra("Martillo enano", 150, "Un pesado martillo de guerra, usado solo por los enanos más fuertes de Khazad-dûm", 30);
            arma.AgregarRazaCompatible(enano);
            IPersonaje gimli = new Enano("Gimli", enano, 1000, 150, 150);
            gimli.AgregarItem(arma);

            bool expected = true;
            Assert.AreEqual(expected, gimli.Inventario.Contains(arma));
        }

        [Test]
        public void TestAtacarConArma()
        {
            IRaza enano = new RazaEnano();
            IRaza ogro = new RazaOgro();
            ArrayList compatibleArma = new ArrayList();
            compatibleArma.Add(enano);
            ITem arma = new MartilloDeGuerra("Martillo enano", 50, "Un pesado martillo de guerra, usado solo por los enanos más fuertes de Khazad-dûm", 15);
            arma.AgregarRazaCompatible(enano);
            IPersonaje gimli = new Enano("Gimli", enano, 1000, 150, 150);
            gimli.AgregarItem(arma);
            IPersonaje thrall = new Ogro("Thrall", ogro, 1000, 200, 125);

            gimli.Atacar(thrall);
            int expected = 775;
            Assert.AreEqual(expected, thrall.Vida);
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