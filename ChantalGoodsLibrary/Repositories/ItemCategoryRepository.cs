using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ChantalGoodsLibrary.Domain;
using NHibernate;
using NHibernate.Criterion;


namespace ChantalGoodsLibrary.Repositories
{
    public class ItemCategoryRepository:IItemCategoryRepository
    {

        public IEnumerable<ItemCategory> GetAll()
        {
            using (ISession session = NhibernateHelper.OpenSession())
            {

                IQuery query = session.CreateQuery("From ItemCategory");
                IEnumerable<ItemCategory> itemCategories = query.List<ItemCategory>();
                return itemCategories;
                  
            }
        }


        public void Add(ItemCategory itemcategory)
        {
            using (ISession session = NhibernateHelper.OpenSession())
            {
               using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(itemcategory);

                    transaction.Commit();
                }
            }
        }



        public IEnumerable<ItemCategory> Search(string columnName, string inputString)
        {
            using (ISession session = NhibernateHelper.OpenSession())
            {

                //IQuery query = session.CreateQuery("FROM ItemCategory WHERE ItemCode like :itemCode");
                //query.SetParameter("itemCode", "%" + itemCode + "%");
                //IList<ItemCategory> itemCategories = query.List<ItemCategory>();

                ICriteria criteria = session.CreateCriteria(typeof(ItemCategory))
                                      .Add(Expression.Like(columnName, "%" + inputString + "%"));
                

                return criteria.List<ItemCategory>();


            }
        }



        public void Update(IEnumerable<ItemCategory> itemCategories)
        { 
            using (ISession session = NhibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                { 
                    foreach (ItemCategory item in itemCategories)
                    {
                        session.Update(item);
                       
                    }
                    transaction.Commit();
                }
            }
        }


        public void Delete(IEnumerable<int> ids)
        {
            using (ISession session = NhibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    IQuery query= session.CreateQuery("DELETE ItemCategory i WHERE i.Id IN (:IdList)");
                    query.SetParameterList("IdList", ids);
                    query.ExecuteUpdate();
                    transaction.Commit();
                                            
                }
            }
        }




    }
}
