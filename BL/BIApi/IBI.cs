using BIApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIApi
{
    public interface IBI
    {
        public ICustomer Customer { get; }
        public IOrder Order { get; }
        public ISale Sale { get; }
        public IProduct Product { get; }

    }
}
