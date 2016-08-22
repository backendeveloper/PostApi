using System;
using System.Configuration;
using Common.ConfigurationInterfaces;
using Microsoft.Extensions.Configuration;
using Trendyol.Configuration.Core;

namespace Common
{
    public class Configuration : ConfigurationSection, IAuthenticationConfiguration, IConnectionStringConfiguration, IVisualMappingConfiguration
    {
        private readonly IConfigurationReader _configurationReader;

        public Configuration()
        {
            string domainName = ConfigurationManager.AppSettings["DomainName"];
            var connectionString = ConfigurationManager.ConnectionStrings["DataContext"].ToString();

            int refreshIntervalInMs;
            int.TryParse(ConfigurationManager.AppSettings["ConfigurationRefreshIntervalInMs"], out refreshIntervalInMs);

            if (!String.IsNullOrEmpty(domainName) && !string.IsNullOrEmpty(connectionString))
                _configurationReader = new ConfigurationReader(domainName, connectionString, refreshIntervalInMs);
        }

        public string ConnectionString => ConfigurationManager.ConnectionStrings["DataContext"].ToString();

        public int StoreId => 1;

        public string RedisMachines => _configurationReader.GetValue<string>("RedisMachines");

        public string VisualMappingWebUrl => _configurationReader.GetValue<string>("VisualMappingWebUrl");
    }
}