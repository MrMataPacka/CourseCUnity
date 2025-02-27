using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course
{
    public class VisibleAndInvisible : MonoBehaviour
    {
        
        //Tener cuidado mientras se ejecuta en la escena y se cambia a la pantalla donde podemos modificar cosas
        private void OnBecameVisible() 
        {
            Debug.Log("VISIBLE");
        }

        private void OnBecameInvisible()
        {
            Debug.Log("INVISIBLE");
        }
    }
}
