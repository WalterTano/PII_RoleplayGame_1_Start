using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faustino, Personajes e Items//
            Raza Bruto= new Raza("bruto");
            Personaje Bob= new Personaje("Bob",Bruto,19,44,22);
            
            Item Palo= new Item("palo",Bruto,48,0,23);
            Item Navaja= new Item("navaja",Bruto,10,0,15);

            Bob.AgregarItem(Palo);
            Bob.AgregarItem(Navaja);
            

        }
    }
}
