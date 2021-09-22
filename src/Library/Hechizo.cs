namespace Library
{
    public class Hechizo: IHechizo
    {
        public string Elemento { get; }
        public string Nombre { get; }

        public Hechizo(string elemento, string nombre)
        {
            this.Elemento = elemento;
            this.Nombre = nombre;
        }
    }
}