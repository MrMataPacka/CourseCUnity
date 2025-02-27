using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Course
{
    public class Events : MonoBehaviour //Lo mismo que un delegate, pero con abstracción y protección
        // Events se usan más para toda la lógica
    {
        // Event
        public delegate void MyDelegateEvent();
        public event MyDelegateEvent myEventVar; //Aquí se declara como evento

        // UnityEvents
        public UnityEvent myUnityEventVar;
        public UnityEvent<bool> myUnityEventOneParamVar;
        public UnityEvent<bool, int, string> myUnityEventThreeParamVar;

        private void Start ()
        {
            // Event
            myEventVar += PrintMessage;

            //MyEventVar();
            //MyEventVar.Invoke();

            //UnityEvents
            myUnityEventVar.AddListener(PrintMessage); // esto es igual al += de un event normal
            myUnityEventVar.RemoveListener(PrintMessage); // esto es igual al -= de un event normal
            myUnityEventVar.Invoke();

            myUnityEventOneParamVar.Invoke(true);
            myUnityEventThreeParamVar.Invoke(true, 5, "test");

        }

        private void PrintMessage()
        {
            Debug.Log("Hello World!!!");
        }
    }
}
