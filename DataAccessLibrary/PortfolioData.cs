using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class PortfolioData : IPortfolioData
    {
        private readonly ISqlDataAccess _db;

        public PortfolioData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<PortfolioModel>> GetPortfolios()
        {
            string sql = "select * from dbo.Portfolio";

            var data = _db.LoadData<PortfolioModel, dynamic>(sql, new { });

            return data;
        }

        public Task<List<NextroundIREventsModel>> GetNextroundIREvents()
        {
            string sql = "select * from dbo.NextroundIREvents ORDER BY NextroundIRNumber DESC";

            var data = _db.LoadData<NextroundIREventsModel, dynamic>(sql, new { });

            return data;
        }

        public Task<List<PortfolioModel>> GetPortfoliosByPortfolioId(int portfolioId)
        {
            string sp = "select * from dbo.Portfolio WHERE PortfolioId = @PortfolioId;";

            var data = _db.LoadData<PortfolioModel, dynamic>(sp, new { PortfolioId = portfolioId });

            return data;
        }

        public Task<List<PortfolioModel>> GetPortfoliosByParticipatedNextround(int participatedNextround)
        {
            string sp = "select * from dbo.Portfolio WHERE ParticipatedNextround = @ParticipatedNextround;";

            var data = _db.LoadData<PortfolioModel, dynamic>(sp, new { ParticipatedNextround = participatedNextround });

            return data;
        }


        public Task<List<PortfolioModel>> GetPortfolios(string portfolioRankingName)
        {
            string sql = "spPortfolioAndRankingsOfPortfolio_JoinAndSortByRankingName @PortfolioRankingName";

            var data = _db.LoadData<PortfolioModel, dynamic>(sql, new { PortfolioRankingName = portfolioRankingName });

            return data;
        }


        public Task<List<ProductCategoryModel>> GetProductCategoriesByPortfolioId(int portfolioId)
        {
            string sp = "dbo.spCategoriesOfProduct_FilterByPortfolioId @PortfolioId";

            var data = _db.LoadData<ProductCategoryModel, dynamic>(sp, new { PortfolioId = portfolioId });

            return data;
        }


        public Task<List<ProductImageModel>> GetProductImagesByPortfolioId(int portfolioId)
        {
            string sp = "dbo.spImageFilesOfProduct_FilterByPortfolioId @PortfolioId";

            var data = _db.LoadData<ProductImageModel, dynamic>(sp, new { PortfolioId = portfolioId });
            return data;
        }



        public Task<List<PortfolioRankModel>> GetPortfolioRankByPortfolioIdAndRankingName(int portfolioId)
        {
            string sp = "dbo.spRankingsOfPortfolio_FilterByPortfolioRankingName @PortfolioId";

            var data = _db.LoadData<PortfolioRankModel, dynamic>(sp, new { PortfolioId = portfolioId });
            return data;
        }


        public Task<List<ProductCategoryModel>> GetAllCategoriesOfProductUniquely()
        {
            string sp = "dbo.spCategoriesOfProduct_GetUniqueValues";

            var data = _db.LoadData<ProductCategoryModel, dynamic>(sp, new { });
            return data;
        }

        public Task<List<int>> GetMaxPortfolioIdFromPortfolio()
        {
            string sp = "dbo.spPortfolio_GetMaxId";

            var data = _db.LoadData<int, dynamic>(sp, new { });
            return data;
        }



        public void InsertPortfolio(PortfolioModel portfolio)
        {


            _db.SavePortfolioAndItsChildListsToDB(portfolio);

        }

        public void UpdatePortfolioRankingUsedToSort(List<PortfolioModel> portfolio)
        {
            string sql = "update dbo.Portfolio " +
                "set RankingUsedToSort = @RankingUsedToSort " +
                "where PortfolioId = @PortfolioId; ";
            _db.SaveData(sql, portfolio);

        }
    }
}
