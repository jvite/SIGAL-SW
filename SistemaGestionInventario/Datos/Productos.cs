using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionInventario.Datos
{
    public class Productos
    {
        public int id { get; set; }
        public int idproveedor { get; set; }
        public string articulo { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string detalles { get; set; }
        public string precio { get; set; }
        public string unidExistentes { get; set; }
        public string ubicacion { get; set; }
        public string fecha { get; set; }
        public string activo { get; set; }

        public Productos() { }

        public Productos(int id, int idproveedor, string articulo, string modelo, string detalles, string precio, string unidExistentes, string ubicacion, string fecha, string activo)
        {
            this.id = id;
            this.idproveedor = idproveedor;
            this.articulo = articulo;
            this.marca = marca;
            this.modelo = modelo;
            this.detalles = detalles;
            this.precio = precio;
            this.unidExistentes = unidExistentes;
            this.ubicacion = ubicacion;
            this.fecha = fecha;
            this.activo = activo;
        }
    }
}
