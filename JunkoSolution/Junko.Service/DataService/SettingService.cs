using System;
using System.Collections.Generic;
using System.Text;

namespace Junko.Service.DataService
{
    public interface ISettingService
    {

        Task<Book> GetBookById(int id);
        Task<IEnumerable<Book>> GetAllBooks();
    }
    class SettingService
    {
    }
}
