using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Models
{
    public class ProductCategoryModel
    {

        public int PortfolioId { get; set; }

        public string ProductCategory { get; set; }

        public bool SelectedToBeIncluded { get; set; } = false;


    }
}
