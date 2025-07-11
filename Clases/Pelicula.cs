namespace Pelistar.Clases
{
    public class Pelicula : Contenido
    {
        public int DuracionMinutos { get; set; }

        public Pelicula() : base() {}

        public Pelicula(int id, string titulo, string director, int anio, bool esFavorito, double calificacion, string genero, Estado estado, int duracionMinutos)
            : base(id, titulo, director, anio, esFavorito, calificacion, genero, estado)
        {
            DuracionMinutos = duracionMinutos;
        }

        public override void CambiarEstado(Estado e)
        {
            Estado = e;
        }

        public override void MarcarComoFavorito()
        {
            EsFavorito = true;
        }

        public override void QuitarDeFavoritos()
        {
            EsFavorito = false;
        }
    }
}
