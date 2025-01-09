using BlazorCommerce.Model;

namespace BlazorCommerce.Services.CategoryService
{
    interface ICategoryService
    {
        List<Category> Categories { get; set; }

        void LoadCategories();
    }
}
