using BIApi;
using BIImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BIApi
{
    public static class Factory
    {
        public static IBI Get()
        {
            IBI bI = new BL.BIImplementation.BI();
            return bI;
        }
    }
}
