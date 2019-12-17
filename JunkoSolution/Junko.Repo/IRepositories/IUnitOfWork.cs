using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Junko.Repo.IRepositories
{
    public interface IUnitOfWork  :IDisposable
    {
        ISettingRepository Setting { get; }
        Task<int> CommitAsync();
    }
}
