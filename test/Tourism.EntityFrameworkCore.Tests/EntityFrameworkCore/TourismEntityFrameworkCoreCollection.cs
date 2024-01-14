using Xunit;

namespace Tourism.EntityFrameworkCore;

[CollectionDefinition(TourismTestConsts.CollectionDefinitionName)]
public class TourismEntityFrameworkCoreCollection : ICollectionFixture<TourismEntityFrameworkCoreFixture>
{

}
