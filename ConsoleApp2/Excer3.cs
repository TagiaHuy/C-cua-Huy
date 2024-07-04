using Newtonsoft.Json;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public string Category { get; set; }

    public Product(int id, string name, double price, string category)
    {
        Id = id;
        Name = name;
        Price = price;
        Category = category;
    }

    public static List<Product> Products { get; set; }

    public static void InitializeProducts()
    {
        if (Products == null)
        {
            Products = new List<Product>();
        }
    }

    public static void ReadFromJsonFile(string filePath)
    {
        // Check if file exists
        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException($"File not found: {filePath}");
        }

        // Read the entire JSON file into a string
        string jsonString = File.ReadAllText(filePath);
        Console.WriteLine(jsonString);

        // Deserialize the JSON string into a List of Product objects
        Products = JsonConvert.DeserializeObject<List<Product>>(jsonString);
    }

    public static void WriteToJsonFile(string filePath)
    {
        string json = JsonConvert.SerializeObject(Products, Formatting.Indented);

        File.WriteAllText(filePath, json);
    }

    // public static void Main()
    // {
    //     string filePath = "products.json";

    //     InitializeProducts();

    //     ReadFromJsonFile(filePath);

    //     Console.WriteLine("Danh sach san pham:");
    //     foreach (var product in Products)
    //     {
    //         Console.WriteLine($"ID: {product.Id}, Name: {product.Name}, Price: {product.Price}, Category: {product.Category}");
    //     }

    //     // Thêm mới sản phẩm
    //     Product newProduct = new Product(4, "Sản phẩm mới", 99.99, "Điện tử");
    //     Products.Add(newProduct);

    //     // Ghi danh sách sản phẩm vào tệp JSON
    //     WriteToJsonFile(filePath);

    //     Console.WriteLine("\nDanh sach san pham sau khi them moi:");
    //     foreach (var product in Products)
    //     {
    //         Console.WriteLine($"ID: {product.Id}, Name: {product.Name}, Price: {product.Price}, Category: {product.Category}");
    //     }
    // }
}