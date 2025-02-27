using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course //Puede cambiarse dependiendo del proyecto,
                 //para diferenciar clases aunque se llamen igual,
                 //pueden igual diferenciarse para diferentes equipos
{
    public class ScriptableObjects :MonoBehaviour
    {
        public DataSO data;

        private void Start()
        {
            Debug.Log(data.GetPrintStats());
        }
    }
}
