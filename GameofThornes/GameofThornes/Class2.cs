using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace GameofThornes
{
    public class Class2
    {
        public string name { get; set; }
        public string slug { get; set; }
        public House2 house { get; set; }
        public List<string> quotes { get; set; }
    }

    public class House2
    {
        public string slug { get; set; }
        public string name {get; set; }
    }
}
