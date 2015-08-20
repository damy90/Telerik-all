using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace MusicStore.Data
{
    public interface IDbContext
    {
        IDbSet<Album> Albums { get; set; }
        IDbSet<Artist> Artists { get; set; }
        IDbSet<Song> Songs { get; set; }

        void SaveChanges();
        IDbSet<TEntity> Set<TEntity>() where TEntity:class;

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entry) where TEntity : class;
    }
}
