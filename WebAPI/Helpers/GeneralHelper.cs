using Business;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Helpers
{
    public class GeneralHelper
    {
        internal static CommonRepository<Item> GetItemRepository()
        {
            var dbo = new dbo_MasterEntities();
            return new CommonRepository<Item>(dbo);

        }

        internal static CommonRepository<ItemPhoto> GetItemPhotosRepository()
        {
            var dbo = new dbo_MasterEntities();
            return new CommonRepository<ItemPhoto>(dbo);

        }

        internal static CommonRepository<ItemPhotoPropertySet> GetItemPhotosProperySetRepository()
        {
            var dbo = new dbo_MasterEntities();
            return new CommonRepository<ItemPhotoPropertySet>(dbo);
        }
    }
}