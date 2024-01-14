using System;
using System.Collections.Generic;
using System.Text;
using Tourism.Localization;
using Volo.Abp.Application.Services;

namespace Tourism;

/* Inherit your application services from this class.
 */
public abstract class TourismAppService : ApplicationService
{
    protected TourismAppService()
    {
        LocalizationResource = typeof(TourismResource);
    }
}
