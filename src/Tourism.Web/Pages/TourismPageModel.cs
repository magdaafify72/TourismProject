using Tourism.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Tourism.Web.Pages;

public abstract class TourismPageModel : AbpPageModel
{
    protected TourismPageModel()
    {
        LocalizationResourceType = typeof(TourismResource);
    }
}
