using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course
{
    public class ClassStack : MonoBehaviour
    {
        // Caja donde guardamos objetos y sacamos el ultimo que se colocó
        // Escencial por ejemplo para juegos de cartas donde es imprescindible que saque la carta de arriba

        [Header("Content")]
        public GameObject[] myContent;

        [Header("Stack")]
        public Stack<GameObject> cardsStack;

        private void Start ()
        {
            // Init
            cardsStack = new Stack<GameObject>();


            // Add
            for (int i = 0; i < myContent.Length; i++)
            {
                cardsStack.Push(myContent[i]);
            }
            
            // Return First and Remove, agarrar el primer objecto y sacarlo
            GameObject myGameObjectPop = cardsStack.Pop();

            // Return First, ver el primero pero no sacarlo
            GameObject myGameObjectPeek = cardsStack.Peek();

            // Contains, preguntamos si contiene ese objecto
            bool contains = cardsStack.Contains(myGameObjectPeek);

            // Amount
            int amount = cardsStack.Count;

            // Clear
            cardsStack.Clear();

        }

    }
}
