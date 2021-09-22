using System;

namespace Library
{
    public class Espada : IOfensivo
    {
        private string _nombre;
        private int _ataque;
        private string _descripcion;
        private int _filo;

        public Espada(string nombre, int ataque, string descripcion, int filo)
        {
            this.Nombre = nombre;
            this.Ataque = ataque;
            this.Descripcion = descripcion;
            if(filo > 100){
                this.Filo = 100;
            } else if(filo < 0){
                this.Filo = 0;
            } else {
                this.Filo = filo;
            }
        }

        public int CalcularDano()
        {
            double retorno = this.Ataque;
            if(this.Filo >= 50){
                retorno *= (retorno / 100);
            } else {
                retorno /= 10;
            }
            return Convert.ToInt32(retorno);
        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public int Ataque { get => _ataque; set => _ataque = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public int Filo { get => _filo; set => _filo = value; }
    }
}
