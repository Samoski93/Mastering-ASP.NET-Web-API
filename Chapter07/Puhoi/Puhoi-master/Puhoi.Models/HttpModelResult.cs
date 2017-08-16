﻿using System.Collections.Generic;
using Puhoi.Models.Models;
using System.Net;

namespace Puhoi.Models
{
    public class HttpModelResult
    {
        public HttpStatusCode HttpStatus { get; set; }
        public BaseModel Model { get; set; }
        public IEnumerable<BaseModel> Models {get;set;}
    }
}
