﻿using NHibernate;
using ChantalGoodsLibrary.Domain;
using NHibernate.Cfg;


namespace ChantalGoodsLibrary.Repositories
{
    public class NhibernateHelper
    {

        private static ISessionFactory _sessionFactory;



        private static ISessionFactory SessionFactory
        {

            get
            {

                if (_sessionFactory == null)
                {
                    
                    var configuration = new Configuration();

                    configuration.Configure();

                    configuration.AddAssembly(typeof(ItemCategory).Assembly);

                    _sessionFactory = configuration.BuildSessionFactory();

                }

                return _sessionFactory;

            }

        }



        public static ISession OpenSession()
        {

            return SessionFactory.OpenSession();

        }
    }
}
