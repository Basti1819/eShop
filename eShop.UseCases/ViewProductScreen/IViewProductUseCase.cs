using eShop.CoreBussiness.Models;

namespace eShop.UseCases.SearchProductScreen
{
    public interface IViewProductUseCase
    {
        Product Execute(int id);
    }
}
