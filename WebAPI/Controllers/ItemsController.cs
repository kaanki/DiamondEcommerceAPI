using Business;
using Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Helpers;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class ItemsController : ApiController
    {
        //api/items
        [HttpGet]
        public List<ItemDTO> GetAllItems()
        {
            return ItemsHelper.getAllItems();
        }
        //api/items/1
        [HttpGet]
        public ItemDTO getItemWithID(int ID)
        {
           
            return ItemsHelper.GetItemViewModelWithID(ID);
        }


    }
}
