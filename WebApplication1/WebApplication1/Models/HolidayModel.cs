﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class HolidayModel
    {
        public string Name { get; set; }
        public string LocalName { get; set; }
        public DateTime? Date { get; set; }
        public string CountryCode { get; set; }
        public bool Global { get; set; }

    }
}