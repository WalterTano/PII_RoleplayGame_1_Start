using System;
using Library;
using System.Collections;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
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

            //Declaro item con su raza de compatibilidad asignada
            Item espada = new Item("Espada", razasEspada, 35, 0);
            Item armadura = new Item("Armadura", razasEspada,0,50);

            //Agrego items al personaje
            ugluk.AgregarItem(espada);
            ugluk.AgregarItem(armadura);



        }
    }
}
