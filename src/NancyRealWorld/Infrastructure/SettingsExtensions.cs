using Microsoft.Extensions.Configuration;

namespace NancyRealWorld.Infrastructure
{
    public static class SettingsExtensions
    {
        public static TSettingModel RegisterSetting<TSettingModel>(this IConfigurationRoot configurationRoot, string sectionName) where TSettingModel : class, new()
        {
            var model = new TSettingModel();
            configurationRoot.GetSection(sectionName).Bind(model);
            return model;
        }
    }
}