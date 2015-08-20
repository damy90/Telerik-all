using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BulsAndCows.WebApi.Models
{
    public class GameCreateModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Number { get; set; }
    }
}