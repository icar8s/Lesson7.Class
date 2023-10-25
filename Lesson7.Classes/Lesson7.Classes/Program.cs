using Lesson7.Classes;

Inventory inventory = new Inventory();

    List<Product> products = new List<Product>
    {
        new Product(10, "PK", 5),
        new Product(15, "Mobile Phone", 6),
        new Product(20, "Laptop", 7)
    };

    foreach (var product in products)
    {
        inventory.AddProduct(product);
    }

    Console.WriteLine("Inventory:");

    foreach (var product in inventory.Products)
    {
        Console.WriteLine($"Price: {product.Price}\n" +
                          $"Product: {product.KindOfProduct}\n" +
                          $"Quantity: {product.Quantity}");
    }

    decimal PriceOfAllProducts = inventory.PriceOfAllProducts();

    Console.WriteLine($"Total price: {PriceOfAllProducts}");

    Console.ReadLine();

