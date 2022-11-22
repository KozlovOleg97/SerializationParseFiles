using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationParseFiles.Models
{
    [Serializable]
    public class Members
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string secretIdentity { get; set; }
        public List<string> Powers { get; set; }
        
    }
}
