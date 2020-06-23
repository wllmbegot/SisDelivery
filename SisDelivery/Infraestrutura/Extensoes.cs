using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisDelivery.Infraestrutura
{
    public static class Extensoes
    {
        public static decimal NullOrDecimal(this object o)
        {
            return ((o == null) || (o.ToString().Trim().Equals(""))) ? 0 : decimal.Parse(o.ToString());
        }

    }
}
