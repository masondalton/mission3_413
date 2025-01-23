namespace mission3;

public class FoodItem
{
    public string Name { get; set; }
    public string Category { get; set; }
    public int Quantity { get; set; }
    public DateTime ExpirationDate { get; set; }
    // Constructor doesn't include return value. Name is the same as class
    public FoodItem(string name, string category, int quantity, DateTime expiration)
    {
        Name = name;
        Category = category;
        Quantity = quantity;
        ExpirationDate = expiration;
    }
}