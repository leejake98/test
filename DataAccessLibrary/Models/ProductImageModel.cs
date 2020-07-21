using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Models
{
    public class ProductImageModel
    {

        public int PortfolioId { get; set; }

        public string ImageFileAddress { get; set; }

        public bool SelectedToBeUsedAsThumbnail { get; set; }

    }
}
