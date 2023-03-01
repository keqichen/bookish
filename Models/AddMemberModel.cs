namespace Bookish.Models;

    using System;
    using System.ComponentModel.DataAnnotations;
    public class AddMemberModel
    {
        [Required]
        [MaxLength(140)]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
