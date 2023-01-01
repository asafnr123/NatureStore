using NatureStore.Model.Context;


namespace NatureStore.Controller
{
    public class DbConnector
    {
        private readonly NatureStoreDbContext db = new NatureStoreDbContext();
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
