using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionInventario.Datos
{
    public class Permisos
    {
        public int id { get; set; }
        public string permiso { get; set; }

        public Permisos() { }

        public Permisos(int id, string permiso)
        {
            this.id = id;
            this.permiso = permiso;
        }
    }
}
