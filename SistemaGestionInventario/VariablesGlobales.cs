using System;

namespace SistemaGestionInventario
{
    public static class VariablesGlobales
    {
        public static bool EstadoSesion = false;
        public static bool ModificacionesRealizadas = false;
        public static bool ModificacionEnCurso = false;
        public static bool AperturaCaja = false;

        public static float Caja = 0;
        public static float TotalVentas = 0;
        public static float TotalGastos = 0;
        public static float Descuentos = 0;
        public static float Impuestos = 0;

    }
}
