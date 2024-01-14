using Volo.Abp.Modularity;

namespace Tourism;

[DependsOn(
    typeof(TourismApplicationModule),
    typeof(TourismDomainTestModule)
)]
public class TourismApplicationTestModule : AbpModule
{

}
