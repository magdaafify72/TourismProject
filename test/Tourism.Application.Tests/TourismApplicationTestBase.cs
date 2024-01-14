using Volo.Abp.Modularity;

namespace Tourism;

public abstract class TourismApplicationTestBase<TStartupModule> : TourismTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
