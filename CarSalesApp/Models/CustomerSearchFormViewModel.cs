using System.Collections.Generic;
using System.ComponentModel;

namespace PentiaCodeTest.Models
{
    public interface ICustomerSearchResultsView
    {
        IEnumerable<Customer> Customers { get; }
    }
    public interface ICustomerSearchCriteraView
    {
        CustomerSearchFormViewModel CustomerSearchModel { get; }
    }
    public class CustomerSearchFormViewModel
    {
        [DisplayName("Customer Name")]
        public string CustomerName { get; set; }
        [DisplayName("Customer Street")]
        public string CustomerStreet { get; set; }
        [DisplayName("Car Make")]
        public int CarMakeId { get; set; }
        [DisplayName("Car Model")]
        public int CarModelId { get; set; }
        [DisplayName("Sales Person")]
        public string SalesPerson { get; set; }

        public IEnumerable<CarMake> CarMakes { get; set; }
        public IEnumerable<CarModel> CarModels { get; set; }
    }
}