using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course
{
    public class Generics : MonoBehaviour
    {		
        public List<int> numbers;
        public List<string> words;

        private void Start ()
        {
            words = ReserveList(words);
        }

        private List<T> ReserveList<T>(List<T> listoToReverse) // Uso en interfaces por ser abstractas, permiten hacer funciones con diferentes valores
        {
            List<T> reversedList = new List<T>();

            for (int i = listoToReverse.Count - 1 ; i >= 0; i--)
            {
                reversedList.Add(listoToReverse[i]);
            }
            return reversedList;
        }
    }
}
