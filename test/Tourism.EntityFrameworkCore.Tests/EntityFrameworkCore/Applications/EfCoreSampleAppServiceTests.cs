using Tourism.Samples;
using Xunit;

namespace Tourism.EntityFrameworkCore.Applications;

[Collection(TourismTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<TourismEntityFrameworkCoreTestModule>
{

}
