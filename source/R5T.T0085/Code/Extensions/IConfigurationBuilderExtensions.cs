using System;

using Microsoft.Extensions.Configuration;


namespace R5T.T0085
{
    public static class IConfigurationBuilderExtensions
    {
        public static IConfigurationBuilder AddApplicationSettingsJsonFile(this IConfigurationBuilder configurationBuilder,
            string applicationSettingsJsonFilePath,
            bool optional = ConfigurationConventions.DefaultOptionality)
        {
            configurationBuilder.AddJsonFile(applicationSettingsJsonFilePath, optional);

            return configurationBuilder;
        }
    }
}
