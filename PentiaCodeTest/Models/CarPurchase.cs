using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PentiaCodeTest.Models
{
    public class CarPurchase {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int CarId { get; set; }
        public int SalesPersonId { get; set; }
        public DateTime OrderDate { get; set; }
        public double PricePaid { get; set; }
        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }
        [ForeignKey("CarId")]
        public virtual Car Car { get; set; }
        [ForeignKey("SalesPersonId")]
        public virtual SalesPerson SalesPerson { get; set; }
    }
}