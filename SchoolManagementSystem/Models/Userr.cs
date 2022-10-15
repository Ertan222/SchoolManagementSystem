﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace SchoolManagementSystem.Models
{
    public class Userr
    {

        [Key]
        public int UserrID { get; set; }


        [Required(ErrorMessage = "{0} needs to be fill"),Display(Name ="Email"), StringLength(50, MinimumLength = 6, ErrorMessage = "{0}, {2}-{1} needs to be in range"), DataType(DataType.EmailAddress, ErrorMessage = "Invalid {0}")]
        public string Emaill { get; set; }



        [Required(ErrorMessage = "{0} needs to be fill"), Display(Name ="Password"),StringLength(20, MinimumLength = 6, ErrorMessage = "{0}, {2}{1} needs to be in range"),  DataType(DataType.Password)]
        public string Passwordd { get; set; }

        [NotMapped, Display(Name = "Password Confirm"), DataType(DataType.Password), Compare("Passwordd", ErrorMessage = "Password and Password Confirm are not the same")]
        public string PasswordRepeatt{ get; set; }


        [Required(ErrorMessage = "{0} needs to be fill"), Display(Name = "Role")]
        public byte RoleeID { get; set; }

        

        public Rolee Rolee { get; set; } 

    }
}
