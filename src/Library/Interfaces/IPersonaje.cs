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


        void Atacar(IPersonaje personaje);

        void Curar(IPersonaje personaje);

        void AgregarItem(ITem item);

        void QuitarItem(ITem item);


    }
}