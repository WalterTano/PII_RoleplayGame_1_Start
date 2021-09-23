using Library.Interfaces;
namespace Library.Negocio
{

    public class RazaEnano : IRaza
    {
        private string _nombre;
        public string Nombre { get => _nombre; set => _nombre = value; }

        public RazaEnano(string value)
        {
            this._nombre = value;
        }
    }

}