using Oscypki_Blazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oscypki_Blazor.Data
{
    public class MockOscypekRepository : IOscypekRepository
    {
        public IEnumerable<Oscypki> AllOscypki => throw new NotImplementedException();

        public Oscypki GetOscypekById => throw new NotImplementedException();
    }
}
