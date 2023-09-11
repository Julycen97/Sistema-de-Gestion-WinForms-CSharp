using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        public Articulo()
        {
            MarcaArt = new Marca();
            CategoriaArt = new Categoria();
            ImagenArt = new List<Imagen>();
        }
        public int CodArt { get; set; }
        public string NombreArt { get; set; }
        public string DescripcionArt { get; set; }
        public Marca MarcaArt { get; set; }
        public Categoria CategoriaArt { get; set; }
        public decimal PrecioArt { get; set; }
        public List<Imagen> ImagenArt { get; set; }
    }
}
