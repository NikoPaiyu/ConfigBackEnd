namespace Config.CPQ.Models
{
    public class CustomerDatabaseSettings: ICustomerDatabaseSettings
    {
        public string CustomerCollectionName { get;set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
