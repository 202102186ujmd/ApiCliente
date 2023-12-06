using System.ComponentModel.DataAnnotations;

namespace ApiCliente
{
    public class Usuarios
    {
        [Key]
        public string? Email { get; set; }
        public byte[]? Contrasena { get; set; }
    }
}
