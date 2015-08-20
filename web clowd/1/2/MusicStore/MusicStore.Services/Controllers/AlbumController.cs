using MusicStore.Data;
using MusicStore.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MusicStore.Services.Models;

namespace MusicStore.Services.Controllers
{
    public class AlbumController : ApiController
    {
        //private IRepository<Album> albums;
        private IMusicStoreData data;

        public AlbumController()
            : this(new MusicStoreData())
        {
            
        }

        public AlbumController(IMusicStoreData data)
        {
            this.data = data;
        }

        [HttpGet]
        public IHttpActionResult All()
        {
            var albums = this.data.Albums.All().Select(AlbumModel.FromAlbum);
            return Ok(albums);
        }

        //I give up
        [HttpPost]
        public IHttpActionResult Create(AlbumModel album)
        {
            throw new NotImplementedException("I can't add my AlbumModel as an Album :(");

            if (!this.ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var newAlbun = new AlbumModel
            {
                Title=album.Title
            };

            // How doez I database first?
            //this.data.Albums.Add((Album)newAlbun);
            this.data.Albums.SaveChanges();

            album.Id = newAlbun.Id;
            return Ok(newAlbun);
        }

        [HttpPut]
        public IHttpActionResult Update(int id, AlbumModel album)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Album existingAlbum = this.data.Albums.All().FirstOrDefault(a => a.Id == id);

            if (existingAlbum == null)
            {
                return BadRequest("The album does not exist");
            }

            // How doez I database first?
            existingAlbum.Year = album.Year;
            this.data.Albums.SaveChanges();

            album.Id = existingAlbum.Id;
            return Ok(album);
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var existingAlbum = this.data.Albums.All().FirstOrDefault(a => a.Id == id);


            if (existingAlbum == null)
            {
                return BadRequest("The album does not exist");
            }

            this.data.Albums.Delete(existingAlbum);
            this.data.Albums.SaveChanges();

            return Ok();
        }
    }
}
