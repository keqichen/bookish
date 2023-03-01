namespace Bookish.Models;

    using System;
    using System.ComponentModel.DataAnnotations;

    public class AddBook
    {
        [Required]
        [MaxLength(140)]
        public string Title { get; set; }
        public string Author { get;set; }
    }
