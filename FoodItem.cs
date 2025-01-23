namespace mission3;

public class FoodItem(string name, string category, int quantity, DateTime expiration)
{
    // Constructor when making object
    public string Name { get; set; } = name;
    public string Category { get; set; } = category;
    public int Quantity { get; set; } = quantity;

    public DateTime ExpirationDate { get; set; } = expiration;
    
}