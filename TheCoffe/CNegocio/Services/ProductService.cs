using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCoffe.CNegocio.Services
{
    class ProductService
    {
        public string FormatCurrency(double price)
        {
            return string.Format("{0:n}", price);
        }
    }
}
