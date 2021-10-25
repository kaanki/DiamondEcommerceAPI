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

        public static List<ItemViewModel> getAllProducts()
        {
            var repo = GeneralHelper.getItemRepository();
            List<Item> itemList = repo.GetAll().ToList();
            List<ItemViewModel> ItemViewModelList = new List<ItemViewModel>();
            foreach (var item in itemList)
            {
                ItemViewModel itemModel = new ItemViewModel();
                itemModel.Id = item.Id;
                itemModel.Name = item.Name;
                
            }
            return ItemViewModelList;


        }

    }
}