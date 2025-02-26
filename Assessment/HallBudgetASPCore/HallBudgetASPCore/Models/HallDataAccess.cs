
namespace HallBudgetASPCore.Models
{
    public class HallDataAccess : IHallDataAccessModel
    {
        private readonly HallDbContext hallDb;
        public HallDataAccess(HallDbContext halldb)
        {
            this.hallDb = halldb;
        }

        public List<HallDetails> GetHallDetailBy(int costPerDay)
        {
           return hallDb.hall.Where(h => h.CostPerDay <= costPerDay).ToList();
        }
    }
}
