namespace Config.CPQ.QuoteSettings.Models
{
    public interface IQuoteDatabaseSettings
    {
        string QuoteCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
