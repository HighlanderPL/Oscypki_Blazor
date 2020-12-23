using Oscypki_Blazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oscypki_Blazor.Data
{
    public interface IOscypekRepository
    {
        IEnumerable<Oscypki> AllOscypki { get; }
        Oscypki GetOscypekById(int OscypkiId);
    }
}
