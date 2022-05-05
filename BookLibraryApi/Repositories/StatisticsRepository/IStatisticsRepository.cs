using BookLibraryApi.Models.StatisticsModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookLibraryApi.Repositories.StatisticsRepository
{
    public interface IStatisticsRepository
    {
        Task<Statistics> GetStatistics();
        Task<List<BookStatistic>> GetBooksStatistics();
    }
}
