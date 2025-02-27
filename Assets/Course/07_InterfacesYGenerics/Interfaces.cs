using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course
{
    public interface Iinteractable // Interfaz es un contrato a una clase, la clase esta obligada a cumplir eso
    {
        void Interact();
    }
    public class Interfaces : MonoBehaviour
    {
        public GameObject[] myInteractables;


        private void Start()
        {
            for (int i = 0; i < myInteractables.Length; i++)
            {
                Iinteractable myInteractable = myInteractables[i].GetComponent<Iinteractable>();
                myInteractable?.Interact();
            }
        }
    }
}
