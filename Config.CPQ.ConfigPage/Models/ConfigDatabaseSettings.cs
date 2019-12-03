namespace Config.CPQ.ConfigPage.Models
{
    public class ConfigDatabaseSettings : IConfigDatabaseSettings
    {
        public string ConfigCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }


}