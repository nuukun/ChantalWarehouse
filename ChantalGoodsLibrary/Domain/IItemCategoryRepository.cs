using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChantalGoodsLibrary.Domain
{
    public interface IItemCategoryRepository
    {

        void Add(ItemCategory itemCategory);
        ItemCategory GetByName(string itemName);
    }
}
