using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionInventario.Datos
{
    public class Caja
    {
        public int id { get; set; }
        public int idusuario { get; set; }
        public string montoinicial { get; set; }
        public string fechainicio { get; set; }
        public string horainicio { get; set; }
        public string fechacierre { get; set; }
        public string horacierre { get; set; }
        public string totalventas { get; set; }
        public string totalgastos { get; set; }
        public string impuestosrecaudados { get; set; }
        public string totalcierrecaja { get; set; }

        public Caja() { }

        public Caja(int id, int idusuario, string montoinicial, string fechainicio, string horainicio, string fechacierre, string horacierre, string totalventas, string totalgastos, string impuestosrecaudados, string totalcierrecaja) {
            this.id = id;
            this.idusuario = idusuario;
            this.montoinicial = montoinicial;
            this.fechainicio = fechainicio;
            this.horainicio = horainicio;
            this.fechacierre = fechacierre;
            this.horacierre = horacierre;
            this.totalventas = totalventas;
            this.totalgastos = totalgastos;
            this.impuestosrecaudados = impuestosrecaudados;
            this.totalcierrecaja = totalcierrecaja;
        }
    }
}
