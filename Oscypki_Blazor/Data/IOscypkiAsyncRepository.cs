using Oscypki_Blazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oscypki_Blazor.Data
{
    public interface IOscypkiAsyncRepository
    {
        public Task<IEnumerable<Oscypki>> GetAllOscypki();
        public Task<Oscypki> GetOscypekById(int OscypkiId);
    }
}

