using Library.Interfaces;
using System.Collections;

namespace Library.Negocio
{
    public class Ogro : IPersonaje
    {

        public string _nombre;
        public IRaza _raza;
        public int _vida;
        public int _ataque;
        public int _defensa;
        public ArrayList _inventario;
        public bool _vivo;
        public int _vidaInicial;
        public Ogro(string nombre, IRaza raza, int vida, int ataque, int defensa)
        {
            this.Inventario = new ArrayList();
            this.Nombre = nombre;
            this.Raza = raza;
            this.Vida = vida;
            this.VidaInicial = vida;
            this.Ataque = ataque;
            this.Defensa = defensa;
            this.Vivo = true;
        }

        public void atacar(IPersonaje personaje)
        {

            if (personaje.Vivo && this.Vivo)
            {
                int dano = this.Ataque;
                int defensaObjetivo = personaje.Defensa;
                //Lógica para calcular el daño extra de los items
                foreach (ITem item in this.Inventario)
                {
                    if (item is IOfensivo)
                    {
                        dano += item.Ataque;
                    }
                }
                foreach (ITem item in this.Inventario)
                {
                    if (item is IDefensivo)
                    {
                        defensaObjetivo += item.Defensa;
                    }
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

            if (personaje.Vivo && this.Vivo)
            {
                bool puedeCurar = false;
                foreach (ITem objeto in this.Inventario)
                {
                    /*
                    if (objeto.Tipo == "Curativo")
                    {
                        puedeCurar = true;
                    }
                    */
                }
                if (puedeCurar)
                {
                    personaje.Vida = personaje.VidaInicial;
                }
            }
        }
        public void agregarItem(ITem item)
        {
            if (item.Compatible.Contains(this.Raza))
            {
                this.Inventario.Add(item);
            }
        }

        public void quitarItem(ITem item)
        {
            this.Inventario.Remove(item);
        }






        //Getters and Setters
        public string Nombre { get => _nombre; set => _nombre = value; }
        public IRaza Raza { get => _raza; set => _raza = value; }
        public int Vida { get => _vida; set => _vida = value; }
        public int Ataque { get => _ataque; set => _ataque = value; }
        public int Defensa { get => _defensa; set => _defensa = value; }
        public ArrayList Inventario { get => _inventario; set => _inventario = value; }
        public int VidaInicial { get => _vidaInicial; set => _vidaInicial = value; }
        public bool Vivo { get => _vivo; set => _vivo = value; }



    }
}