using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PentiaCodeTest.Models
{
    public class Car {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int CarMakeId { get; set; }
        public int CarModelId { get; set; }
        public string Colour { get; set; }
        public string Extras { get; set; }
        public double RecommendPrice { get; set; }
        [ForeignKey("CarMakeId")]
        public virtual CarMake CarMake { get; set; }
        [ForeignKey("CarModelId")]
        public virtual CarModel CarModel { get; set; }
        [InverseProperty("Car")]
        public virtual ICollection<CarPurchase> CarPurchase { get; set; }
    }
    public class CarMake
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<CarModel> CarModels { get; set; }
    }
    public class CarModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public int? CarMakeId { get; set; }
        public string Name { get; set; }

        [ForeignKey("CarMakeId")]
        public virtual CarMake CarMake { get; set; }
    }
}