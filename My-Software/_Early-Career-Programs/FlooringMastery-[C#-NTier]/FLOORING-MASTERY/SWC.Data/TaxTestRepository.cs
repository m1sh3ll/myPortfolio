using SWC.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWC.Models;
using SWC.Models.Responses;

namespace SWC.Data
{
    public class TaxTestRepository : ITaxRepo

    {
        #region "TEST DATA ONLY" - Instantiate taxes
        //List of hardcoded for test repo - loaded at startup
        private static List<TaxRate> _taxrates = new List<TaxRate>
        {
            new TaxRate()
                {
                StateAbbreviation = "NY",
                StateName = "New York",
                TaxRatePercent = 8.25M
            },
             new TaxRate()
                {
                StateAbbreviation = "NJ",
                StateName = "New Jersey",
                TaxRatePercent = 7.5M
            },
             new TaxRate()
                {
                StateAbbreviation = "CT",
                StateName = "Connecticut",
                TaxRatePercent = 8.5M
            },
             new TaxRate()
                {
                StateAbbreviation = "PA",
                StateName = "Pennsylvania",
                TaxRatePercent = 8.0M
            }

        };
        #endregion       

        public TaxRate DisplayTax(string state)
        { 
           
            TaxRate rate = _taxrates.Find(x => x.StateAbbreviation == state);

            return rate;           
        }

        public List<TaxRate> DisplayAllTaxes()
        {
            return _taxrates;

        }


    }
}
