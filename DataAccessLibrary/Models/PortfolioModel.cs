using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Models
{


    public class PortfolioModel
    {
        public int PortfolioId { get; set; }

        public string NameOfCompany { get; set; }

        public string NameOfMainProduct { get; set; }
        public string CEO { get; set; }
        public string HomepageURL { get; set; }
        public string YearCompanyWasFounded { get; set; }

        public string FilterString { get; set; }

        public DateTime InitalUploadedDateTime { get; set; }

        public DateTime UpdatedDateTime { get; set; }

        public int ParticipatedNextround { get; set; }
        

        public List<ProductCategoryModel> ProductCategories { get; set; } = new List<ProductCategoryModel>();

        public List<ProductImageModel> ProductImages { get; set; } = new List<ProductImageModel>();



        public List<PortfolioRankModel> portfolioRankings = new List<PortfolioRankModel>();

        public int RankingUsedToSort { get; set; }


        public bool TempSaveYN { get; set; }

        public bool SubmitedYN { get; set; }
        public bool ApprovedYN { get; set; }
        public bool DelYN { get; set; }

    }


}
