using System;
using Library;
using System.Collections;

namespace Program
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Raza MAGO = new Raza("Mago");
            Personaje personajeWalter = new Personaje("Walter", MAGO, 100, 35, 35);

            Item hechizoWalter = new Item("Hechizo", new ArrayList(), 10, 0, new ArrayList());
            ArrayList razasMago = new ArrayList();
            razasMago.Add(MAGO);
            Item bastonWalter = new Item("Ofensivo", razasMago, 20, 0, new ArrayList());
            bastonWalter.AgregarHechizo(hechizoWalter);
            Item tunica = new Item("Defensivo", razasMago, 0, 5, new ArrayList());

            personajeWalter.AgregarItem(bastonWalter);
            personajeWalter.AgregarItem(tunica);
        }

        
    }
}
