using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Confiq.Cpq.Line.Models
{
    public class FinalClass
    {
        public Header colDef { get; set; }
        public IList<Lines> rowDta { get; set; }
    }
}
