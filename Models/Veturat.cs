using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutosalloniBlendi.Models
{
    internal class Veturat
    {
        public int Id { get; set; }
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public int CarYear { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string CarColor { get; set; }
        public int Horspower { get; set; }
        public string FuelType { get; set; }
        public int Distance { get; set; }
        public string Engine {  get; set; }
        public decimal Price { get; set; }
        public DateTime OfferDate { get; set; }
        public bool IsUsed { get; set; }
        public string Status { get; set; }

        public Veturat() { }
    }
}
