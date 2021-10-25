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
        public List<ItemPhotoPropertyViewModel> GetAllItems()
        {
            return ItemPhotoPropertySetHelper.GetAllItemPhotoView();
        }

        [HttpGet]
        public ItemPhotoPropertyViewModel getItemPhotoPropByID(int ID)
        {

            return ItemPhotoPropertySetHelper.GetItemPhotoPropertyWithID(ID);
        }


    }
}