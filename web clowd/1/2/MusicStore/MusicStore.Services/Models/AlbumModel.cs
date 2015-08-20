using MusicStore.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace MusicStore.Services.Models
{
    public class AlbumModel
    {
        public static Expression<Func<Album, AlbumModel>> FromAlbum
        {
            get
            {
                return a => new AlbumModel
                {
                    Id=a.Id,
                    Title=a.Title,
                    //Artist=string.Join(", ", a.Artists.Select(ar=>ar.Name)),
                    Year=a.Year
                };
            }
        }

        public int Id { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(50)]
        public string Title { get; set; }

        //public string Artist { get; set; }

        public DateTime? Year { get; set; }
    }
}