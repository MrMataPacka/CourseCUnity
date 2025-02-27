using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course
{
    public class InvokeAndRepeating : MonoBehaviour
    {		
        private void Start () 
        {
            //Invoke("CallInvoke", 3f);
            InvokeRepeating("CallInvoke", 3f, 1f);

            CancelInvoke();
            IsInvoking("CallInvoke");
        }

        private void CallInvoke()
        {
            Debug.Log("Invoke called.");
        }
    }
}
