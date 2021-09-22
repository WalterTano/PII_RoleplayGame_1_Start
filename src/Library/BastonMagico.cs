using System;

namespace Library
{
    public class BastonMagico : IMagico

    private string nombre;
    private string aplicaHechizo;

    private int bastonDaño;

    public BastonMagico(string nombre, string aplicaHechizo, int bastonDaño)
    {
        this.Nombre = nombre;
        this.AplicaHechizo = aplicaHechizo;
        this.BastonDaño = bastonDaño;
    }

}