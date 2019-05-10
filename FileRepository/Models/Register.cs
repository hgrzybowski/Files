﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FileRepository.Models
{
    public class Register
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public DateTime Year { get; set; }
        public bool Approved { get; set; }
    }
}
