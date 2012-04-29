using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChantalGoodsLibrary.Domain
{
    public interface IItemCategoryRepository
    {

        void Add(ItemCategory itemCategory);
        //ItemCategory SeachById(int id);
        IEnumerable<ItemCategory> Search(string columnName, string inputString);
        IEnumerable<ItemCategory> GetAll();
        void Update(IEnumerable<ItemCategory> itemCategories);
        void Delete(IEnumerable<int> ids);
        //ItemCategory GetByName(string itemName);
    }
}
