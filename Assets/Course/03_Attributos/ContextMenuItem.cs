using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course
{
    public class ContextMenuItem : MonoBehaviour
    {
        [ContextMenu("Execute")] //Acceder a funcion desde los 3 puntitos del editor
        private void PrintExecute()
        {
            Debug.Log("EXECUTE!");
        }

        [ContextMenuItem("Get a random scale", "ExecuteRandomScale")] //Acceder a una función dando click derecho en las variables
        public float randomScale;

        private void ExecuteRandomScale()
        {
            randomScale = Random.Range(0,10f);
        }
    }
}
