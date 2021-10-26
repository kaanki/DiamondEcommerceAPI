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
        public List<ItemPhotoDTO> GetAllItems()
        {
            return ItemPhotosService.GetAllItemPhotoView();
        }

        //api/itemphotos/3
        [HttpGet]
        public ItemPhotoDTO getItemPhotoByID(int id)
        {

            ItemPhotoDTO İtemPhotoModel = ItemPhotosService.GetItemPhotoViewWithID(id);
            return İtemPhotoModel;
        }

        [Route("api/ItemPhotos/DeletePhoto")]
        [HttpPost]
        public HttpResponseMessage DeletePhotoByID(DeletePhotoRequest req)
        {
            return ItemPhotosService.DeleteItemPhotoEntityWithID(req, Request);
        }

        [Route("api/ItemPhotos/UpdatePhoto")]
        [HttpPost]
        public HttpResponseMessage UpdatePhotoByID(UpdatePhotoRequest req)
        {
            
            return ItemPhotosService.UpdateItemPhotoEntityWithID(req,Request);
        }

    }
}
