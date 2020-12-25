using Oscypki_Blazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oscypki_Blazor.Data
{
    public class OscypekRepository : IOscypekRepository
    {
        private readonly AppDbContext _appDbContext;

        public OscypekRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Oscypki> AllOscypki()
        {
            get {
                IEnumerable<Oscypki> allOcypki = _appDbContext.Oscpkis.ToList();
                return allOcypki;
            }
           
        }

        public Oscypki GetOscypekById(int OscypkiId)
        {
            var Oscypek = _appDbContext.Oscpkis.FirstOrDefault(o => o.OscypkiId == OscypkiId);

            return Oscypek;
        }
    }
}

