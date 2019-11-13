namespace Config.CPQ.QuoteSettings.Models
{
    public class QuoteDatabaseSettings : IQuoteDatabaseSettings
    {
        public string QuoteCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

}
