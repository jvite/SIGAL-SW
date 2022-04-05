using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionInventario.Datos
{
    public class Registro
    {
        public int id { get; set; }
        public int idusuario { get; set; }
        public string fecha { get; set; }
        public string hora { get; set; }
        public string accion { get; set; }

        public Registro() { }

        public Registro(int id, int idusuario, string fecha, string hora, string accion)
        {
            this.id = id;
            this.idusuario = idusuario;
            this.fecha = fecha;
            this.hora = hora;
            this.accion = accion;
        }
    }
}
