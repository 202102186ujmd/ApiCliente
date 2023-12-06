using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace ApiCliente
{
    public class ClienteDBContext : DbContext
    {
        public ClienteDBContext(DbContextOptions<ClienteDBContext>options):base(options)
        {
            
        }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<ResultadoData> ResultadoData { get; set; }
    }

    public class ResultadoData
    {
        [Key]
        
        public string? Resultado { get; set; }
    }
}
