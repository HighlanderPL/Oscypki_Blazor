using Oscypki_Blazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oscypki_Blazor.Data
{
    public class OscypekAsyncRepository : IOscypkiAsyncRepository
    {
        public Task<IEnumerable<Oscypki>> GetAllOscypki()
        {
            throw new NotImplementedException();
        }

        public Task<Oscypki> GetOscypekById(int OscypkiId)
        {
            throw new NotImplementedException();
        }
    }
}
