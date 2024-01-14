using Volo.Abp.Settings;

namespace Tourism.Settings;

public class TourismSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(TourismSettings.MySetting1));
    }
}
