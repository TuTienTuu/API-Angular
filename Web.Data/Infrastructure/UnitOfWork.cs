using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Data.Infrastructure
{
   public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private WebDbContext dbContext;

        internal UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        internal WebDbContext DbContext
        {
            get { return dbContext ?? (dbContext = dbFactory.Init()); }
        }

        public void Commit()
        {
            DbContext.SaveChanges();
        }
    }
}
