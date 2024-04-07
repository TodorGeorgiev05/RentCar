using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    
    [Index(nameof(User.EGN), IsUnique = true)]

    public class User
    {
		[Key]
        public int Id { get; set; }

        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        [Required]
        [StringLength(10)]
        public string EGN { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        [StringLength(10)]
        public string PhoneNumber { get; set; }
        public bool isAdmin { get; set; }


        public User()
        {

        }
        public User(int id, string username, string password, string email, string firstName, string lastName, string eGN, string address, string phoneNumber, bool isAdmin)
        {
            Id = id;
            UserName = username;
            Password = password;
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            EGN = eGN;
            Address = address;
            PhoneNumber = phoneNumber;
            this.isAdmin = isAdmin;
        }
    
    
    }
}
