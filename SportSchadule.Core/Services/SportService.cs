using Microsoft.EntityFrameworkCore;
using SportSchadule.Core.Contracts;
using SportsSchedule.Infrastructure.Data;
using SportsSchedule.Infrastructure.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
