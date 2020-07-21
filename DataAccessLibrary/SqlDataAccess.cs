using Dapper;
using DataAccessLibrary.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class SqlDataAccess : ISqlDataAccess
    {
        private readonly IConfiguration _config;

        public string ConnectionStringName { get; set; } = "Default";

        public SqlDataAccess(IConfiguration config)
        {
            _config = config;
        }

        public async Task<List<T>> LoadData<T, U>(string sql, U parameters)
        {
            string connectionString = _config.GetConnectionString(ConnectionStringName);

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                var data = await connection.QueryAsync<T>(sql, parameters);
                return data.ToList();
            }
        }


        public void SaveData<T>(string sql, T parameters)
        {
            string connectionString = _config.GetConnectionString(ConnectionStringName);

            using (IDbConnection connection = new SqlConnection(connectionString))
            {

                connection.ExecuteAsync(sql, parameters);

            }
        }


        public void SavePortfolioAndItsChildListsToDB(PortfolioModel portfolio)
        {
            string connectionString = _config.GetConnectionString(ConnectionStringName);

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                var p = new DynamicParameters();
                p.Add("@PortfolioId", 0, DbType.Int32, ParameterDirection.Output);
                p.Add("@CEO", portfolio.CEO);
                p.Add("@HomepageURL", portfolio.HomepageURL);
                p.Add("@NameOfCompany", portfolio.NameOfCompany);
                p.Add("@NameOfMainProduct", portfolio.NameOfMainProduct);
                p.Add("@YearCompanyWasFounded", portfolio.YearCompanyWasFounded);
                p.Add("@UpdatedDateTime", portfolio.UpdatedDateTime);

                string sql = $@"insert into dbo.Portfolio (
                                    CEO,
                                    HomepageURL,
                                    NameOfCompany,
                                    NameOfMainProduct,
                                    YearCompanyWasFounded,
                                    UpdatedDateTime	)

                                values (
                                    @CEO,
                                    @HomepageURL,
                                    @NameOfCompany,
                                    @NameOfMainProduct,
                                    @YearCompanyWasFounded,
                                    @UpdatedDateTime);

                                select @PortfolioId = @@IDENTITY";

                connection.Execute(sql, p);

                int newIdentity = p.Get<int>("@PortfolioId");

                foreach (var image in portfolio.ProductImages)
                {
                    image.PortfolioId = newIdentity;
                    p = new DynamicParameters();
                    p.Add("@ImageFileAddress", image.ImageFileAddress);
                    p.Add("@PortfolioId", image.PortfolioId);

                    sql = $@"insert into dbo.ImageFilesOfProduct (
                                    PortfolioId,
                                    ImageFileAddress
                                    )

                                values (
                                    @PortfolioId,
                                    @ImageFileAddress
                                    );";

                    connection.Execute(sql, p);
                }

                foreach (var tag in portfolio.ProductCategories)
                {
                    tag.PortfolioId = newIdentity;
                    p = new DynamicParameters();
                    p.Add("@ProductCategory", tag.ProductCategory);
                    p.Add("@PortfolioId", tag.PortfolioId);

                    sql = $@"insert into dbo.CategoriesOfProduct (
                                    PortfolioId,
                                    ProductCategory
                                    )

                                values (
                                    @PortfolioId,
                                    @ProductCategory
                                    );";

                    connection.Execute(sql, p);
                }


                foreach (var ranking in portfolio.portfolioRankings)
                {
                    ranking.PortfolioId = newIdentity;
                    p = new DynamicParameters();
                    p.Add("@PortfolioRankingName", ranking.PortfolioRankingName);
                    p.Add("@PortfolioRanking", ranking.PortfolioRanking);
                    p.Add("@PortfolioId", ranking.PortfolioId);

                    sql = $@"insert into dbo.RankingsOfPortfolio (
                                    PortfolioId,
                                    PortfolioRankingName,
                                    PortfolioRanking

                                    )

                                values (
                                    @PortfolioId,
                                    @PortfolioRankingName,
                                    @PortfolioRanking

                                    );";

                    connection.Execute(sql, p);
                }


            }
        }

    }
}

