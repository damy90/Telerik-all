namespace MusicStore.Services.Models
{
    using MusicStore.Data;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Web;

    public class SongModel
    {
        public static Expression<Func<Song, SongModel>> FromSong
        {
            get
            {
                return s => new SongModel
                {
                    Id = s.Id,
                    Title = s.Title,
                    Genre = s.Genre,
                    Year = s.Year,
                    ArtistId=s.ArtistId
                };
            }
        }

        public string Title { get; set; }
        public Nullable<System.DateTime> Year { get; set; }
        public string Genre { get; set; }
        public int ArtistId { get; set; }
        public int Id { get; set; }
    }
}