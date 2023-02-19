using System;
using Microsoft.AspNetCore.Mvc;
namespace Webapp.Models
{
    public class LoginModel
    {
        public string? emailId{get; set;}

        public string? password{get; set;}
    }
}