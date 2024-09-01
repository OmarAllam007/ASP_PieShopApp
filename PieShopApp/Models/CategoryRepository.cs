
namespace PieShopApp.Models
{

    public class CategoryRepository : ICategoryRepository
    {

        private readonly PieShopDbContext _dbContext;

        public CategoryRepository(PieShopDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        public IEnumerable<Category> AllCategories => _dbContext.Categories.OrderBy(c => c.CategoryName);
    }


}

