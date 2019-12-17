using Junko.Data.Entries;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Junko.Repo.IRepositories
{
   public interface  ISettingRepository 
    {
        Task<Setting> GetFirst();
    }
}
