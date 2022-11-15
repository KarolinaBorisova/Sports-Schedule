
using SportSchadule.Core.Models.Hall;

namespace SportSchadule.Core.Contracts
{
    public interface IHallService
    {
        Task<HallInfoViewModel> GetHallById(int id);

        Task<IEnumerable<HallInfoViewModel>> AllHalls();

        Task<int> Create(HallAddViewModel model);
    }
}
