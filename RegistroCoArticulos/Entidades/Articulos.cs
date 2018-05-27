using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace RegistroCoArticulos.Entidades
{
    public class Articulos
    {
        [Key]

        public int ArticulosId { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string Descripcion { get; set; }
        public int Existencia { get; set; }
        public int Precio { get; set; }
        public int CantidadCotizada { get; set; } 


        public Articulos()
        {
            ArticulosId = 0;
            FechaVencimiento = DateTime.Now;
            Descripcion = string.Empty;
            Existencia = 0;
            Precio = 0;
            CantidadCotizada = 0;
        }
    }
}
