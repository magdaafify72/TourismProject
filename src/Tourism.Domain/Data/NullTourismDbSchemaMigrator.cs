using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Tourism.Data;

/* This is used if database provider does't define
 * ITourismDbSchemaMigrator implementation.
 */
public class NullTourismDbSchemaMigrator : ITourismDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
