﻿using Tourism.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Caching;
using Volo.Abp.Caching.StackExchangeRedis;
using Volo.Abp.Modularity;

namespace Tourism.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AbpCachingStackExchangeRedisModule),
    typeof(TourismEntityFrameworkCoreModule),
    typeof(TourismApplicationContractsModule)
    )]
public class TourismDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpDistributedCacheOptions>(options => { options.KeyPrefix = "Tourism:"; });
    }
}
