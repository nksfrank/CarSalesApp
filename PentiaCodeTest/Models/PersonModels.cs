using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Net.Sockets;
using System.Web;

namespace PentiaCodeTest.Models
{
    public class SalesContext : DbContext {
        public SalesContext() { }
        public DbSet<Person> Persons { get; set; }
        public DbSet<CarModel> CarModels { get; set; }
        public DbSet<CarMake> CarMakes { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarPurchase> CarPurchases { get; set; }
    }

    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Display(Name = "First Name")]
        [StringLength(100, ErrorMessage = "{0} can only be {1] characters long")]
        public string Name { get; set; }
        [Display(Name = "Last Name")]
        [StringLength(100, ErrorMessage = "{0} can only be {1] characters long")]
        public string Surname { get; set; }
        public string Address { get; set; }
    }
    public class Customer : Person
    {
        [DataType(DataType.DateTime)]
        [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Created { get; set; }
        [DataType(DataType.DateTime)]
        [Display(Name="Date of Birth")]
        public DateTime DateOfBirth { get; set; }
        public int Age
        {
            get
            {
                var today = DateTime.Today;
                var age = today.Year - DateOfBirth.Year;
                if (DateOfBirth > today.AddYears(-age))
                    age--;
                return age;
            }
        }
        [InverseProperty("Customer")]
        public virtual ICollection<CarPurchase> CarPurchases { get; set; }
    }
    public class SalesPerson : Person
    {
        [Display(Name="Job Title")]
        public string JobTitle { get; set; }
        public double Salary { get; set; }
        [InverseProperty("SalesPerson")]
        public virtual ICollection<CarPurchase> CarSales { get; set; }
    }
}