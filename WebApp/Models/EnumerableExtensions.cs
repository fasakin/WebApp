namespace WebApp.Models;

public static class EnumerableExtensions
{
    public static string GetAverage(this IEnumerable<Product> products, decimal price)
    {
        return (price/products.Average(p => p.Price) * 100).ToString("F1");
    }
}