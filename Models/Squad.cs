using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationParseFiles.Models
{
    [Serializable]
    public class Squad
    {
        public string SquadName { get; set; }
        public string Metro_City { get; set; }
        public int Formed { get; set; }
        public string SecretBase { get; set; }
        public bool Active { get; set; }
        public List<Members> MyProperty { get; set; }
    }
}
