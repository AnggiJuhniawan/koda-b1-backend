using KodaStore.Api.Models;

namespace KodaStore.Api.Data;

public sealed class InMemoryProductCatalog
{
    private readonly List<Product> _products = [];

    public IReadOnlyList<Product> GetAll()
    {
        return _products.ToArray();
    }

    public Product? GetByCode(string productCode)
    {
        return _products.FirstOrDefault(product => string.Equals(product.ProductCode, productCode.Trim(), StringComparison.OrdinalIgnoreCase));
    }
}