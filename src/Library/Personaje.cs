using System;
using System.Collections;

namespace TierraMedia
{
    class Personaje
    {
        private string nombre;
        private string raza;
        private int vida;
        private int ataque;
        private int defensa;
        private ArrayList inventario;

        public Personaje(string nombre, string raza, int vida, int ataque, int defensa)
        {
            this.Nombre = nombre;
            this.Raza = raza;
            this.Vida = vida;
            this.Ataque = ataque;
            this.Defensa = defensa;
        }

        public void Atacar(Personaje objetivo)
        {
            if(objetivo.Vida > 0 && this.Vida > 0){
                int dano = this.Ataque;
                int defensaObjetivo = objetivo.Defensa;
                foreach(Item objeto in this.Inventario){
                    dano += objeto.Ataque;
                }
                foreach(Item objeto in objetivo.Inventario){
                    defensaObjetivo += objeto.Defensa;
                }
                dano -= defensaObjetivo;

                if(dano >= 0){
                    objetivo.Vida -= dano;
                }
            }
        }

        public void Curar(Personaje objetivo)
        {
            bool puedeCurar = false;
            foreach(Item objeto in this.Inventario){

            }
            if(objetivo.Vida > 0 && this.Vida > 0){
                int dano = this.Ataque;
                int defensaObjetivo = objetivo.Defensa;
                foreach(Item objeto in this.Inventario){
                    dano += objeto.Ataque;
                }
                foreach(Item objeto in objetivo.Inventario){
                    defensaObjetivo += objeto.Defensa;
                }
                dano -= defensaObjetivo;

                if(dano >= 0){
                    objetivo.Vida -= dano;
                }
            }
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Raza { get => raza; set => raza = value; }
        public int Vida { get => vida; set => vida = value; }
        public int Ataque { get => ataque; set => ataque = value; }
        public int Defensa { get => defensa; set => defensa = value; }
        public ArrayList Inventario { get => inventario; set => inventario = value; }
    }
}