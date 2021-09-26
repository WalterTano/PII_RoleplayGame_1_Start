using Library.Interfaces;
namespace Library.Negocio
{

    public class RazaEnano : IRaza
    {
        private string _nombre;
        public string Nombre { get => _nombre; }

        public RazaEnano()
        {
            this._nombre = "Enano";
        }
    }

}