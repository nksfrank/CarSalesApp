using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace PentiaCodeTest.Models
{
    public class IndexViewModel : ICustomerSearchCriteraView, ICustomerSearchResultsView
    {
        public CustomerSearchFormViewModel CustomerSearchModel { get; set; }
        public IEnumerable<Customer> Customers { get; set; }
    }
}