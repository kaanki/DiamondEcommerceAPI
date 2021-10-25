using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class ItemPhotoPropertyDTO
    {
        public int Id { get; set; }
        public int ItemPhotoId { get; set; }
        public int PropertyId { get; set; }
        public string Value { get; set; }
    }
}