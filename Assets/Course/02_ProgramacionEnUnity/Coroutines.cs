using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course
{
    public class Coroutines : MonoBehaviour
    {
        public float myFloat;
        public int myInt;
        public string myString;

        private void Start () 
        {
            #region Start
            // Start
            StartCoroutine(CallCorroutine(myFloat, myInt, myString));

            //StartCoroutine("CallCorroutine"); // Es dificil para debuguear usar strings para llamar funciones

            //Coroutine myCoroutine;
            //myCoroutine= StartCoroutine(CallCorroutine());
            #endregion

            #region Stop
            // Start
            //StopCoroutine(CallCorroutine());


            //StopCoroutine("CallCorroutine");

            //StopCoroutine(myCoroutine);
            //StopAllCoroutines();
            #endregion

            // Parameters
            //StartCoroutine(CallCorroutineWithParams(2.5f, 100, "test"));

            //Coroutine myNewCoroutine;
            //myNewCoroutine = StartCoroutine(CallCorroutineWithParams(2.5f, 100, "test"));
        }

        private IEnumerator CallCorroutine(float myFloat, int myInt, string myString)
        {
            Debug.Log("CALL");
            yield return CallCorroutineWithParams(myFloat, myInt, myString);
            Debug.Log("CALL 2");
        }

        private IEnumerator CallCorroutineWithParams(float myFloat, int myInt, string myString)
        {
            myFloat += 1;

            if (myInt == 2)
                {
                myString = "testPlus";
                }
            else
            {
                myString = "testMax";
            }
            Debug.Log(myInt);
            Debug.Log(myFloat);
            Debug.Log(myString);
            yield return null;
        }
    }
}
