namespace Lesson7.Classes;

public class Inventory
{
    private List<Product> products;

    public Inventory()
    {
        products = new List<Product>();
    }
    public decimal PriceOfAllProducts()
    {
        decimal sum = 0;

        foreach (var product in products)
        {
            sum += product.Price * product.Quantity;
        }
        return sum;
    }

    public List<Product> Products
    {
        get { return products; }
    } 
        
        public void AddProduct(Product product)
        {
            products.Add(product);
        }
      


    }