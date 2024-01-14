using Volo.Abp.Modularity;

namespace Tourism;

[DependsOn(
    typeof(TourismDomainModule),
    typeof(TourismTestBaseModule)
)]
public class TourismDomainTestModule : AbpModule
{

}
