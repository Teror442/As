using System;
using System.Collections.Generic;
using System.IO;

public class ProductManager
{
    private List<Products> products;

    public ProductManager()
    {
        products = new List<Products>();
    }


    public void AddProduct(Products product)
    {
        products.Add(product);
    }


    public List<Products> GetAllProducts()
    {
        return products;
    }

    public bool DeleteProduct(Products product)
    {
        return products.Remove(product);
    }

    public bool ModifyProduct(Products oldProduct, Products newProduct)
    {
        int index = products.IndexOf(oldProduct);
        if (index >= 0)
        {
            products[index] = newProduct;
            return true;
        }
        return false;
    }


    public List<Products> ExtractProducts(string size = null, string type = null, string color = null)
    {
        List<Products> result = new List<Products>();

        foreach (var product in products)
        {
            bool matchesSize = size == null || product.Size == size;
            bool matchesType = type == null || product.Type == type;
            bool matchesColor = color == null || product.Color == color;

            if (matchesSize && matchesType && matchesColor)
            {
                result.Add(product);
            }
        }

        return result;
    }

    public void SaveToFile(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (var product in products)
            {
                writer.WriteLine($"{product.Type},{product.Cut},{product.Color},{product.Fabric},{product.Size},{product.Brand},{product.Price}");
            }
        }
    }


    public void LoadFromFile(string filePath)
    {
        if (File.Exists(filePath))
        {
            products.Clear();
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split(',');

                    if (parts.Length == 7)
                    {
                        decimal price;
                        if (decimal.TryParse(parts[6], out price))
                        {
                            var product = new Products(parts[0], parts[1], parts[2], parts[3], parts[4], parts[5], price);
                            products.Add(product);
                        }
                    }
                }
            }
        }
    }
}
