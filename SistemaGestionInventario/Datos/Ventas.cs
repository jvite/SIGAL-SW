using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionInventario.Datos
{
    public class Ventas
    {
        public int id { get; set; }
        public int idproducto { get; set; }
        public int idusuario { get; set; }
        public string cantidad { get; set; }
        public string precio { get; set; }
        public string iva { get; set; }
        public string fecha { get; set; }
        public string hora { get; set; }

        public Ventas() { }

        public Ventas(int id, int idproducto, int idusuario, string cantidad, string precio, string iva, string fecha, string hora)
        {
            this.id = id;
            this.idproducto = idproducto;
            this.idusuario = idusuario;
            this.cantidad = cantidad;
            this.precio = precio;
            this.iva = iva;
            this.fecha = fecha;
            this.hora = hora;
        }
    }
}
