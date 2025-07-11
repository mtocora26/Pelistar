using System.Collections.Generic;
using System.Linq;

namespace Pelistar.Clases
{
    public class GestorContenido
    {

        private List<Contenido> contenidos = new List<Contenido>();

        public GestorContenido() {}

        public GestorContenido(List<Contenido> contenidos)
        {
            this.contenidos = contenidos ?? new List<Contenido>();
        }

        public void AgregarContenido(Contenido c)
        {
            contenidos.Add(c);
        }

        public bool EliminarContenido(int id)
        {
            var contenido = contenidos.FirstOrDefault(x => x.Id == id);
            if (contenido != null)
            {
                contenidos.Remove(contenido);
                return true;
            }
            return false;
        }

        public List<Contenido> BuscarPorNombre(string nombre)
        {
            return contenidos.Where(x => x.Titulo.Contains(nombre)).ToList();
        }

        public List<Contenido> FiltrarPorEstado(Estado e)
        {
            return contenidos.Where(x => x.Estado == e).ToList();
        }

        public List<Contenido> FiltrarPorGenero(string g)
        {
            return contenidos.Where(x => x.Genero == g).ToList();
        }

        public List<Contenido> ObtenerFavoritos()
        {
            return contenidos.Where(x => x.EsFavorito).ToList();
        }

        public List<Contenido> ObtenerTodos()
        {
            return new List<Contenido>(contenidos);
        }
    }
}
