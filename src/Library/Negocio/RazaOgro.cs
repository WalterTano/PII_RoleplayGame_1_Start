using Library.Interfaces;
namespace Library.Negocio
{

    public class RazaOgro : IRaza
    {
        private string _nombre;
        public string Nombre { get => _nombre; }

        public RazaOgro()
        {
            this._nombre = "Ogro";
        }
    }

}