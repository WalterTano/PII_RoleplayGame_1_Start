using System;

namespace Negocio
{
    public class MartilloDeGuerra : IOfensivo
    {
        private string _nombre;
        private int _ataque;
        private string _descripcion;
        private int _peso;

        public MartilloDeGuerra(string nombre, int ataque, string descripcion, int peso)
        {
            this.Nombre = nombre;
            this.Ataque = ataque;
            this.Descripcion = descripcion;
            this.Peso = peso;
        }

        public int CalcularDano()
        {
            double retorno = this.Ataque + ( this.Ataque * (Peso / 5) );
            return Convert.ToInt32(retorno);
        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public int Ataque { get => _ataque; set => _ataque = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public int Peso { get => _peso; set => _peso = value; }
    }
}
