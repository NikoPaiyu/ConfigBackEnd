namespace Config.CPQ.OpportunityInfo.Models
{
    public interface IInfoDatabaseSettings
    {
        string InfoCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
