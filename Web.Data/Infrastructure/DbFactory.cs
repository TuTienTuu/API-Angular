using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Data.Infrastructure
{
    internal class DbFactory : Disposable, IDbFactory
    {
        private WebDbContext dbContext;

        public WebDbContext Init()
        {
            return dbContext ?? (dbContext = new WebDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
