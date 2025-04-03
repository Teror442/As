public class Products
{
    public string Type { get; set; }
    public string Cut { get; set; }
    public string Color { get; set; }
    public string Fabric { get; set; }
    public string Size { get; set; }
    public string Brand { get; set; }
    public decimal Price { get; set; }

   
    public Products(string type, string cut, string color, string fabric, string size, string brand, decimal price)
    {
        Type = type;
        Cut = cut;
        Color = color;
        Fabric = fabric;
        Size = size;
        Brand = brand;
        Price = price;
    }

    public decimal CalculatePrice()
    {
        decimal finalPrice = Price;

        if (Size == "XXL" || Size == "XXXL")
        {
            finalPrice += 10m; 
        }

        if (Color == "Gold" || Color == "Silver")
        {
            finalPrice += 15m; 
        }

        return finalPrice;
    }
}
