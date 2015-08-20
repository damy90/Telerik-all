using MusicStore.Data.Repositories;

namespace MusicStore.Data
{
    public interface IMusicStoreData
    {
        IRepository<Album> Albums { get; }

        IRepository<Artist> Artists { get; }

        IRepository<Song> Songs { get; }
    }
}
