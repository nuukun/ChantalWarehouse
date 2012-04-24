using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ChantalGoodsLibrary.Domain;
using NHibernate;

namespace ChantalGoodsLibrary.Repositories
{
    public class ItemCategoryRepository:IItemCategoryRepository
    {
        public void Add(ItemCategory itemcategory)
        {
            using (ISession session = NhibernateHelper.OpenSession())
            {
               //using (ITransaction transaction = session.BeginTransaction())
                //{
                    session.Save(itemcategory);
                    //transaction.Commit();
                    //session.CreateQuery(@"Insert into ITEMCATEGORIES('ACB','AMD')").ExecuteUpdate();
                //}
            }
        }

        public ItemCategory GetByName(string itemName)
        {
            throw new NotImplementedException();
        }


    }
}
