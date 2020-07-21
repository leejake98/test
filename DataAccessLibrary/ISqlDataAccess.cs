using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface ISqlDataAccess
    {
        string ConnectionStringName { get; set; }

        Task<List<T>> LoadData<T, U>(string sql, U parameters);
        void SaveData<T>(string sql, T parameters);
        void SavePortfolioAndItsChildListsToDB(PortfolioModel portfolio);
    }
}