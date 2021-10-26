﻿using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Net.Http;
using WebAPI.Data;
using WebAPI.Models;
using System.Net;
using Business;

namespace WebAPI.Helpers
{
    public class ItemPhotosService
    {
        private static CommonRepository<ItemPhoto> _repo;
        public static List<ItemPhotoDTO> GetAllItemPhotoView()
        {
            _repo = GeneralHelper.GetItemPhotosRepository();
            List<ItemPhoto> itemPhotoList = _repo.GetAll().ToList();
            List<ItemPhotoDTO> ItemPhotoViewModelList = new List<ItemPhotoDTO>();
            foreach (ItemPhoto param in itemPhotoList)
            {
                ItemPhotoDTO itemModel = new ItemPhotoDTO()
                {
                    Id = param.Id,
                    ItemId = param.ItemId,
                    TypeId = param.TypeId,
                    FileName = param.FileName,
                    Position = param.Position,
                    Alt = param.Alt,
                    CreatedAt = param.CreatedAt,
                    ModifiedAt = param.ModifiedAt,
                    IsActive = param.IsActive,
                    Metal = param.ItemPhotoPropertySets.FirstOrDefault(x=> x.PropertyId == 1).Value,
                    Shape = param.ItemPhotoPropertySets.FirstOrDefault(x => x.PropertyId == 2).Value

                };

                ItemPhotoViewModelList.Add(itemModel);

            }
            return ItemPhotoViewModelList;
        }

       

        public static ItemPhotoDTO GetItemPhotoViewWithID (int ID)
        {
            _repo = GeneralHelper.GetItemPhotosRepository();
            var item = _repo.GetById(ID);
            ItemPhoto itemModel = new ItemPhoto();
            ItemPhotoDTO photoViewModel = new ItemPhotoDTO()
            {
                Id = item.Id,
                ItemId = item.ItemId,
                TypeId = item.TypeId,
                FileName = item.FileName,
                Position = item.Position,
                Alt = item.Alt,
                CreatedAt = item.CreatedAt,
                ModifiedAt = item.ModifiedAt,
                IsActive = item.IsActive
            };
            return photoViewModel;
        }

        internal static HttpResponseMessage DeleteItemPhotoEntityWithID(DeletePhotoRequest req, HttpRequestMessage httpRequest)
        {
            _repo = GeneralHelper.GetItemPhotosRepository();
            ItemPhoto item = _repo.GetById(req.Id);
            item.FileName = " ";
            if (_repo.Update(item) > 0)
            {
                return httpRequest.CreateResponse(System.Net.HttpStatusCode.OK);
            }
            else
            {
                return httpRequest.CreateResponse(HttpStatusCode.NotFound);
            }
        }

        internal static HttpResponseMessage UpdateItemPhotoEntityWithID(UpdatePhotoRequest req, HttpRequestMessage httpRequest)
        {
            _repo = GeneralHelper.GetItemPhotosRepository();
            ItemPhoto item = _repo.GetById(req.Id);
            item.FileName = req.Path;
            if (_repo.Update(item) > 0)
            {
                return httpRequest.CreateResponse(System.Net.HttpStatusCode.OK);
            }
            else
            {
                return httpRequest.CreateResponse(HttpStatusCode.NotFound);
            }
        }

    }
}