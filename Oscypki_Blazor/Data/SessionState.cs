using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oscypki_Blazor.Data
{
    public class SessionState
    {
        public string SessionGUID { get; set; } = Guid.NewGuid().ToString();
    }
}
