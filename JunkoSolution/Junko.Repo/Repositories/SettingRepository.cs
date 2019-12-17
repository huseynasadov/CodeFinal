using Junko.Data.Entries;
using Junko.Repo.Data;
using Junko.Repo.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Junko.Repo.Repositories
{
   public class SettingRepository : Repository<Setting>, ISettingRepository
    {
        private readonly JunkoDbContext _db;

        public SettingRepository(JunkoDbContext context) : base(context)
        {
            _db = context;
        }
        public async Task<Setting> GetFirst()
        {
            return await _db.Setting.firstOfDefoul
        }
    }
}
