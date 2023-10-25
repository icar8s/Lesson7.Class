namespace Lesson7.Classes;

public class Product
{
    public decimal Price;
    public string KindOfProduct ;
    public int Quantity;

    public Product(decimal price,string kindOfProduct,int quantity)
    {
        Price = price;
        KindOfProduct = kindOfProduct;
        Quantity = quantity;
    }
    
}