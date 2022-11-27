using NatureStore.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatureStore.Controller
{
    public class DbConnector
    {
        private static readonly NatureStoreDbContext db = new NatureStoreDbContext();
        private static DbConnector instance = null;
        private static readonly object key = new object();

        private DbConnector() { }

        public static DbConnector GetInstance()
        {
            if (instance == null)
            {
                lock (key)
                {
                    if (instance == null)
                    {
                        instance = new DbConnector();
                    }
                }
            }
            return instance;
        }


        public NatureStoreDbContext GetDb()
        {
            return db;
        }
    }
}
