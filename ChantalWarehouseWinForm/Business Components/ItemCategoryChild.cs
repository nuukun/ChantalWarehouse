using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ChantalGoodsLibrary.Domain;
using ChantalGoodsLibrary.Repositories;

namespace ChantalWarehouseWinForm.Business_Components
{
    public class ItemCategoryChild
    {

        public ItemCategoryChild()
        {

        }

        public List<ItemCategory> DoRead()
        {
            ItemCategoryRepository itemCategoryRepo = new ItemCategoryRepository();
            List<ItemCategory> itemCategories = itemCategoryRepo.GetAll().ToList();

            return itemCategories;

        }

        


    }
}
