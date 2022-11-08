using SportsSchedule.Infrastructure.Data;

namespace SportSchadule.Core.Contracts
{
    public interface ISportService
    {
        Task<IEnumerable<SportHomeViewModel>> AllSports();
    }
}
