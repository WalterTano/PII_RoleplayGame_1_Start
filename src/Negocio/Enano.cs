using Interfaces;
using System.Collections;
namespace Negocio
{
    public class Enano : IPersonaje
    {


        public Enano(string nombre, Raza raza, int vida, int ataque, int defensa)
        {
            this.Inventario = new ArrayList();
            this.Nombre = nombre;
            this.Raza = raza;
            this.Vida = vida;
            this.VidaInicial = vida;
            this.Ataque = ataque;
            this.Defensa = defensa;
        }


        public void atacar(IPersonaje personaje)
        {
            if (personaje.Vida > 0 && this.Vida > 0)
            {
                int dano = this.Ataque;
                int defensaObjetivo = personaje.Defensa;
                foreach (Item objeto in this.Inventario)
                {
                    dano += objeto.Ataque;
                }
                foreach (Item objeto in personaje.Inventario)
                {
                    defensaObjetivo += objeto.Defensa;
                }
                dano -= defensaObjetivo;

                if (dano >= 0)
                {
                    personaje.Vida -= dano;
                }
            }
        }
        public void curar(IPersonaje personaje)
        {
            if (personaje.Vida > 0 && this.Vida > 0)
            {
                bool puedeCurar = false;
                foreach (Item objeto in this.Inventario)
                {
                    if (objeto.Tipo == "Curativo")
                    {
                        puedeCurar = true;
                    }
                }
                if (puedeCurar)
                {
                    personaje.Vida = personaje.VidaInicial;
                }
            }
        }

        public void agregarItem(Item item)
        {
            if (item.Compatible.Contains(this.Raza))
            {
                this.Inventario.Add(item);
            }
        }

        public void quitarItem(Item item)
        {
            this.Inventario.Remove(item);
        }






        //Getters and Setters
        public string Nombre { get => Nombre; set => Nombre = value; }
        public Raza Raza { get => Raza; set => Raza = value; }
        public int Vida { get => Vida; set => Vida = value; }
        public int Ataque { get => Ataque; set => Ataque = value; }
        public int Defensa { get => Defensa; set => Defensa = value; }
        public ArrayList Inventario { get => Inventario; set => Inventario = value; }
        public int VidaInicial { get => VidaInicial; set => VidaInicial = value; }


    }
}