using System;

namespace Pelistar.Clases
{
    public abstract class Contenido
    {

        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Director { get; set; }
        public int Anio { get; set; }
        public bool EsFavorito { get; set; }
        public double Calificacion { get; set; }
        public string Genero { get; set; }
        public Estado Estado { get; set; }

        public Contenido() {}

        public Contenido(int id, string titulo, string director, int anio, bool esFavorito, double calificacion, string genero, Estado estado)
        {
            Id = id;
            Titulo = titulo;
            Director = director;
            Anio = anio;
            EsFavorito = esFavorito;
            Calificacion = calificacion;
            Genero = genero;
            Estado = estado;
        }

    public virtual void cambiarEstado(Estado nuevoEstado)
        {
            estado = nuevoEstado;
            Console.WriteLine($"[Contenido] El estado se cambió a: {estado}");
        }

        public virtual void marcarComoFavorito()
        {
            esFavorito = true;
            Console.WriteLine("[Contenido] Marcado como favorito.");
        }

        public virtual void quitarDeFavoritos()
        {
            esFavorito = false;
            Console.WriteLine("[Contenido] Quitado de favoritos.");
        }
    }
}
