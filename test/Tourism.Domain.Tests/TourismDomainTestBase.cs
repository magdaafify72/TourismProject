using Volo.Abp.Modularity;

namespace Tourism;

/* Inherit from this class for your domain layer tests. */
public abstract class TourismDomainTestBase<TStartupModule> : TourismTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
