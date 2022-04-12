// See https://aka.ms/new-console-template for more information
using Class03.ClassMaterial;


Console.WriteLine("Hello, World!");

GenericMethods genericMethods = new GenericMethods();

genericMethods.PrintObject("Something", 55);
genericMethods.PrintObject(DateTime.Now, 2.535);
genericMethods.PrintObject(33, "A");

Console.WriteLine("====================== NON GENERIC (4 methods) =======================");

NonGenericHelper nonGenericHelper = new NonGenericHelper();

nonGenericHelper.GoThroughList(new List<string> { "Abv", "BBB", "VVV" });
nonGenericHelper.GetInfoForList(new List<string> { "Abv", "BBB", "VVV" });

nonGenericHelper.GoThroughList(new List<int> { 1, 2, 3 });
nonGenericHelper.GetInfoForList(new List<int> { 1, 2, 3 });

Console.WriteLine("====================== GENERIC (2 methods) =======================");

GenericMEthodHelper genericMEthodHelper = new GenericMEthodHelper();

genericMEthodHelper.GoThroughList(new List<string> { "Abv", "BBB", "VVV" });
genericMEthodHelper.GetInfoForList(new List<string> { "Abv", "BBB", "VVV" });
genericMEthodHelper.GoThroughList(new List<int> { 1, 2, 3, 4, 5 });
genericMEthodHelper.GetInfoForList(new List<int> { 1, 2, 3, 4, 5 });

Console.WriteLine("====================== GENERIC CLASS =======================");

GenericClass<bool> genericBool = new GenericClass<bool>(true);
genericBool.PrintPropertyTypeAndValue();
GenericClass<double> genericDouble = new GenericClass<double>(0.324234333333332423423234);
genericDouble.PrintPropertyTypeAndValue();



Console.WriteLine("=============================================");

GenericDB<Product> genericDB = new GenericDB<Product>();

genericDB.Add(new Product { Id = 1, Title = "Book 1", Description = "CSharp Advanced" });
genericDB.Add(new Product { Id = 2, Title = "Book 2", Description = "CSharp Basic" });
genericDB.Add(new Product { Id = 3, Title = "Book 3", Description = "JS Advanced" });

Console.WriteLine("=============================================");

GenericDB<Order> orderDb = new GenericDB<Order>();

orderDb.Add(new Order { Id = 1, ProductName = new Product { Id = 1, Title = "Book 1", Description = "CSharp Advanced" }, Address = "CSharp Advanced" });
orderDb.Add(new Order { Id = 2, ProductName = new Product { Id = 2, Title = "Book 2", Description = "CSharp Basic" }, Address = "CSharp Basic" });
orderDb.Add(new Order { Id = 3, ProductName = new Product { Id = 3, Title = "Book 3", Description = "JS Advanced" }, Address = "JS Advanced" });

Console.WriteLine("====================Products=========================");
//genericDB.PrintInfo();
Console.WriteLine("=====================Orders========================");
orderDb.PrintInfo();



Console.ReadLine();