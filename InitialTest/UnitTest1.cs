using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using NHibernate.Cfg;
using ChantalGoodsLibrary.Domain;
using ChantalGoodsLibrary.Repositories;

namespace InitialTest
{
    [TestClass]
    public class UnitTest1
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
            var itemCategory = new ItemCategory { ItemCode = "CPUI001", ItemName = "Intel Processor" };
            IItemCategoryRepository repository = new ItemCategoryRepository();
            repository.Add(itemCategory);

        }
    }
}
