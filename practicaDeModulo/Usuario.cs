namespace practicaDeModulo
{
    public abstract class Rol
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Id { get; set; }

        public Rol(string nombre, string descripcion, int id)
        {
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Id = id;
        }

        public class Administrador : Rol
        {
            public Administrador() : base("Admin", "Posee acceso total del sistema", 01) { }

        }
        public class Jugador : Rol
        {
            public Jugador() : base("Jugador", "Acceso solo a la parte interactiva de juegos", 02) { }

        }

        public class Usuario
        {
            public string NombreUser { get; set; }
            public int Id { get; set; }
            public string Clave { get; set; }
            public Rol Perfil { get; set; }


            public Usuario(string nombreUser, int id, string clave, Rol perfil)
            {
                this.NombreUser = nombreUser;
                this.Id = id;
                this.Clave = clave;
                this.Perfil = perfil;
            }
        }
    }
}
