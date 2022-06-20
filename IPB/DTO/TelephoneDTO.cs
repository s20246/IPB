using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPB.DTO
{
    public class TelephoneDTO
    {
        public int IdTelephone { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime ReleaseDate { get; set; }

        public TelephoneDTO(int idTelephone, string brand, string model, DateTime releaseDate)
        {
            IdTelephone = idTelephone;
            Brand = brand;
            Model = model;
            ReleaseDate = releaseDate;
        }
    }
}
