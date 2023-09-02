using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWC.Models.Interfaces
{
    public interface ITaxRepository

    {
        Tax DisplayTax(string stateAbbreviation);

        List<Tax> DisplayAllTax();

    }
}
