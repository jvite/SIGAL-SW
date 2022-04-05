using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionInventario.Datos
{
    public class Proveedores
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string razonsocial { get; set; }
        public string rubrogiro { get; set; }
        public string calle { get; set; }
        public string numeroexterior { get; set; }
        public string numerointerior { get; set; }
        public string colonia { get; set; }
        public string municipio { get; set; }
        public string estado { get; set; }
        public string codigopostal { get; set; }
        public string telefono1 { get; set; }
        public string telefono2 { get; set; }
        public string correo1 { get; set; }
        public string correo2 { get; set; }
        public string rfc { get; set; }
        public string estatus { get; set; }

        public Proveedores() { }

        public Proveedores(int id, string nombre, string apellidos, string razonsocial, string rubrogiro, string calle, string numeroexterior, string numerointerior, string colonia, string municipio, string estado, string codigopostal, string telefono1, string telefono2, string correo1, string correo2, string rfc, string estatus)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.razonsocial = razonsocial;
            this.rubrogiro = rubrogiro;
            this.calle = calle;
            this.numeroexterior = numeroexterior;
            this.numerointerior = numerointerior;
            this.colonia = colonia;
            this.municipio = municipio;
            this.estado = estado;
            this.codigopostal = codigopostal;
            this.telefono1 = telefono1;
            this.telefono2 = telefono2;
            this.correo1 = correo1;
            this.correo2 = correo2;
            this.rfc = rfc;
            this.estatus = estatus;
        }
    }
}
