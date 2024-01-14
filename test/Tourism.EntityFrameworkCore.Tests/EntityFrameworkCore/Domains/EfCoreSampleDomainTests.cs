using Tourism.Samples;
using Xunit;

namespace Tourism.EntityFrameworkCore.Domains;

[Collection(TourismTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<TourismEntityFrameworkCoreTestModule>
{

}
