using System;
using System.Collections;
using Library.Interfaces;
namespace Library.Negocio
{
    public class MartilloDeGuerra : IOfensivo, ITem
    {
        private string _nombre;
        private int _ataque;
        private string _descripcion;
        private int _peso;
        private int _defensa;
        private ArrayList _compatible;
        

        public MartilloDeGuerra(string nombre, int ataque, string descripcion, int peso)
        {
            this.Compatible = new ArrayList();
            this.Defensa = 0;
            this.Nombre = nombre;
            this.Ataque = ataque;
            this.Descripcion = descripcion;
            this.Peso = peso;
        }

        public int CalcularDano()
        {
            double retorno = this.Ataque + (this.Ataque * (Peso / 5));
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
        public int Peso { get => _peso; set => _peso = value; }
        public int Defensa { get => _defensa; set => _defensa = value; }
        public ArrayList Compatible { get => _compatible; set => _compatible = value; }
    }
}
