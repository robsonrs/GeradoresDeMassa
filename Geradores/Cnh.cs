using GeradoresDeMassa.Helpers;
using GeradoresDeMassa.Models;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace GeradoresDeMassa.Geradores
{
    public static class Cnh
    {
        public static GeradorRetorno GerarCnh()
        {
            string retorno = Request.Get("https://geradorbrasileiro.com/api/faker/cnh");
            
            GeradorRetorno resultado = JsonSerializer.Deserialize<GeradorRetorno>(retorno);
            return resultado;
        }
    }
}