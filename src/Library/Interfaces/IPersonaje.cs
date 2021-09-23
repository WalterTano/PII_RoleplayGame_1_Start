using System.Collections;
using Library.Negocio;
namespace Library.Interfaces
{
    public interface IPersonaje
    {
        string Nombre { get; set; }
        IRaza Raza { get; set; }
        int Vida { get; set; }
        int Ataque { get; set; }
        int Defensa { get; set; }
        ArrayList Inventario { get; set; }
        int VidaInicial { get; set; }

        bool Vivo {get; set;}


        void atacar(IPersonaje personaje);

        void curar(IPersonaje personaje);

        void agregarItem(ITem item);

        void quitarItem(ITem item);


    }
}