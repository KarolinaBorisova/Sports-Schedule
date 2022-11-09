using Microsoft.EntityFrameworkCore;
using SportSchadule.Core.Contracts;
using SportSchadule.Core.Models.Hall;
using SportSchadule.Core.Models.Sport;
using SportsSchedule.Infrastructure.Data;
using SportsSchedule.Infrastructure.Data.Common;


namespace SportSchadule.Core.Services
{
    public class SportService : ISportService
    {
        private readonly IRepository repo;

        public SportService(IRepository _repo)
        {
            repo = _repo;
        }

        public async Task<IEnumerable<SportHomeViewModel>> AllSports()
        {
            // How to order sports
            return await repo.AllReadonly<Sport>()
                .Select(s => new SportHomeViewModel
                {
                    Id = s.Id,
                    Name = s.Name,
                    ImageUrl = s.ImageUrl,

                }).ToListAsync();
                
        }

       public async Task<IEnumerable<AllSportsViewModel>> AllSportsInfo()
        {
            // How to order sports
            return await repo.AllReadonly<Sport>()
                .Include(s => s.SportsHalls)
                .ThenInclude(sh => sh.Hall)
                    .Select(s => new AllSportsViewModel
                    {
                        Id = s.Id,
                        Name = s.Name,
                        ImageUrl = s.ImageUrl,
                        Description = s.Description,
                         Halls = s.SportsHalls.Select(h => new HallInfoViewModel
                         {
                             Id = h.HallId,
                             Name = h.Hall.Name
                         }).ToList(),

                    }).ToListAsync();

        }

    }
}
