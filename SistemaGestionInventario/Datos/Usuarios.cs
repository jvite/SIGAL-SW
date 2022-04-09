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
    }
}