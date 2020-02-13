namespace StoreOfBuild.Domain.Dtos
{
    public class ProductDto
    {
    public int Id { get; private set; }
    public string Name { get; private set; }
    public int CategoryId { get; private set; }
    public decimal Price { get; set; }
    public int StockQuantity { get; private set; }        
    }
}