using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Tourism.Web;

[Dependency(ReplaceServices = true)]
public class TourismBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Tourism";
}
