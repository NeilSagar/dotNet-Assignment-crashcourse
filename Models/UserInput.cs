// Models/UserInput.cs
using System;
using System.ComponentModel.DataAnnotations;

namespace NameFormMVCApp.Models
{
    public class UserInput
    {
        [Required]
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string ManagerName { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public string Message { get; set; }
    }
}
