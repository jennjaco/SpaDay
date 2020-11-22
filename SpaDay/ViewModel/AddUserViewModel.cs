using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using SpaDay.Models;

namespace SpaDay.ViewModel
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage = "Username is required.")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "Username must be between 5 and 15 characters.")]
        public string Username { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Password must be between 6 and 20 characters.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please verify your password")]
        [Compare("Password", ErrorMessage = "Passwords don't match, dude!")]
        public string VerifyPassword { get; set; }

        public Facials Type { get; set; }

        public List<SelectListItem> FacialType { get; set; } = new List<SelectListItem>
        {
            new SelectListItem(Facials.Microdermabrasion.ToString(), ((int)Facials.Microdermabrasion).ToString()),
            new SelectListItem(Facials.Rejuvenating.ToString(), ((int)Facials.Rejuvenating).ToString()),
            new SelectListItem(Facials.EnzymePeel.ToString(), ((int)Facials.EnzymePeel).ToString()),
            new SelectListItem(Facials.Hydrofacial.ToString(), ((int)Facials.Hydrofacial).ToString())
        };
    }
}
