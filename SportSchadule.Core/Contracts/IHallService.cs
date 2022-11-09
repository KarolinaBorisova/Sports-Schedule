
using SportSchadule.Core.Models.Hall;

namespace SportSchadule.Core.Contracts
{
    public interface IHallService
    {
        Task<HallInfoViewModel> GetHallById(int id);
    }
}
