using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QuantDeveloper.Business.Models
{
    public class User
    {
        public int UserId { get; set; }

        [Required(ErrorMessage = "UserName is required")]
        [StringLength(20, ErrorMessage = "UserName can't be longer than 20 characters")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [StringLength(100, ErrorMessage = "Email can't be longer than 100 characters")]
        [EmailAddress(ErrorMessage = "Email is not valid")]
        public string Email { get; set; }

        [Required(ErrorMessage = "AliasName is required")]
        public string Alias { get; set; }

        [Required(ErrorMessage = "User First Name is required")]
        [StringLength(50, ErrorMessage = "UserName can't be longer than 50 characters")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "User Last Name is required")]
        [StringLength(50, ErrorMessage = "UserName can't be longer than 50 characters")]
        public string LastName { get; set; }
    }
}
