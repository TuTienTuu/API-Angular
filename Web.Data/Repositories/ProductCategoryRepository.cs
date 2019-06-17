using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Data.Infrastructure;
using Web.Model.Models;

namespace Web.Data.Repositories
{
    public interface IProdcutCategoryRepository
    {
        IEnumerable<ProductCategory> GetByAlias(string alias);
    }
    public class ProductCategoryRepository : RepositoryBase<ProductCategory>, IProdcutCategoryRepository
    {
        
        internal ProductCategoryRepository(IDbFactory dbFactory) : base (dbFactory)
            {

            }

        public IEnumerable<ProductCategory> GetByAlias(string alias)
        {
            return this.DbContext.ProductCategories.Where(x => x.Alias == alias);
        }
    }
}
