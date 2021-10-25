using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI.Models;

namespace WebAPI.Helpers
{
    public class ItemsHelper
    {
        public static List<ItemViewModel> getAllItems()
        {
            var repo = GeneralHelper.getItemRepository();
            List<Item> itemList = repo.GetAll().ToList();
            List<ItemViewModel> ItemViewModelList = new List<ItemViewModel>();
            foreach (var item in itemList)
            {
                ItemViewModel itemModel = new ItemViewModel();
                itemModel.Id = item.Id;
                itemModel.Name = item.Name;
                
                ItemViewModelList.Add(itemModel);
            }
            return ItemViewModelList;


        }

        public static ItemViewModel GetItemViewModelWithID(int ID)
        {
            var repo = GeneralHelper.getItemRepository();
            var item = repo.GetById(ID);
            ItemViewModel itemModel = new ItemViewModel();
            itemModel.Id = item.Id;
            itemModel.Name = item.Name;
            
            return itemModel;
        }
    }
}