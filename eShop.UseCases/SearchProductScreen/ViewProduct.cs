using eShop.CoreBussiness.Models;
using eShop.UseCases.PluginInterfaces.DataStore;
using System.Collections.Generic;

namespace eShop.UseCases.SearchProductScreen
{
    public class ViewProduct : IViewProduct
    {
        private readonly IProductRepository productRepository;

        public ViewProduct(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public Product Execute(int id)
        {
            return productRepository.GetProduct(id);
        }

    }
}
