using SportSchadule.Core.Contracts;
using SportSchadule.Core.Models.Hall;
using SportsSchedule.Infrastructure.Data;
using SportsSchedule.Infrastructure.Data.Common;
using System.Reflection.Metadata.Ecma335;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SportSchadule.Core.Services
{
    public class HallService : IHallService
    {
        private readonly IRepository repo;

        public HallService(IRepository _repo)
        {
            this.repo = _repo;
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
    }
}
