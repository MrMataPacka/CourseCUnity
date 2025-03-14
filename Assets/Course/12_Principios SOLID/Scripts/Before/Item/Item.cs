using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course.SOLID.Before
{
    public abstract class Item : MonoBehaviour
    {
        public string itemName;

        public abstract void ExecuteMessage();

    }
}