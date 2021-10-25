using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI.Models;

namespace WebAPI.Helpers
{
    public class ProductHelper
    {

        public static List<ItemDTO> getAllProducts()
        {
            var repo = GeneralHelper.getItemRepository();
            List<Item> itemList = repo.GetAll().ToList();
            List<ItemDTO> ItemViewModelList = new List<ItemDTO>();
            foreach (var item in itemList)
            {
                ItemDTO itemModel = new ItemDTO();
                itemModel.Id = item.Id;
                itemModel.Name = item.Name;
                
            }
            return ItemViewModelList;


        }

    }
}