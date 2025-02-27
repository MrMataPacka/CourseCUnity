using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course
{
    public class ClassLisr : MonoBehaviour
    {
        // Array dinámico
        // Lista pensada para agregar y sacar elementos facilmente
        // Array para tener unos valores como referencia

        [Header("Content")]
        public int[] myContent;

        [Header("List")]
        public List<int> weaponList;

        private void Start()
        {
            // Init, iniciar lista
            weaponList = new List<int>();

            // add, añadir elementos
            for (int i = 0; i < myContent.Length; i++)
            {
                weaponList.Add(myContent[i]);
            }

            weaponList.AddRange(myContent); //Agrega todos los elementos del array

            // Remove
            weaponList.Remove(myContent[2]);

            // Read
            int tempValue = weaponList[2];

            // Amount
            int amout = weaponList.Count;

            // Clear, borrar todos los elemento
            weaponList.Clear();


        }
    }
}
