using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course.PatronesDiseño.Factory
{
    public class Inventory : MonoBehaviour
    {
        public DatabaseSO itemDataBase;
        public string itemId;

        private DatabaseFactory factory;

        private void Start()
        {
            factory = new DatabaseFactory(Instantiate(itemDataBase));
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                UpdateItem(itemId);
            }
        }

        private void UpdateItem(string id)
        {
            ItemSO item = factory.GetData<ItemSO>(id);

            Debug.Log($"Item: {item.title}, ${item.prices}");
        }
    }
}
