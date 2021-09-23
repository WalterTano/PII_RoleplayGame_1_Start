using System.Collections;

namespace Library.Interfaces
{

    public interface ITem 
    {

        string Nombre { get; set; }
        int Ataque { get; set; }
        int Defensa { get; set; }
        ArrayList Compatible { get; set; }
        //ArrayList IHechizo { get; set; }

        void agregarRazaCompatible(IRaza raza);
        void quitarRazaCompatible(IRaza raza);
    
    }

}