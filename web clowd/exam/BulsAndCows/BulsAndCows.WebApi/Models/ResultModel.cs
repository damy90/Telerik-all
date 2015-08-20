using System.ComponentModel.DataAnnotations;
namespace BulsAndCows.WebApi.Models
{
    public class ResultModel
    {
        [Display(Name = "result")]
        public string Result { get; set; }
    }
}