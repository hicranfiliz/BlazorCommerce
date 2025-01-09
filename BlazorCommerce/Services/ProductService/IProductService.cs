using BlazorCommerce.Model;

namespace BlazorCommerce.Services.ProductService
{
    interface IProductService
    {
        List<Product> Products { get; set; }
        void LoadProducts();

    }
}
