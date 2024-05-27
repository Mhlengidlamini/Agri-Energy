using System.ComponentModel.DataAnnotations;

namespace Agri_Energy.Model
{
    public class Product
    {
        [Key]
        public int product_id { get; set; }
        public string product_name { get; set; }
        public string category { get; set; }
        public DateTime production_date { get; set; }
        public int farmer_id { get; set; }
    }
}
