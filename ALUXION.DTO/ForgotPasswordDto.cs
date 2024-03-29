﻿using System.ComponentModel.DataAnnotations;

namespace ALUXION.DTOs
{
    public class ForgotPasswordDto
    {
        [Required(ErrorMessage = "Email address is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }
    }
}
