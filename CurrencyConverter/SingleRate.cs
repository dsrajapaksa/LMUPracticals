using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    public class SingleRate
    {
        public int Id { get; set; }
        public string rate_From { get; set; }
        public string rate_To { get; set; }
        public double rate { get; set; }

    }
}
