using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Photo
    {

        public string PhotoFilePath { get; set; }

        public int? position { get; set; }

        public ItemProperties ItemProperty { get; set; }
    }
}