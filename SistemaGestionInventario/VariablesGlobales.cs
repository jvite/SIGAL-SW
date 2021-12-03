using System;

namespace SistemaGestionInventario
{
    public class VariablesGlobales
    {
        bool EstadoSesion = false;
        bool ModificacionesRealizadas = false;

        public bool CambiarEstado()
        {
            if (EstadoSesion == true)
            {
                EstadoSesion = false;
            }
            else
            {
                EstadoSesion = false;
            }

            return EstadoSesion;
        }

        public bool CambiosRealizados()
        {
            if (ModificacionesRealizadas == true)
            {
                ModificacionesRealizadas = false;
            }
            else
            {
                ModificacionesRealizadas = true;
            }
            return ModificacionesRealizadas;
        }
    }
}
