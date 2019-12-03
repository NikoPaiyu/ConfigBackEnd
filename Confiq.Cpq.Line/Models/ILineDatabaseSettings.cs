namespace Confiq.Cpq.Line.Models
{
    public interface ILineDatabaseSettings
    {
        string LineCollectionName { get; set; }
        string ProductCollectionName { get; set; }
        string HeadersCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
        
    }
}
