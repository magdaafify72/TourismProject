using Tourism.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Tourism.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class TourismController : AbpControllerBase
{
    protected TourismController()
    {
        LocalizationResource = typeof(TourismResource);
    }
}
