using System;
using Library.Interfaces;
using System.Collections;

namespace Library.Negocio
{
    public class Espada : IOfensivo, ITem
    {
        private string _nombre;
        private int _ataque;
        private int _defensa;
        private ArrayList _compatible;
        private string _descripcion;
        private int _filo;

        public Espada(string nombre, int ataque, string descripcion, int filo)
        {
            this.Nombre = nombre;
            this.Ataque = ataque;
            this.Descripcion = descripcion;
            this.Defensa = 0;
            this.Compatible = new ArrayList();
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

        public void AgregarRazaCompatible(IRaza raza)
        {
            this.Compatible.Add(raza);
        }

        public void QuitarRazaCompatible(IRaza raza)
        {
            this.Compatible.Remove(raza);
        }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public int Ataque { get => _ataque; set => _ataque = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public int Filo { get => _filo; set => _filo = value; }
        public int Defensa { get => _defensa; set => _defensa = value; }
        public ArrayList Compatible { get => _compatible; set => _compatible = value; }
    }
}
