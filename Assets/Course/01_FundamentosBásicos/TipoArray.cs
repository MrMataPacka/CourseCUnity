using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course
{
    public class TipoArray : MonoBehaviour
    {
        public int[] enemyId = {100, 290 ,399 ,490 };

        private void Start()
        {
            int myId = enemyId[0];  //100

            myId = enemyId[3]; //490
        }
    }
}
