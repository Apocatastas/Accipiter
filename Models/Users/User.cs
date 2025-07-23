﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Accipiter.Models.Users
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public DateTime BirthDate { get; set; }

        public string Image { get; set; }

        public string Status { get; set; }


        public string About { get; set; }

        public string GetFullName()
        {
            return FirstName + " " + MiddleName + " " + LastName;
        }

        public string GetInfo()
        {
            return this.About;
        }

        public string GetStatus()
        {
            return Status;
        }

        public string GetImage()
        {
            return Image;
        }

        public User()
        {
            Image = "https://apocatastas.github.io/thebestdeveloperever/dummy.png";
            Status = "Ура! Я в соцсети!";
            About = "Информация обо мне.";
        }

    }
}
