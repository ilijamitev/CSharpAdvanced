// See https://aka.ms/new-console-template for more information
using Class05.LinqExamples;

Console.WriteLine("Hello, World!");

List<Order> orderList = new List<Order>()
{
    new Order() { Id = 1, Name = "Order 1",Quantity = 1, Status = OrderStatus.Processing},
    new Order() { Id = 2, Name = "Order 2",Quantity = 11, Status = OrderStatus.Processing},
    new Order() { Id = 3, Name = "Order 3",Quantity = 8, Status = OrderStatus.Shipped},
    new Order() { Id = 4, Name = "Order 4",Quantity = 22, Status = OrderStatus.Delivered},
    new Order() { Id = 5, Name = "Order 5",Quantity = 12, Status = OrderStatus.Shipped},
    new Order() { Id = 6, Name = "Order 6",Quantity = 4, Status = OrderStatus.Delivered},
    new Order() { Id = 7, Name = "Order 7",Quantity = 12, Status = OrderStatus.Delivered},
    new Order() { Id = 8, Name = "Order 8",Quantity = 2, Status = OrderStatus.Shipped},
    new Order() { Id = 9, Name = "Order 9",Quantity = 33, Status = OrderStatus.Delivered},
    new Order() { Id = 10, Name = "Order 10",Quantity = 31, Status = OrderStatus.Processing},
};

List<Order> copyList = orderList.Select(x => x).ToList();


Console.WriteLine("ORIGINAL COPY LIST");
List<Order> realUndependentList = orderList.Select(x => new Order
{
    Id = x.Id,
    Name = x.Name,
    Quantity = x.Quantity,
    Status = x.Status,
}).ToList();
realUndependentList.ForEach(x => Console.WriteLine(x));

Console.WriteLine("ORIGINAL LIST");
copyList.ForEach(x => Console.WriteLine(x));        // ovveride na ToString za da funkcionira ova

copyList.FirstOrDefault(x => x.Id == 1).Name = "Order 1 Changed";  // se menuva i vo Copy i vo Original
Console.WriteLine();


int sum = orderList.Sum(x => x.Quantity);
int max = orderList.Max(x => x.Quantity);
Console.WriteLine(sum);
Console.WriteLine("ORDER WITH MAX QUANTITY");
Order orderWithMaxQuan = orderList.FirstOrDefault(x => x.Quantity == max);
Console.WriteLine(orderWithMaxQuan.Name);
Console.WriteLine(orderWithMaxQuan.Quantity);




Console.WriteLine("AVERAGE QUANTITY");
double averageQuantity = orderList.Average(x => x.Quantity);
Console.WriteLine(averageQuantity);

List<Order> aboveAverage = orderList.Where(x => x.Quantity > averageQuantity).ToList();
Console.WriteLine("ABOVE AVERAGE QUANTITY");
aboveAverage.ForEach(x => Console.WriteLine(x));

Console.ReadLine();
Console.Clear();

Console.WriteLine("\nORDERED LIST ASC");
var orderedListAsc = orderList.OrderBy(x => x.Id).ToList();
orderedListAsc.ForEach(x => Console.WriteLine(x));


Console.WriteLine("\nORDERED LIST DESC");
var orderedListDesc = orderList.OrderByDescending(x => x.Id).ToList();
orderedListDesc.ForEach(x => Console.WriteLine(x));

Console.WriteLine("\nORDERED BY STRING");
var orderedByStringDesc = orderList.OrderByDescending(x => x.Name).ToList();
orderedByStringDesc.ForEach(x => Console.WriteLine(x));




Console.ReadLine();
Console.Clear();
Console.WriteLine("\nGROUP BY");
var groupedOrders = orderList.GroupBy(x => x.Status);
foreach (var orderGrouping in groupedOrders)
{
    Console.WriteLine(orderGrouping.Key);
    foreach (var order in orderGrouping)
    {
        Console.WriteLine(order);
    }
}







Console.ReadLine();