using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPB.Entities
{
    public class Telephone
    {
        public int IdTelephone { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
