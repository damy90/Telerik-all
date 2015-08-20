using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Data
{
    class MusicStoreContext:DbContext, IDbContext
    {
        public MusicStoreContext()
            : base("MusicStoreEntities")
        {

        }
        public IDbSet<Album> Albums { get; set; }

        public IDbSet<Artist> Artists{ get; set; }


        public IDbSet<Song> Songs { get; set; }


        public void SaveChanges()
        {
            base.SaveChanges();
        }

        public IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }
    }
}
