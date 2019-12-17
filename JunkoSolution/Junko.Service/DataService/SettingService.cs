using Junko.Data.Entries;
using Junko.Repo.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Junko.Service.DataService
{
    public interface ISettingService
    {
       Task<Setting> GetFirst();
    }
    public class SettingService : ISettingService
    {
        private readonly IUnitOfWork _unitOfWork;
        public SettingService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Setting> GetFirst()
        {
            return await _unitOfWork.Setting.GetFirst();
        }
    }
}
