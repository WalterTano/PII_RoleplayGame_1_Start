using Library;
using System.Collections;

namespace Interfaces
{
    public interface IPersonaje
    {
        string Nombre { get; set; }
        Raza Raza { get; set; }
        int Vida { get; set; }
        int Ataque { get; set; }
        int Defensa { get; set; }
        ArrayList Inventario { get; set; }
        int VidaInicial { get; set; }


        void atacar(IPersonaje personaje);

        void curar(IPersonaje personaje);

        void agregarItem(Item item);

        void quitarItem(Item item);


    }
}