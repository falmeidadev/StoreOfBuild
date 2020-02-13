namespace StoreOfBuild.Domain.Products
{
  public class Product
  {
    public int Id { get; private set; }
    public string Name { get; private set; }
    public Category Category { get; private set; }
    public decimal Price { get; set; }
    public int StockQuantity { get; private set; }
    public Product(string name, Category category, decimal price, int stockQuantity)
    {
      ValidateValues(name, category, price, stockQuantity);
      SetProperties(name, category, price, stockQuantity);
    }
    public void Update(string name, Category category, decimal price, int stockQuantity)
    {
      ValidateValues(name, category, price, stockQuantity);
      SetProperties(name, category, price, stockQuantity);
    }
    private void SetProperties(string name, Category category, decimal price, int stockQuantity)
    {
      Name = name;
      Category = category;
      Price = price;
      StockQuantity = stockQuantity;
    }
    private static void ValidateValues(string name, Category category, decimal price, int stockQuantity)
    {
      DomainException.When(string.IsNullOrEmpty(name), "Name is required");
      DomainException.When(category == null, "Category is required");
      DomainException.When(price < 0, "Price is required");
      DomainException.When(stockQuantity < 0, "Stock quantity is required");
    }
  }
}