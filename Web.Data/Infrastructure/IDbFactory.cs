using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Data.Infrastructure
{
   internal interface IDbFactory : IDisposable
    {
        WebDbContext Init();
    }
}
