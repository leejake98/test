using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface IPortfolioData
    {
        Task<List<ProductCategoryModel>> GetAllCategoriesOfProductUniquely();
        Task<List<int>> GetMaxPortfolioIdFromPortfolio();
        Task<List<NextroundIREventsModel>> GetNextroundIREvents();
        Task<List<PortfolioRankModel>> GetPortfolioRankByPortfolioIdAndRankingName(int portfolioId);
        Task<List<PortfolioModel>> GetPortfolios();
        Task<List<PortfolioModel>> GetPortfolios(string portfolioRankingName);
        Task<List<PortfolioModel>> GetPortfoliosByParticipatedNextround(int participatedNextround);
        Task<List<PortfolioModel>> GetPortfoliosByPortfolioId(int portfolioId);
        Task<List<ProductCategoryModel>> GetProductCategoriesByPortfolioId(int portfolioId);
        Task<List<ProductImageModel>> GetProductImagesByPortfolioId(int portfolioId);
        void InsertPortfolio(PortfolioModel portfolio);
        void UpdatePortfolioRankingUsedToSort(List<PortfolioModel> portfolio);
    }
}