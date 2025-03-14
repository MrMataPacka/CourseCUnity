using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course.SOLID.Before
{
    public class ItemShield : Item
    {
        public override void ExecuteMessage()
        {
            Debug.Log($"{itemName}: Defense!");
        }
    }
}
