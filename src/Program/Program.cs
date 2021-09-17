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

            Item hechizoWalter = new Item("Hechizo", new ArrayList(), 10, 0);
            ArrayList razasMago = new ArrayList();
            razasMago.Add(MAGO);
            Item bastonWalter = new Item("Ofensivo", razasMago, 20, 0);
            bastonWalter.AgregarHechizo(hechizoWalter);
            Item tunica = new Item("Defensivo", razasMago, 0, 5);

            personajeWalter.AgregarItem(bastonWalter);
            personajeWalter.AgregarItem(tunica);

          
            //Lucas Giffuni
          
            //Declaro razas del personaje
            Raza ogro = new Raza("Ogro");

            //Declaro personaje
            Personaje ugluk = new Personaje("Uglúk", ogro, 1000, 200, 125);

            //Declaro el array que contiene las razas para cada item
            ArrayList razasEspada = new ArrayList();
            razasEspada.Add(ogro);
             ArrayList razasArmadura = new ArrayList();
            razasArmadura.Add(ogro);

            //Declaro item con su raza de compatibilidad asignada.
            Item espada = new Item("Espada", razasEspada, 35, 0);
            Item armadura = new Item("Armadura", razasEspada,0,50);

            //Agrego items al personaje.
            ugluk.AgregarItem(espada);
            ugluk.AgregarItem(armadura);




        }

        
    }
}
