using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WebAPI.Helpers;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class ItemPhotoPropertySetController : ApiController
    {

        [HttpGet]
        public List<ItemPhotoPropertyDTO> GetAllItems()
        {
            return ItemPhotoPropertyService.GetAllItemPhotoView();
        }

        [HttpGet]
        public ItemPhotoPropertyDTO getItemPhotoPropByID(int ID)
        {

            return ItemPhotoPropertyService.GetItemPhotoPropertyWithID(ID);
        }


    }
}