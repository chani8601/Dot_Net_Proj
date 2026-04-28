//using BL.BIImplementation.BO;
//using System;
//using System.Collections.Generic;
//using System.Linq;
using BO;
using System.Text;
using System.Threading.Tasks;

namespace BIApi
{
    public interface ISale
    {
        int Create(Sale item);
        Sale? Read(int id);
        void Update(Sale item);
        void Delete(int id);
        List<Sale?> ReadAll(Func<Sale, bool>? filter = null);
        Sale? Read(Func<Sale, bool> filter);

    }
}
