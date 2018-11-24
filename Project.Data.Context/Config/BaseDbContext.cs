using Project.Data.Context.Interfaces;
using System.Data.Entity;

namespace Project.Data.Context.Config
{
    public class BaseDbContext : DbContext, IDbContext
    {

        public int? CurrentUserId { get; private set; }

        public BaseDbContext(string connectionStringName, int? currentUserId = null) : base(connectionStringName)
        {
            CurrentUserId = currentUserId;
        }

        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }
        
    }
}
