using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
