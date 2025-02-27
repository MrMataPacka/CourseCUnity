using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course
{
    
    public class CollisionVsTrigger : MonoBehaviour
    {
        #region Collision 
        //Masa impenetrable, no puedes estar dentro, no se puede atravesar
        private void OnCollisionEnter(Collision collision)
        {
            Debug.Log("OnCollisionEnter");
        }

        private void OnCollisionStay(Collision collision)
        {
            Debug.Log("OnCollisionStay");
        }

        private void OnCollisionExit(Collision collision)
        {
            Debug.Log("OnCollisionExit");
        }
        #endregion


        #region Trigger
        //Se puede atravesar, tanto como entra, esta dentro y sale
        private void OnTriggerEnter(Collider other)
        {
            Debug.Log("Trigger Enter");
        }

        private void OnTriggerStay(Collider other)
        {
            Debug.Log("Trigger Stay");
        }

        private void OnTriggerExit(Collider other)
        {
            Debug.Log("Trigger Exit");
        }
        #endregion
    }
}
