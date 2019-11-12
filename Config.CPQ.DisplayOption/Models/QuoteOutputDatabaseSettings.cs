namespace Config.CPQ.QuoteOutput.Models
{
    public class QuoteOutputDatabaseSettings:IQuoteOutputDatabaseSettings
    {
        public string QuoteOutputCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
