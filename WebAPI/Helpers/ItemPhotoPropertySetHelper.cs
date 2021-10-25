using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI.Models;

namespace WebAPI.Helpers
{
    public class ItemPhotoPropertySetHelper
    {

        public static List<ItemPhotoPropertyViewModel> GetAllItemPhotoView()
        {
            var repo = GeneralHelper.getItemPhotosProperySetRepository();
            List<ItemPhotoPropertySet> photoPropertyList = repo.GetAll().ToList();
            List<ItemPhotoPropertyViewModel> photoPropertViewModelList = new List<ItemPhotoPropertyViewModel>();
            foreach (ItemPhotoPropertySet param in photoPropertyList)
            {
                ItemPhotoPropertyViewModel itemModel = new ItemPhotoPropertyViewModel()
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

        public static ItemPhotoPropertyViewModel GetItemPhotoPropertyWithID(int ID)
        {
            var repo = GeneralHelper.getItemPhotosProperySetRepository();
            var PhotoProperty = repo.GetById(ID);
            ItemPhotoPropertySet itemModel = new ItemPhotoPropertySet();
            ItemPhotoPropertyViewModel photoViewModel = new ItemPhotoPropertyViewModel()
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