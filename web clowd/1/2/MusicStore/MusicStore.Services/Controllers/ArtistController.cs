namespace MusicStore.Services.Controllers
{
    using MusicStore.Data;
    using MusicStore.Services.Models;
    using System;
    using System.Linq;
    using System.Web.Http;

    public class ArtistController : ApiController
    {
         private IMusicStoreData data;

        public ArtistController()
            : this(new MusicStoreData())
        {
            
        }

        public ArtistController(IMusicStoreData data)
        {
            this.data = data;
        }

        [HttpGet]
        public IHttpActionResult All()
        {
            var artists = this.data.Artists.All().Select(ArtistModel.FromArtist);
            return Ok(artists);
        }

        //I give up
        [HttpPost]
        public IHttpActionResult Create(ArtistModel artist)
        {
            throw new NotImplementedException("I can't add my ArtistModel as an Artist :(");

            if (!this.ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var newArtist = new ArtistModel
            {
                Name = artist.Name
            };

            // How doez I database first?
            //this.data.Artists.Add((Artist)newArtist);
            this.data.Artists.SaveChanges();

            artist.Id = newArtist.Id;
            return Ok(newArtist);
        }

        [HttpPut]
        public IHttpActionResult Update(int id, ArtistModel artist)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Artist existingArtist = this.data.Artists.All().FirstOrDefault(a => a.Id == id);

            if (existingArtist == null)
            {
                return BadRequest("The artist does not exist");
            }

            // How doez I database first?
            existingArtist.DateOfBirth = artist.DateOfBirth;
            this.data.Artists.SaveChanges();

            artist.Id = existingArtist.Id;
            return Ok(artist);
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var existingArtist = this.data.Artists.All().FirstOrDefault(a => a.Id == id);


            if (existingArtist == null)
            {
                return BadRequest("The artist does not exist");
            }

            this.data.Artists.Delete(existingArtist);
            this.data.Artists.SaveChanges();

            return Ok();
        }
    }
}
