using Microsoft.EntityFrameworkCore;
using SportSchadule.Core.Contracts;
using SportSchadule.Core.Models.Hall;
using SportSchadule.Core.Models.Sport;
using SportsSchedule.Infrastructure.Data;
using SportsSchedule.Infrastructure.Data.Common;

namespace SportSchadule.Core.Services
{
    public class HallService : IHallService
    {
        private readonly IRepository repo;

        public HallService(IRepository _repo)
        {
            this.repo = _repo;
        }

        public async Task<IEnumerable<HallInfoViewModel>> AllHalls()
        {
            return await repo.AllReadonly<Hall>()
                 .OrderBy(h => h.Name)
                 .Select(h => new HallInfoViewModel() {
                     Id = h.Id,
                     Name = h.Name,
                     Address = h.Address,
                     Capacity = h.Capacity,                
                    
                 })
                 .ToListAsync();
        }

        public async Task<HallInfoViewModel> GetHallById(int id)
        {
            var hall = await repo.GetByIdAsync<Hall>(id);
            

            return new HallInfoViewModel {
                Id = hall.Id,
                Name = hall.Name,
                Address = hall.Address,
                Capacity = hall.Capacity,
                PlacesLeft = hall.Capacity
            };
        }

        public async Task<int> Create(HallAddViewModel model)
        {
            var hall = new Hall()
            {
                Name = model.Name,
                Address = model.Address,
                Capacity = model.Capacity,

            };

            await repo.AddAsync(hall);
            await repo.SaveChangesAsync();

            return hall.Id;

        }
    }
}
