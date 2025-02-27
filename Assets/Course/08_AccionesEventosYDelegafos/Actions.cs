using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Course
{
    public class Actions : MonoBehaviour // Es como internamente funcionan los delegates
    {
        public Action myActionVar;
        public UnityAction myUnityActionVar;
        

        public Action<int> myActionOneParamVar;
        public UnityAction<int> myUnityActionOneParamVar;

        public Action<int, bool, string> myActionThreeParamVar;
        public UnityAction<int, bool, string> myUnityActionThreeParamVar;

        private void Start()
        {
            // Action
            myActionVar = PrintMessage;
            myActionVar += PrintMessage;

            myActionVar();
            myActionVar.Invoke();

            // UnityAction
            myUnityActionVar = PrintMessage;
            myUnityActionVar += PrintMessage;

            myUnityActionVar();
            myUnityActionVar.Invoke();


        }

        private void PrintMessage()
        {
            Debug.Log("Hello World!!!");
        }
    }
}
