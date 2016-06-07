using PentiaCodeTest.Models;

namespace PentiaCodeTest.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PentiaCodeTest.Models.SalesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(PentiaCodeTest.Models.SalesContext context)
        {
            context.CarMakes.AddOrUpdate(x => x.Id,
                new CarMake { Id = 1, Name = "Volvo" },
                new CarMake { Id = 2, Name = "Saab" },
                new CarMake { Id = 3, Name = "BMW" }
            );
            context.CarModels.AddOrUpdate(x => x.Id,
                new CarModel { Id = 1, Name = "V70", CarMakeId = 1 },
                new CarModel { Id = 2, Name = "V60", CarMakeId = 1 },
                new CarModel { Id = 3, Name = "V50", CarMakeId = 1 },
                new CarModel { Id = 4, Name = "V40", CarMakeId = 1 },
                new CarModel { Id = 5, Name = "V30", CarMakeId = 1 },

                new CarModel { Id = 6, Name = "900", CarMakeId = 2 },
                new CarModel { Id = 7, Name = "900SE", CarMakeId = 2 },
                new CarModel { Id = 8, Name = "95", CarMakeId = 2 },
                new CarModel { Id = 9, Name = "95 Aero", CarMakeId = 2 },
                new CarModel { Id = 10, Name = "9000", CarMakeId = 2 },

                new CarModel { Id = 11, Name = "M3", CarMakeId = 3 },
                new CarModel { Id = 12, Name = "230", CarMakeId = 3 },
                new CarModel { Id = 13, Name = "640", CarMakeId = 3 },
                new CarModel { Id = 14, Name = "i3", CarMakeId = 3 },
                new CarModel { Id = 15, Name = "M6", CarMakeId = 3 }
            );
            context.Persons.AddOrUpdate(x => x.Id,
                new SalesPerson { Id = 1, Name = "Russell", Surname = "Smith", JobTitle = "Physical Therapy Assistant", Address = "3 Surrey Plaza", Salary = 515.97 },
                new SalesPerson { Id = 2, Name = "Gerald", Surname = "Hawkins", JobTitle = "Information Systems Manager", Address = "894 Corscot Pass", Salary = 191.20 },
                new SalesPerson { Id = 3, Name = "Dorothy", Surname = "Sullivan", JobTitle = "Accounting Assistant I", Address = "3235 Prairie Rose Way", Salary = 277.93 },
                new SalesPerson { Id = 4, Name = "Jonathan", Surname = "Cruz", JobTitle = "Geological Engineer", Address = "312 Tomscot Avenue", Salary = 743.47 },
                new SalesPerson { Id = 5, Name = "Jennifer", Surname = "Ellis", JobTitle = "General Manager", Address = "00 Drewry Park", Salary = 470.57 },
                new SalesPerson { Id = 6, Name = "David", Surname = "Johnston", JobTitle = "Dental Hygienist", Address = "2 Thompson Street", Salary = 671.56 },
                new SalesPerson { Id = 7, Name = "Kevin", Surname = "Gomez", JobTitle = "Legal Assistant", Address = "58 Pawling Avenue", Salary = 890.45 },
                new SalesPerson { Id = 8, Name = "Eugene", Surname = "Carroll", JobTitle = "Data Coordiator", Address = "4222 Manufacturers Pass", Salary = 913.06 },
                new SalesPerson { Id = 9, Name = "Marie", Surname = "Campbell", JobTitle = "GIS Technical Architect", Address = "25 Knutson Hill", Salary = 310.91 },
                new SalesPerson { Id = 10, Name = "Alice", Surname = "Fernandez", JobTitle = "Account Coordinator", Address = "4293 Dawn Way", Salary = 704.55 },

                new Customer { Id = 11, Name = "Martin", Surname = "Schmidt", Address = "0742 Springview Hill", DateOfBirth = new DateTime(1961, 4, 7, 11, 45, 8) },
                new Customer { Id = 12, Name = "Joseph", Surname = "Black", Address = "8 Marquette Avenue", DateOfBirth = new DateTime(1981, 10, 06, 22, 22, 48) },
                new Customer { Id = 13, Name = "Keith", Surname = "Bowman", Address = "391 Superior Circle", DateOfBirth = new DateTime(1973, 10, 31, 21, 08, 21) },
                new Customer { Id = 14, Name = "Gloria", Surname = "Gutierrez", Address = "5495 Atwood Avenue", DateOfBirth = new DateTime(1965, 8, 2, 4, 54, 33) },
                new Customer { Id = 15, Name = "Gloria", Surname = "Gilbert", Address = "9832 Mitchell Lane", DateOfBirth = new DateTime(1970, 4, 28, 22, 42, 59) },
                new Customer { Id = 16, Name = "Jacqueline", Surname = "Bell", Address = "46505 Morning Pass", DateOfBirth = new DateTime(1990, 9, 26, 16, 43, 13) },
                new Customer { Id = 17, Name = "Judy", Surname = "Schmidt", Address = "7 Red Cloud Road", DateOfBirth = new DateTime(1955, 11, 18, 12, 36, 20) },
                new Customer { Id = 18, Name = "Judith", Surname = "Wheeler", Address = "747 Quincy Circle", DateOfBirth = new DateTime(1956, 6, 10, 11, 24, 41) },
                new Customer { Id = 19, Name = "Terry", Surname = "Hernandez", Address = "337 Farragut Crossing", DateOfBirth = new DateTime(1958, 1, 9, 1, 27, 2) },
                new Customer { Id = 20, Name = "Sarah", Surname = "Rodriguez", Address = "46 Annamark Way", DateOfBirth = new DateTime(1979, 1, 9, 13, 44, 11) },
                new Customer { Id = 21, Name = "Jimmy", Surname = "Smith", Address = "4078 Waywood Crossing", DateOfBirth = new DateTime(1976, 6, 22, 21, 34, 49) },
                new Customer { Id = 22, Name = "Evelyn", Surname = "Bell", Address = "33 American Ash Street", DateOfBirth = new DateTime(1978, 2, 26, 21, 9, 24) },
                new Customer { Id = 23, Name = "Mildred", Surname = "Schmidt", Address = "12 Manley Alley", DateOfBirth = new DateTime(1959, 8, 19, 17, 59, 21) },
                new Customer { Id = 24, Name = "Albert", Surname = "Foster", Address = "40 Surrey Way", DateOfBirth = new DateTime(1991, 07, 30, 10, 7, 17) },
                new Customer { Id = 25, Name = "Albert", Surname = "Foster II", Address = "40 Surrey Way", DateOfBirth = new DateTime(1991, 07, 30, 10, 7, 17) },
                new Customer { Id = 26, Name = "Joseph", Surname = "Wright", Address = "67 Killdeer Court", DateOfBirth = new DateTime(1958, 8, 21, 3, 44, 2) },
                new Customer { Id = 27, Name = "Karen", Surname = "Black", Address = "675 Trailsway Drive", DateOfBirth = new DateTime(1980, 4, 15, 12, 57, 54) },
                new Customer { Id = 28, Name = "Julie", Surname = "Clark", Address = "6394 Wayridge Point", DateOfBirth = new DateTime(1977, 6, 11, 12, 08, 33) },
                new Customer { Id = 29, Name = "William", Surname = "Patterson", Address = "5 Sunnyside Court", DateOfBirth = new DateTime(1959, 7, 12, 0, 31, 02) },
                new Customer { Id = 30, Name = "Alice", Surname = "Ray", Address = "8612 Stoughton Circle", DateOfBirth = new DateTime(1990, 6, 10, 4, 47, 30) }
            );
            context.Cars.AddOrUpdate(x => x.Id,
                new Car { Id = 1, CarMakeId = 1, CarModelId = 1, Colour = "Red", RecommendPrice = 100000 },
                new Car { Id = 2, CarMakeId = 1, CarModelId = 2, Colour = "White", RecommendPrice = 100000 },
                new Car { Id = 3, CarMakeId = 3, CarModelId = 11, Colour = "White", RecommendPrice = 380000 },
                new Car { Id = 4, CarMakeId = 2, CarModelId = 6, Colour = "Blue", RecommendPrice = 74600 },
                new Car { Id = 5, CarMakeId = 3, CarModelId = 14, Colour = "Black", RecommendPrice = 121000 },
                new Car { Id = 6, CarMakeId = 1, CarModelId = 3, Colour = "Red", RecommendPrice = 126600 },
                new Car { Id = 7, CarMakeId = 2, CarModelId = 10, Colour = "Grey", RecommendPrice = 320115 },
                new Car { Id = 8, CarMakeId = 2, CarModelId = 9, Colour = "Blue", RecommendPrice = 246000 },
                new Car { Id = 9, CarMakeId = 1, CarModelId = 5, Colour = "White", RecommendPrice = 189000 },
                new Car { Id = 10, CarMakeId = 3, CarModelId = 15, Colour = "Blue", RecommendPrice = 218500 },
                new Car { Id = 11, CarMakeId = 2, CarModelId = 7, Colour = "Yellow", RecommendPrice = 301500 },
                new Car { Id = 12, CarMakeId = 1, CarModelId = 2, Colour = "Green", RecommendPrice = 364000 },
                new Car { Id = 13, CarMakeId = 1, CarModelId = 1, Colour = "Blue", RecommendPrice = 164500 },
                new Car { Id = 14, CarMakeId = 3, CarModelId = 13, Colour = "White", RecommendPrice = 175000 },
                new Car { Id = 15, CarMakeId = 2, CarModelId = 9, Colour = "Black", RecommendPrice = 138000 },
                new Car { Id = 16, CarMakeId = 3, CarModelId = 12, Colour = "Blue", RecommendPrice = 168700 },
                new Car { Id = 17, CarMakeId = 3, CarModelId = 14, Colour = "Green", RecommendPrice = 198000 },
                new Car { Id = 18, CarMakeId = 1, CarModelId = 4, Colour = "White", RecommendPrice = 13800 },
                new Car { Id = 19, CarMakeId = 2, CarModelId = 6, Colour = "Red", RecommendPrice = 86000 },
                new Car { Id = 20, CarMakeId = 2, CarModelId = 7, Colour = "Black", RecommendPrice = 364000 },
                new Car { Id = 21, CarMakeId = 3, CarModelId = 11, Colour = "Grey", RecommendPrice = 97000 },
                new Car { Id = 22, CarMakeId = 2, CarModelId = 6, Colour = "Red", RecommendPrice = 183000 },
                new Car { Id = 23, CarMakeId = 1, CarModelId = 2, Colour = "Black", RecommendPrice = 246000 },
                new Car { Id = 24, CarMakeId = 2, CarModelId = 10, Colour = "Yellow", RecommendPrice = 19600 },
                new Car { Id = 25, CarMakeId = 1, CarModelId = 4, Colour = "Black", RecommendPrice = 128000 },
                new Car { Id = 26, CarMakeId = 3, CarModelId = 14, Colour = "Blue", RecommendPrice = 367000 },
                new Car { Id = 27, CarMakeId = 2, CarModelId = 8, Colour = "Black", RecommendPrice = 268000 }
            );
            context.CarPurchases.AddOrUpdate(x => x.Id,
                new CarPurchase { Id = 1, CarId = 14, CustomerId = 29, SalesPersonId = 9, OrderDate = new DateTime(2014, 5, 9, 21, 45, 11), PricePaid = 80575 },
                new CarPurchase { Id = 2, CarId = 15, CustomerId = 15, SalesPersonId = 10, OrderDate = new DateTime(2005, 12, 22, 5, 20, 20), PricePaid = 206561 },
                new CarPurchase { Id = 3, CarId = 10, CustomerId = 24, SalesPersonId = 10, OrderDate = new DateTime(2016, 1, 18, 21, 43, 22), PricePaid = 160211 },
                new CarPurchase { Id = 4, CarId = 22, CustomerId = 28, SalesPersonId = 2, OrderDate = new DateTime(2007, 6, 3, 20, 12, 21), PricePaid = 259902 },
                new CarPurchase { Id = 5, CarId = 20, CustomerId = 24, SalesPersonId = 7, OrderDate = new DateTime(2003, 8, 19, 16, 36, 45), PricePaid = 113215 },
                new CarPurchase { Id = 6, CarId = 2, CustomerId = 27, SalesPersonId = 5, OrderDate = new DateTime(2015, 8, 27, 15, 25, 54), PricePaid = 220922 },
                new CarPurchase { Id = 7, CarId = 24, CustomerId = 16, SalesPersonId = 10, OrderDate = new DateTime(2013, 5, 31, 16, 58, 47), PricePaid = 261350 },
                new CarPurchase { Id = 8, CarId = 27, CustomerId = 12, SalesPersonId = 8, OrderDate = new DateTime(2007, 1, 24, 00, 12, 25), PricePaid = 317955 },
                new CarPurchase { Id = 9, CarId = 26, CustomerId = 24, SalesPersonId = 8, OrderDate = new DateTime(2010, 3, 14, 13, 15, 5), PricePaid = 366302 },
                new CarPurchase { Id = 10, CarId = 25, CustomerId = 29, SalesPersonId = 8, OrderDate = new DateTime(2011, 5, 17, 23, 36, 11), PricePaid = 267112 },
                new CarPurchase { Id = 11, CarId = 1, CustomerId = 25, SalesPersonId = 7, OrderDate = new DateTime(2006, 12, 22, 5, 25, 21), PricePaid = 265130 },
                new CarPurchase { Id = 12, CarId = 9, CustomerId = 28, SalesPersonId = 5, OrderDate = new DateTime(2005, 12, 13, 20, 54, 13), PricePaid = 112994 },
                new CarPurchase { Id = 13, CarId = 4, CustomerId = 18, SalesPersonId = 5, OrderDate = new DateTime(2010, 4, 5, 3, 36, 41), PricePaid = 98418 },
                new CarPurchase { Id = 14, CarId = 12, CustomerId = 14, SalesPersonId = 9, OrderDate = new DateTime(2011, 2, 17, 14, 48, 43), PricePaid = 170384 },
                new CarPurchase { Id = 15, CarId = 6, CustomerId = 22, SalesPersonId = 10, OrderDate = new DateTime(2008, 4, 30, 10, 12, 24), PricePaid = 114066 },
                new CarPurchase { Id = 16, CarId = 23, CustomerId = 25, SalesPersonId = 9, OrderDate = new DateTime(2014, 9, 5, 15, 43, 42), PricePaid = 130597 },
                new CarPurchase { Id = 17, CarId = 19, CustomerId = 20, SalesPersonId = 10, OrderDate = new DateTime(2011, 2, 10, 13, 41, 50), PricePaid = 189052 },
                new CarPurchase { Id = 18, CarId = 16, CustomerId = 24, SalesPersonId = 8, OrderDate = new DateTime(2010, 7, 18, 11, 40, 47), PricePaid = 272203 },
                new CarPurchase { Id = 19, CarId = 17, CustomerId = 25, SalesPersonId = 2, OrderDate = new DateTime(2014, 3, 6, 6, 26, 10), PricePaid = 315951 },
                new CarPurchase { Id = 20, CarId = 22, CustomerId = 28, SalesPersonId = 5, OrderDate = new DateTime(2014, 1, 17, 8, 7, 36), PricePaid = 299057 }
            );
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
