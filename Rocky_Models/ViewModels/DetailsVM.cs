using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rocky_Models.ViewModels
{
    public class DetailsVM
    {
        public bool ExistsInCard { get; set; }
        public DetailsVM()
        {
            Product = new Product();
        }
        public Product Product { get; set; }
   
    }
}
