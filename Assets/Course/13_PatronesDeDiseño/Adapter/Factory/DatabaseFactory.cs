using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course.PatronesDiseño.Factory
{
    public class DatabaseFactory
    {
        private DatabaseSO dataBase;

        public DatabaseFactory (DatabaseSO dataBase)
        {
            this.dataBase = dataBase;
        }

        public DataSO GetData(string id)
        {
            return dataBase.GetData(id);
        }

        public ItemSO GetData<ItemSO>(string id)
        {
            return dataBase.GetData<ItemSO>(id);
        }
    }
}
