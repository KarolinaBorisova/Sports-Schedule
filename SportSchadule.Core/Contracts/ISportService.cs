using SportSchadule.Core.Models.Sport;

namespace SportSchadule.Core.Contracts
{
    public interface ISportService
    {
        Task<IEnumerable<SportHomeViewModel>> AllSports();
       Task<IEnumerable<AllSportsViewModel>> AllSportsInfo();
    }
}
