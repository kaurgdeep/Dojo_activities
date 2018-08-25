using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LoginRegDemo
{
    public class User
    {
        [Key]
        public int UserId {get; set;}

        [Required(ErrorMessage   = "Must have first name")]
        [MinLength(2)]
        public string FirstName {get; set;}
        

        [RegularExpression("^[a-zA-Z]+$")]
        [Required(ErrorMessage = "Must have last name")]
        [MinLength(2)]
        public string LastName {get; set;}


        [MinLength(2)]
        [Required(ErrorMessage = "Must have email")]
        [RegularExpression("^[a-zA-Z0-9.+_-]+@[a-zA-Z0-9._-]+.[a-zA-Z]+$")]
        public string Email {get; set;}

        [Required(ErrorMessage="Password Required")]
        [MinLength(8, ErrorMessage="Minimum 8 characters")]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[$@$!%#?*&])[A-Za-z\d$@$!%*#?&]{8,}$", ErrorMessage="Must have 1 number, 1 letter, and 1 special character")]
        public string Password {get; set;}

    }
}

