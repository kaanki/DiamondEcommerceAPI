﻿using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI.Models;

namespace WebAPI.Helpers
{
    public class ItemPhotoPropertySetHelper
    {

        public static List<ItemPhotoPropertyDTO> GetAllItemPhotoView()
        {
            var repo = GeneralHelper.getItemPhotosProperySetRepository();
            List<ItemPhotoPropertySet> photoPropertyList = repo.GetAll().ToList();
            List<ItemPhotoPropertyDTO> photoPropertViewModelList = new List<ItemPhotoPropertyDTO>();
            foreach (ItemPhotoPropertySet param in photoPropertyList)
            {
                ItemPhotoPropertyDTO itemModel = new ItemPhotoPropertyDTO()
                {
                    Id = param.Id,
                    ItemPhotoId = param.ItemPhotoId,
                    PropertyId = param.PropertyId,
                    Value = param.Value
                };

                photoPropertViewModelList.Add(itemModel);

            }
            return photoPropertViewModelList;
        }

        public static ItemPhotoPropertyDTO GetItemPhotoPropertyWithID(int ID)
        {
            var repo = GeneralHelper.getItemPhotosProperySetRepository();
            var PhotoProperty = repo.GetById(ID);
            ItemPhotoPropertySet itemModel = new ItemPhotoPropertySet();
            ItemPhotoPropertyDTO photoViewModel = new ItemPhotoPropertyDTO()
            {
                Id = PhotoProperty.Id,
                ItemPhotoId = PhotoProperty.ItemPhotoId,
                PropertyId = PhotoProperty.PropertyId,
                Value = PhotoProperty.Value
            };
            return photoViewModel;
        }


    }
}