using System;
using System.Collections;

namespace Library
{
    public class Item
    {
        private string _tipo;
        public string Tipo { get;}
        
        private ArrayList _compatible;
        public ArrayList Compatible { get; }

        private int _ataque;
        public int Ataque { get;  }

        private int _defensa;
        public int Defensa { get; }

        private ArrayList _hechizos;
        public ArrayList Hechizos { get; }
        
        public Item(string tipo, ArrayList compatible, int ataque, int defensa, ArrayList hechizos)
        {
            Compatible = compatible;
            Ataque = ataque;
            Defensa = defensa;
            Hechizos = hechizos;
            Tipo = tipo;
        }

        public void AgregarHechizo(Item item)
        {
            this.Hechizos.Add(item);
        }

        public void QuitarHechizo(Item item)
        {
            this.Hechizos.Remove(item);
        }

    }
}