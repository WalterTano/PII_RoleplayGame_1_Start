using System.Collections;

namespace Library
{
    public class Item
    {
        private string _tipo;
        public string Tipo { get;}
        
        private string[] _compatible;
        public string[] Compatible { get; }

        private int _ataque;
        public int Ataque { get;  }

        private int _defensa;
        public int Defensa { get; }

        private ArrayList _hechizos;
        public ArrayList Hechizos { get; }
        
        public Item(string tipo, string[] compatible, int ataque, int defensa)
        {
            Compatible = compatible;
            Ataque = ataque;
            Defensa = defensa;
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