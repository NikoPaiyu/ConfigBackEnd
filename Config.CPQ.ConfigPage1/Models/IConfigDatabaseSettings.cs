namespace Config.CPQ.ConfigPage.Models
{
    public interface IConfigDatabaseSettings
    {
        string ConfigCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
