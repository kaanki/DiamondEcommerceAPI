using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Data;
using WebAPI.Helpers;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class ItemPhotosController : ApiController
    {
        //api/itemphotos
        [HttpGet]
        public List<ItemPhotoViewModel> GetAllItems()
        {
            return ItemPhotosHelper.GetAllItemPhotoView();
        }

        //api/itemphotos/3
        [HttpGet]
        public ItemPhotoViewModel getItemPhotoByID(int id)
        {

            ItemPhotoViewModel İtemPhotoModel = ItemPhotosHelper.GetItemPhotoViewWithID(id);
            return İtemPhotoModel;
        }

        [Route("api/ItemPhotos/DeletePhoto")]
        [HttpPost]
        public HttpResponseMessage DeletePhotoByID(DeletePhotoRequest req)
        {
            return ItemPhotosHelper.DeleteItemPhotoEntityWithID(req, Request);
        }

        [Route("api/ItemPhotos/UpdatePhoto")]
        [HttpPost]
        public HttpResponseMessage UpdatePhotoByID(UpdatePhotoRequest req)
        {
            
            return ItemPhotosHelper.UpdateItemPhotoEntityWithID(req,Request);
        }

    }
}
