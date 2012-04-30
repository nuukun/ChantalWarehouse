using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NHibernate.Cfg;
using ChantalGoodsLibrary.Domain;
using ChantalGoodsLibrary.Repositories;

namespace InitialTest
{
    [TestClass]
    public class ItemCategoryCRUDTest
    {

        [TestMethod]
        public void SchemaShouldBeGenerated()
        {
            var cfg = new Configuration();

            cfg.Configure();

            cfg.AddAssembly(typeof(ItemCategory).Assembly);

        }


        [TestMethod]
        public void ItemCategoryShouldBeAdded()
        {
            var itemCategory = new ItemCategory { ItemCode = "CPUI002", ItemName = "AMD Processor" };
            IItemCategoryRepository itemCategoryRepo = new ItemCategoryRepository();
            itemCategoryRepo.Add(itemCategory);

        }

        [TestMethod]
        public void ShouldReturnAllOfTheItemCategories()
        {
            IItemCategoryRepository itemCategoryRepo = new ItemCategoryRepository();
            List<ItemCategory> itemCategories= itemCategoryRepo.GetAll().ToList();
            Assert.AreEqual("1", itemCategories.Count().ToString());
        }

        [TestMethod]
        public void ItemCategoryShouldBeFoundWhenSearching()
        {
            IItemCategoryRepository itemCategoryRepo = new ItemCategoryRepository();
            List<ItemCategory> itemCategories = itemCategoryRepo.Search("ItemName","AMD").ToList();
            Assert.AreEqual(2, itemCategories.Count);
        }


        [TestMethod]
        public void ItemCategoryShouldBeUpdated()
        {
            IItemCategoryRepository itemCategoryRepo = new ItemCategoryRepository();
            List<ItemCategory> itemCategories = new List<ItemCategory>()
            {
               new ItemCategory (){Id = 3,ItemCode = "CPUI001",ItemName = "IntelProcessing"},
               new ItemCategory (){Id = 4,ItemCode = "CPUI002",ItemName = "AMDProcessing"}
            };
            itemCategoryRepo.Update(itemCategories);
        }
    
    

        [TestMethod]
        public void ItemCategoryShouldBeDeleted()
        {
            List<int> ids = new List<int> {1,2};
            IItemCategoryRepository itemCategoryRepo = new ItemCategoryRepository();
            itemCategoryRepo.Delete(ids);

        }


    }
}
