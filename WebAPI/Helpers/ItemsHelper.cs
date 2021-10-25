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
        public static List<ItemDTO> getAllItems()
        {
            var repo = GeneralHelper.getItemRepository();
            List<Item> itemList = repo.GetAll().ToList();
            List<ItemDTO> ItemViewModelList = new List<ItemDTO>();
            foreach (var item in itemList)
            {
                ItemDTO itemModel = new ItemDTO();
                itemModel.Id = item.Id;
                itemModel.Name = item.Name;
                
                ItemViewModelList.Add(itemModel);
            }
            return ItemViewModelList;


        }

        public static ItemDTO GetItemViewModelWithID(int ID)
        {
            var repo = GeneralHelper.getItemRepository();
            var item = repo.GetById(ID);
            ItemDTO itemModel = new ItemDTO();
            itemModel.Id = item.Id;
            itemModel.Name = item.Name;
            
            return itemModel;
        }
    }
}