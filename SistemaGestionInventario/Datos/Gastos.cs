using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionInventario.Datos
{
    public class Gastos
    {
        public int id { get; set; }
        public int idusuario { get; set; }
        public string concepto { get; set; }
        public string descripcion { get; set; }
        public string cantidad { get; set; }
        public string fecha { get; set; }
        public string hora { get; set; }

        public Gastos() { }

        public Gastos(int id, int idusuario, string concepto, string descripcion, string cantidad, string fecha, string hora)
        {
            this.id = id;
            this.idusuario = idusuario;
            this.concepto = concepto;
            this.descripcion = descripcion;
            this.cantidad = cantidad;
            this.fecha = fecha;
            this.hora = hora;
        }
    }
}
