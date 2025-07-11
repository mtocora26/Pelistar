namespace Pelistar.Clases
{
    public class Serie : Contenido
    {
        public int Temporadas { get; set; }
        public int EpisodiosTotales { get; set; }

        public Serie() : base() {}

        public Serie(int id, string titulo, string director, int anio, bool esFavorito, double calificacion, string genero, Estado estado, int temporadas, int episodiosTotales)
            : base(id, titulo, director, anio, esFavorito, calificacion, genero, estado)
        {
            Temporadas = temporadas;
            EpisodiosTotales = episodiosTotales;
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
