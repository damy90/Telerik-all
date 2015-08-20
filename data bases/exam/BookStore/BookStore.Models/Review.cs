namespace BookStore.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Review
    {
        public int Id { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        public int BookId { get; set; }

        public virtual Book Book { get; set; }

        public int? AutorId { get; set; }

        public virtual Author Autor { get; set; }
    }
}
