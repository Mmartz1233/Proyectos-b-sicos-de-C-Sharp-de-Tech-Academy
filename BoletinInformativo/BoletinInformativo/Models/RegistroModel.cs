﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoletinInformativo.Models
{
    public class RegistroModel
    {
        public int Id { get; set; }
        public string  FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string SocialSecurityNumber { get; set; }
    }
}