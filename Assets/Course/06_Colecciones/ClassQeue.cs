using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course
{
    public class ClassQeue : MonoBehaviour
    {
        // En orden de fila, el primero que llegue, el primero que esta por pasar
        [Header("Content")]
        public GameObject[] myContent;

        [Header("Queue")]
        public Queue<GameObject> playerQueue;

        private void Start ()
        {
            playerQueue = new Queue<GameObject>();

            for (int i = 0; i < myContent.Length; i++)
            {
                playerQueue.Enqueue(myContent[i]); //Pase haga la fila
            }

            // Remove, el primer jugador que entro se va
            GameObject myGameObject = playerQueue.Dequeue();

            // Contains
            bool contains = playerQueue.Contains(myGameObject);

            // Amount
            int amount = playerQueue.Count;

            // Clear
            playerQueue.Clear();    

        }
    }
}
