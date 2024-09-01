
using Microsoft.EntityFrameworkCore;

namespace PieShopApp.Models
{
    public class PieRepository: IPieRepository
    {

        private readonly PieShopDbContext _dbContext;

        public PieRepository(PieShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Pie> AllPies => _dbContext.Pies.Include(c=> c.Category);

        public IEnumerable<Pie> PiesOfTheWeek => _dbContext.Pies.Include(c => c.Category).Where(p=>p.IsPieOfTheWeek);

        public Pie? GetPieById(int pieId)
        {
            return _dbContext.Pies.FirstOrDefault(p => p.PieId == pieId);
        }

        public IEnumerable<Pie> Search(string searchQuery)
        {
            return _dbContext.Pies.Include(c => c.Category).Where(p => p.Name.Contains(searchQuery));
        }
    }
}
