using EF_03_Test.Entities;
using System.Net.Http.Headers;
namespace EF_03_Test
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var db = new NorthwindContext())
            {
                // Retrieve all products

                //var products = db.Products.Select(p => p).ToList();

                //foreach (var product in products)
                //{
                //    Console.WriteLine(product.ProductName);
                //}

                // 2. Find all customers in a specific city
                //var customers = db.Customers.Select(c => c).Where(c => c.City == "London").ToList();

                //foreach (var customer in customers)
                //{
                //    Console.WriteLine(customer.FirstName + " " + customer.LastName);
                //}

                // 3. List all discontinued products

                //var discontinuedProducts = db.Products.Select(p => p).Where(p => p.IsDiscontinued == true).ToList();

                //foreach (var product in discontinuedProducts)
                //{
                //    Console.WriteLine(product.ProductName);
                //}

                // 4. Get all orders with total amount greater than a certain value
                //var Orders = db.Orders.Select(o => o).Where(o => o.TotalAmount > 600).ToList();

                //foreach (var order in Orders)
                //{
                //    Console.WriteLine(order.TotalAmount);
                //}

                // 5. List all products with their supplier names

                //var products_supplier_details = db.Products.Join(db.Suppliers, p=> p.SupplierId, s=>s.Id, (p, s) => new {p.ProductName, s.CompanyName}).ToList();

                //foreach (var product in products_supplier_details)
                //{
                //    Console.WriteLine(product);
                //}

                // 6. Retrieve all order items for a specific order
                //var orderItems = db.OrderItems.Select(oi => new  { oi.OrderId, oi.Product.ProductName, oi.Quantity }).Where(oi => oi.OrderId == 1).ToList();

                //foreach (var orderItem in orderItems)
                //{
                //    Console.WriteLine(orderItem);
                //}

                // 7. Calculate the total number of orders by each customer
                //var CustomerTotalOrders = db.Customers.Join(db.Orders, c => c.Id, o => o.CustomerId, (c, o) => new { c.FirstName, c.LastName, c.Orders.Count }).GroupBy(c => c.FirstName + " " + c.LastName).ToList();

                //foreach (var customer in CustomerTotalOrders)
                //{
                //    foreach (var group in customer)
                //    {
                //        Console.WriteLine(group);
                //    }
                //}

                // 8. Calculate the total number of products ordered by each customer
                //var customerTotalProducts = db.Customers.Select(c => new
                //{
                //    c.FirstName,
                //    c.LastName,
                //    TotalQuantity = c.Orders.SelectMany(o => o.OrderItems).Sum(oi => oi.Quantity)
                //}).GroupBy(c => c.FirstName + " " + c.LastName).ToList();

                //foreach (var customer in customerTotalProducts)
                //{
                //    foreach (var group in customer)
                //    {
                //        Console.WriteLine(group);
                //    }
                //}

                // 9. Find the most expensive product sold
                //var MostExpensiveProduct = db.Products.Select(p => new { p.ProductName, p.UnitPrice }).Where(p => p.UnitPrice == db.Products.Max(p => p.UnitPrice)).ToList();

                //foreach (var product in MostExpensiveProduct)
                //{
                //    Console.WriteLine(product);
                //}
                // 10. Get the average order value per customer
                //var AvgOrderPerCustomer = db.Customers.Select(c => new { c.FirstName, c.LastName, AvgOrder = c.Orders.Average(o => o.TotalAmount) }).GroupBy(c => c.FirstName + " " + c.LastName).ToList();

                //foreach (var customer in AvgOrderPerCustomer)
                //{
                //    foreach (var group in customer)
                //    {
                //        Console.WriteLine(group);
                //    }
                //}

                // 11. List customers who have ordered products from more than one supplier
                //var orders = db.Customers.Select(c => new
                //{
                //    c.FirstName,
                //    c.LastName
                //,
                //    SuppliersCount = c.Orders.SelectMany(o => o.OrderItems).Select(oi => oi.Product.SupplierId).Distinct().Count()
                //}).Where(c => c.SuppliersCount > 1)
                //.ToList();
                //foreach (var order in orders)
                //{
                //    Console.WriteLine($"{order.FirstName} {order.LastName} has ordered from {order.SuppliersCount} different suppliers.");
                //}

                // 12. Find the top 3 customers based on total purchase amount
                //var customers = db.Customers.Select(c => new { c.FirstName, c.LastName, MaxPurchaseAmount = c.Orders.SelectMany(oi => oi.OrderItems).Sum(oi => oi.UnitPrice * oi.Quantity) }).
                //    OrderByDescending(c => c.MaxPurchaseAmount).Take(3).ToList();

                //foreach (var customer in customers)
                //{
                //    Console.WriteLine($"{customer.FirstName} {customer.LastName} has purchased {customer.MaxPurchaseAmount}.");
                //}

                // 13. Identify the products that have never been ordered
                //var UnOrderedProducts = db.Products.Select(p => p).Where(p => !p.OrderItems.Any()).ToList();
                //var UnOrderedProducts = db.Products.Select(p => new { p.ProductName, ProductCount = p.OrderItems.Count }).Where(p => p.ProductCount == 0).ToList();

                //foreach (var product in UnOrderedProducts)
                //{
                //    Console.WriteLine(product);
                //}
            };
        }
    }
}
