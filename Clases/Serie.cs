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
    public override void cambiarEstado(Estado nuevoEstado)
        {
            estado = nuevoEstado;
            Console.WriteLine($"[Serie] El estado de la serie cambió a: {estado}");
        }

        public override void marcarComoFavorito()
        {
            esFavorito = true;
            Console.WriteLine("[Serie] Has marcado la serie como favorita.");
        }

        public override void quitarDeFavoritos()
        {
            esFavorito = false;
            Console.WriteLine("[Serie] La serie ya no está en favoritos.");
        }
    }
}    
