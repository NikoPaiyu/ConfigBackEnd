namespace Config.CPQ.QuoteOutput.Models
{
    public interface IQuoteOutputDatabaseSettings
    {
        string QuoteOutputCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}