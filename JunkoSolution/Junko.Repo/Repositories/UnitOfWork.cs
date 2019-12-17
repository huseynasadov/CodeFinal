using Junko.Repo.Data;
using Junko.Repo.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Junko.Repo.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly JunkoDbContext _context;
        private SettingRepository _bookRepository;
        public UnitOfWork(JunkoDbContext context)
        {
            this._context = context;

        }
        public ISettingRepository Books => _bookRepository ??= new SettingRepository(_context);


        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
