using System.Collections.Generic;
namespace HallBudgetASPCore.Models
{
    public interface IHallDataAccessModel
    {
        List<HallDetails> GetHallDetailBy(int costPerDay);
    }
}
