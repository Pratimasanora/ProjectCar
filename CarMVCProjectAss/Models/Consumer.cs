﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarMVCProjectAss.Models
{
    public class Consumer
    {
        public int Id { get; set; }
        [Display(Name ="FirstName")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public string City { get; set; }




    }
}
