using System;
using System.Collections.Generic;
using System.Data.Common.CommandTrees;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Configuration;
using System.Web;
using LinqKit;
using PentiaCodeTest.Models;

namespace PentiaCodeTest.Services
{
    public class SearchService
    {
        public static Expression<Func<Customer, bool>> GetCustomerSearchPredicate(CustomerSearchFormViewModel model) {
            var predicate = PredicateBuilder.True<Customer>();
            if (!string.IsNullOrEmpty(model.CustomerName)) {
                predicate = predicate.And(CustomerNamePredicate(model.CustomerName));
            }
            if (!string.IsNullOrEmpty(model.CustomerStreet)) {
                predicate = predicate.And(CustomerStreetPredicate(model.CustomerStreet));
            }
            //if (!string.IsNullOrEmpty(model.SalesPerson) && (model.CarMakeId > 0 || model.CarModelId > 0))
            //{
            //    Expression<Func<Customer, bool>> innerpredicate = PredicateBuilder.True<Customer>();
            //    innerpredicate =
            //        innerpredicate.And(
            //            cust => cust.CarPurchases.Any(b => b.SalesPerson.Name.ToLower().Contains(model.SalesPerson) ||
            //                                         model.SalesPerson.ToLower().Contains(b.SalesPerson.Name)));
            //    if (model.CarMakeId > 0) {
            //        innerpredicate = innerpredicate.And(cust => cust.CarPurchases.Any(b => b.Car.CarMakeId == model.CarMakeId));
            //    }
            //    if (model.CarModelId > 0) {
            //        innerpredicate = innerpredicate.And(cust => cust.CarPurchases.Any(b => b.Car.CarModelId == model.CarModelId));
            //    }
            //    predicate = predicate.And(innerpredicate.Expand());
            //}
            if (!string.IsNullOrEmpty(model.SalesPerson))
            {
                predicate = predicate.And(SalesPersonPredicate(model.SalesPerson));
            }
            if (model.CarMakeId > 0)
            {
                predicate = predicate.And(CarMakePredicate(model.CarMakeId));
            }
            if (model.CarModelId > 0)
            {
                predicate = predicate.And(CarModelPredicate(model.CarModelId));
            }
            return predicate;
        }

        private static Expression<Func<Customer, bool>> CustomerNamePredicate(string query)
        {
            query = query.ToLower();
            if (!query.Contains(' '))
            {
                return cust => query.Contains(cust.Surname.ToLower())
                            || cust.Name.ToLower().Contains(query)
                            || cust.Surname.ToLower().Contains(query);
                return PredicateBuilder.True<Customer>().And(a => query.Contains(a.Surname.ToLower())
                                                                  || a.Name.ToLower().Contains(query)
                                                                  || a.Surname.ToLower().Contains(query));
            }
            var names = query.Split(' ');
            var first = names.FirstOrDefault();
            var last = names.LastOrDefault();
            return cust => cust.Name.ToLower().Contains(first)
                        && cust.Surname.ToLower().Contains(last);
            return PredicateBuilder.True<Customer>().And(a => a.Name.ToLower().Contains(names.FirstOrDefault())
                                                              && a.Surname.ToLower().Contains(names.LastOrDefault()));
        }

        private static Expression<Func<Customer, bool>> CustomerStreetPredicate(string query)
        {
            query = query.ToLower();
            return cust => cust.Address.Contains(query) || query.Contains(cust.Address);
            return PredicateBuilder.True<Customer>().And(a => query.Contains(a.Address)
                                                           || a.Address.Contains(query));
        }

        private static Expression<Func<Customer, bool>> SalesPersonPredicate(string query)
        {
            query = query.ToLower();
            return cust => cust.CarPurchases.Any(b => b.SalesPerson.Name.ToLower().Contains(query)
                                                      || query.Contains(b.SalesPerson.Name.ToLower()));
        }

        private static Expression<Func<Customer, bool>> CarMakePredicate(int id)
        {
            return cust => cust.CarPurchases.Any(purchase => purchase.Car.CarMakeId == id);
        }
        private static Expression<Func<Customer, bool>> CarModelPredicate(int id)
        {
            return cust => cust.CarPurchases.Any(purchase => purchase.Car.CarModelId == id);
        }
    }
}