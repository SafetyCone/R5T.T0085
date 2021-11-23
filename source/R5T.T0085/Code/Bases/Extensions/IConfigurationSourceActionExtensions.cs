using System;

using Microsoft.Extensions.Configuration;

using R5T.T0080;
using R5T.T0081;
using R5T.T0085;


namespace System
{
    public static class IConfigurationSourceActionExtensions
    {
        public static IConfigurationSourceAction<ApplicationSettingsJsonFile> AddApplicationSettingsJsonFileAction(this IConfigurationSourceAction _,
            string applicationSettingsJsonFilePath,
            bool optional = ConfigurationConventions.DefaultOptionality)
        {
            var output = _.New<ApplicationSettingsJsonFile>(configurationBuilder => configurationBuilder.AddApplicationSettingsJsonFile(
                applicationSettingsJsonFilePath,
                optional));

            return output;
        }
    }
}
