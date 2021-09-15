using System;
using System.Collections;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Raza guerrero = new Raza("Guerrero");
            Personaje guerreroConEspada =  new Personaje("Gran Guerrero", guerrero, 10, 15, 5);
            
            ArrayList lista1= new ArrayList();
            lista1.Add(guerrero);
            Item espadaSagrada = new Item("Espada Sagrada", lista1, 12, 14, null);
            Item espada = new Item("Espada normal", lista1, 2, 14, null);
            
            guerreroConEspada.AgregarItem(espadaSagrada);
            guerreroConEspada.AgregarItem(espada);
            
        }
    }
}
