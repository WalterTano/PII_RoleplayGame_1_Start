using System;
using Library;

namespace Program
{

    class Program
    {
        static void Main(string[] args)
        {
            String[] CompatibilidadEspada = {"Ogro", "Elfo"};
            String[] CompatibilidadHechizos = {"Mago"};
            String[] CompatibilidadLibroHechizos = {"Libro de Hechizos"};
            //Lucas Giffuni
            Personaje Ugluk = new Personaje("Ogro","Uglúk", 1000, 100, 300);
            Personaje Galdaf = new Personaje("Mago", "Gandalf", 1000, 250, 175);

            Item elementoTierra = new Item("Tierra", CompatibilidadLibroHechizos,0,0);
            Item elementoFuego = new Item("Fuego", CompatibilidadLibroHechizos,0,0);

            Item libroDeHechizo = new Item("Libro", CompatibilidadHechizos, 200, 15);
            libroDeHechizo.AgregarHechizo(elementoFuego);
            libroDeHechizo.AgregarHechizo(elementoTierra);

            Item espada = new Item("Espada",CompatibilidadEspada, 100, 0);

            Ugluk.AgregarItem(espada);
            Galdaf.AgregarItem(libroDeHechizo);


            Ugluk.Atacar(Galdaf);

        }
    }
}
