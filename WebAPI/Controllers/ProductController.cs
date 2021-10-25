using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using WebAPI.Helpers;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class ProductController : ApiController
    {
        // GET: Product
        public List<ProductViewModel> GetProductList()
        {
            //var itemrepo = GeneralHelper.getItemRepository();
            //List<ProductViewModel> ProductList = new List<ProductViewModel>();
            //var itemlist = itemrepo.GetAll();

            //foreach (Item param in itemlist)
            //{
            //    List<Photo> photoList = new List<Photo>() { };
            //    List<ItemProperties> propertyList = new List<ItemProperties>() { };
            //    foreach (var photo in param.ItemPhotos)
            //    {
            //        foreach (var props in photo.ItemPhotoPropertySets)
            //        {
            //            propertyList.Add(new ItemProperties
            //            {
            //                PropertyName = props.Property.Name
            //            });
            //        }

            //        photoList.Add(new Photo
            //        {
            //            PhotoFilePath = photo.FileName,
            //            position = photo.Position
            //        });

            //    }
            //    ProductList.Add(
            //        new ProductViewModel
            //        {
            //            Item = new ItemViewModel
            //            {
            //                Id = param.Id,
            //                Name = param.Name
            //            },
            //            PhotoList = photoList,


            //        }
            //        );
            //}
            //return ProductList;
            return null;

        }
    }
}