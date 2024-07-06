using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutosalloniBlendi.Models
{
    internal class VeturatRent
    {
        public int Id { get; set; }
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public int TotalDays { get; set; }
        public DateTime RentingDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public decimal PricePerDay { get; set; }
        public string PickupLocation { get; set; }
        public string RentingStatus { get; set; }

        public VeturatRent()
        {

        }
    }
}
