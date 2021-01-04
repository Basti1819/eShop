using eShop.CoreBussiness.Models;

namespace eShop.UseCases.SearchProductScreen
{
    public interface IViewProduct
    {
        Product Execute(int id);
    }
}
