using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace ApiCliente.Servicios
{
    public class ClienteService : ICliente
    {
        private readonly ClienteDBContext _db;

        public ClienteService(ClienteDBContext db)
        {
            _db = db;
        }

        public string Login(string userEmail, string password)
        {
            var option = new SqlParameter("@Option", 2);
            var emailParameter = new SqlParameter("@Email", userEmail);
            var passwordParamter = new SqlParameter("@Password", password);
            string respuesta = string.Empty;
            var resultado = new ResultadoData();
            resultado = _db.ResultadoData.FromSqlRaw("dbo.sp_login @Option,@Email,@Password", parameters: new[] { option, emailParameter, passwordParamter }).ToList().FirstOrDefault();
            return resultado.Resultado;
        }
    }
}
