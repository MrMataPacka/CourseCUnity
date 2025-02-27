using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course
{
    public class Delegates : MonoBehaviour //Variable que puede almacenar funciones
        // Delegates son para el Sistema general de comunicaciones como Callback y así
    {
        // Void
        public delegate void MyDelegate();
        public MyDelegate myDelegateVar;

        // return
        public delegate int MyDelegateInt();
        public MyDelegateInt myDelegateIntVar;

        // params
        public delegate void MyDelegateOneParam(string myString);
        public MyDelegateOneParam myDelegateOneParamVar;

        //Multicast
        public delegate void MyDelegateMulticast();
        public MyDelegateMulticast myDelegateMulticastVar;

        //Callback
        public delegate void MyDelegateCallback(bool success);
        public MyDelegateCallback myDelegateCallbackVar;

        private void Start ()
        {
            //void
            myDelegateVar = PrintMessage;
            //DelegateVar();
            //myDelegateVar.Invoke();


            // Return delegate que te ejecuta y retorna algo
            myDelegateIntVar = GetWeaponId;
            int myWeapon;
            //myWeapon = myDelegateIntVar();
            //myWeapon = myDelegateIntVar.Invoke();


            // Params que te ejecuta pero necesita un valor para ejecutarse
            myDelegateOneParamVar = PrintMessageWithValue;
            string myName = "World";
            //myDelegateOneParamVar(myName);
            //myDelegateOneParamVar.Invoke(myName);

            // Multicast que te ejecut multiples funciones a la vez
            myDelegateMulticastVar += PrintMessage; //Añadir Función
            myDelegateMulticastVar += ChangeWeapon; 
            myDelegateMulticastVar += Health;
            myDelegateMulticastVar -= Health; // Quitar función
            //myDelegateMulticastVar();
            //myDelegateMulticastVar.Invoke();

            // Callback
            myDelegateCallbackVar = RequesteCompleted; //Se conecta a la función donde esta el print y el resultado
            RequestConnection(myDelegateCallbackVar); //Función a la que se le pasa el delegate con el requeste anterior y determina la logica dependiendo si bool es true o false


        }

        private void PrintMessage()
        {
            Debug.Log("Hello World!!!");
        }

        private void PrintMessageWithValue(string message)
        {
            Debug.Log($"Hello {message}!!!");
        }

        private int GetWeaponId()
        {
            return 6;
        }

        private void ChangeWeapon()
        {
            Debug.Log("Hello World!!!");
        }

        private void Health()
        {
            Debug.Log("Hello World!!!");
        }

        bool connectionReady = true;

        private void RequestConnection(MyDelegateCallback callback)
        {
            if (connectionReady)
            {
                callback(true);
                //callback.Invoke(true);
            }

            else
            {
                callback(false);
                //callback.Invoke(false);
            }
        }

        private void RequesteCompleted(bool success)
        {
            Debug.Log($"Connection Ready: {success}");
        }
    }
}
