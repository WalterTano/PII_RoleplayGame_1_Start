using System.Collections;
using Library.Negocio;
using Library.Interfaces;
using System;

namespace Program
{

    class Program
    {

        static void Main(string[] args)
        {
            RazaEnano razaEnano = new RazaEnano("a");

            IPersonaje enano1 = new Enano("Thrár", razaEnano, 100, 5, 7);
            ITem martillo = new MartilloDeGuerra("Martillo", 100, "nose", 15);
            

            martillo.agregarRazaCompatible(razaEnano);
            enano1.agregarItem(martillo);


            IPersonaje enano2 = new Enano("Thrár", razaEnano, 100, 5, 7);
            enano2.agregarItem(martillo);

            enano1.atacar(enano2);

            Console.WriteLine(enano2.Vida);



        }

    }
}
