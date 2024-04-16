namespace DesignPatterns.Creational.Builder;

class ProductBuilder
{
    private Product _product = new Product();

    public ProductBuilder SetProperty1(string property1)
    {
        _product.Property1 = property1;
        return this;
    }

    public ProductBuilder SetProperty2(string property2)
    {
        _product.Property2 = property2;
        return this;
    }

    public ProductBuilder SetProperty3(string property3)
    {
        _product.Property3 = property3;
        return this;
    }

    public Product Build()
    {
        if (!CanBuild())
            throw new InvalidOperationException();
        Product product = _product;
        Reset();
        return product;
    }

    private bool CanBuild()
    {
        if (string.IsNullOrEmpty(_product.Property1))
            return false;
        return true;
    }

    private ProductBuilder Reset()
    {
        _product = new();
        return this;
    }
}
