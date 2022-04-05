using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionInventario
{
    public class Usuarios
    {
        public int id { get; set; }
        public int idpermiso { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string sexo { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
        public string usuario { get; set; }
        public string contrasena { get; set; }
        public string rol { get; set; }
        public string estatus { get; set; }

        public Usuarios(){}

        public Usuarios(int id, int idpermiso, string nombre, string apellidos, string sexo, string correo, string telefono, string usuario, string contrasena, string rol, string estatus)
        {
            this.id = id;
            this.idpermiso = idpermiso;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.sexo = sexo;
            this.correo = correo;
            this.telefono = telefono;
            this.usuario = usuario;
            this.contrasena = contrasena;
            this.rol = rol;
            this.estatus = estatus;
        }
    }
}
