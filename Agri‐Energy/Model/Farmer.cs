using System.ComponentModel.DataAnnotations;

namespace Agri_Energy.Model
{
    public class Farmer
    {
        [Key]
        public int farmer_id { get; set; }
        public string name { get; set; }
        public string location { get; set; }
        public string contact_number { get; set; }
    }
}
