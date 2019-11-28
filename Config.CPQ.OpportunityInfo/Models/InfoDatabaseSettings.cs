namespace Config.CPQ.OpportunityInfo.Models
{
    public class InfoDatabaseSettings : IInfoDatabaseSettings
    {
        public string InfoCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
