using MusicStore.Data;
using MusicStore.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MusicStore.Services.Controllers
{
    public class SongController : ApiController
    {
        private IMusicStoreData data;

        public SongController()
            : this(new MusicStoreData())
        {
            
        }

        public SongController(IMusicStoreData data)
        {
            this.data = data;
        }

        [HttpGet]
        public IHttpActionResult All()
        {
            var songs = this.data.Songs.All().Select(SongModel.FromSong);
            return Ok(songs);
        }

        [HttpPut]
        public IHttpActionResult Update(int id, SongModel song)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var existingSong = this.data.Songs.All().FirstOrDefault(a => a.Id == id);

            if (existingSong == null)
            {
                return BadRequest("The song does not exist");
            }

            // How doez I database first?
            existingSong.Title = song.Title;
            this.data.Songs.SaveChanges();

            song.Id = existingSong.Id;
            return Ok(song);
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var existingSong = this.data.Songs.All().FirstOrDefault(a => a.Id == id);


            if (existingSong == null)
            {
                return BadRequest("The song does not exist");
            }

            this.data.Songs.Delete(existingSong);
            this.data.Songs.SaveChanges();

            return Ok();
        }
    }
}
