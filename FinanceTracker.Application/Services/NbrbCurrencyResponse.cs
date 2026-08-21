using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceTracker.Application.Services
{
    public class NbrbCurrencyResponse
    {
        public int Cur_ID { get; set; }

        public string Date { get; set; }
        public string Cur_Abbreviation { get; set; }

        public int Cur_Scale { get; set; }
        public string Cur_Name { get; set; }

        public decimal Cur_OfficialRate { get; set; }
    }
}
