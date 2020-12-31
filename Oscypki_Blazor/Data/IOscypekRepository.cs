using Oscypki_Blazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oscypki_Blazor.Data
{
    public interface IOscypekRepository
    {
        public IEnumerable<Oscypki> GetAllOscypki();
        public Oscypki GetOscypekById(int OscypkiId);
    }
}
