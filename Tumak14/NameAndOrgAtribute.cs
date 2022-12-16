using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumak14
{
    class NameAndOrgAtribute : System.Attribute
    {
        public string Name { get; }
        public string Organization { get; set; }
        public NameAndOrgAtribute(string name, string organization)
        {
            Name = name;
            Organization = organization;
        }
        public NameAndOrgAtribute() { }
    }
}
