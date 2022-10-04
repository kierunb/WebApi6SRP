namespace WebApi6Demo.Services;

public interface IProductCalculationService
{
    public double Calculate(string product);
}

public class ProductCalculationService : IProductCalculationService
{
    public double Calculate(string product)
    {
        // pobierz z bazy produkt
        // pobierz z bazy dane promocji
        // policz promocje
        // zwroc

        return (double)product.Length;
    }
}
