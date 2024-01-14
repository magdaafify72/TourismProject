using System.Threading.Tasks;

namespace Tourism.Data;

public interface ITourismDbSchemaMigrator
{
    Task MigrateAsync();
}
