﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcModels.Models
{
    //[Bind(Include="City")]
    public class AddressSummary
    {
        public string City { get; set; }
        public string Country { get; set; }
    }
}