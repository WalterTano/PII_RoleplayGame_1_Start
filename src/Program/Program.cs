using System;
using System.Collections;
using Libray;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Raza enano = new Raza("Enano");

            Personaje enano = new Personaje( "Thrár", "Enano", 100, 5, 7);

            ArrayList lista_raza = new ArrayList();
            lista_raza.Add(enano);

            ArrayList lista_hechizos = new ArrayList();

            Item escudoParaEnanos = new Item("Escudo", lista_raza, 0, 25, lista_hechizos);
            Item hachaDeGuerraParaEnanos = new Item("Hacha Doble", lista_raza, 10, 2, lista_hechizos);

            enano.AgregarItem(escudoParaEnanos);
            enano.AgregarItem(hachaDeGuerraParaEnanos);
        }
    }
}
