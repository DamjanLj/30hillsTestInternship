using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace dataJson
{
    public class People
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string surname { get; set; }
        public int? age { get; set; }
        public string gender { get; set; }
        public List<int> friends { get; set; }
    }
}
