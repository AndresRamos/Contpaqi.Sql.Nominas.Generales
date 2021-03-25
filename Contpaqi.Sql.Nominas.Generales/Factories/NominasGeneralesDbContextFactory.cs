using System.Data.SqlClient;

namespace Contpaqi.Sql.Nominas.Generales.Factories
{
    public class NominasGeneralesDbContextFactory
    {
        public const string NombreBaseDatos = "nomGenerales";

        public static NominasGeneralesDbContext CreateInstance(string contpaqiConnectionString)
        {
            var connectionStringBuilder = new SqlConnectionStringBuilder(contpaqiConnectionString)
            {
                InitialCatalog = NombreBaseDatos
            };

            return new NominasGeneralesDbContext(new SqlConnection(connectionStringBuilder.ToString()), true);
        }
    }
}