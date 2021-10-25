using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Data
{
    public class UpdatePhotoRequest
    {
        public int Id { get; set; }
        public string Path { get; set; }
    }
}