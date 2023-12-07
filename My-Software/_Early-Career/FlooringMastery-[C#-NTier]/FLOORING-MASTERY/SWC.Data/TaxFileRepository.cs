using SWC.Models.Interfaces;
using SWC.Models;
using SWC.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SWC.Data
{
    public class TaxFileRepository : ITaxRepo

    {
        // Instantiate taxes        
        private static List<TaxRate> _taxrates = new List<TaxRate>();

        private string _filePath;
        private string _filedir = AppDomain.CurrentDomain.BaseDirectory;
        private string _basedir = @"..\..\FILES\";
        public string SetFilePath()
        {
            _filePath = _filedir + _basedir + "taxes.txt";
            return _filePath;
        }
       
  
        public TaxRate DisplayTax(string state)
        {
            _filePath = SetFilePath();
            var allTaxRates = DisplayAllTaxes();
            TaxRate Rate = allTaxRates.FirstOrDefault(x => x.StateAbbreviation == state);
            return Rate;           
        }

        public List<TaxRate> DisplayAllTaxes()
        {
            _filePath = SetFilePath();

            List<TaxRate> taxrates = new List<TaxRate>();

            using (StreamReader reader = new StreamReader(_filePath))
            {
                reader.ReadLine();
                string lineread;
                while ((lineread = reader.ReadLine()) != null)
                {
                    TaxRate r = new TaxRate();
                    string[] splits = lineread.Split(',');
                    r.StateAbbreviation = splits[0];
                    r.StateName = splits[1];
                    r.TaxRatePercent = Decimal.Parse(splits[2]);                    
                    taxrates.Add(r);
                }
            }
            _taxrates = taxrates;
            return _taxrates;

        }


    }
}
