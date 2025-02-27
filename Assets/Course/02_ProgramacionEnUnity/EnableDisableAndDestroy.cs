using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course
{
    public class EnableDisableAndDestroy : MonoBehaviour
    {
        private void OnEnable()
        {
            Debug.Log("OnEnable");
        }

        private void OnDisable()
        {
            Debug.Log("OnDisable");
        }

        private void OnDestroy()
        {
            Debug.Log("OnDestroy");
        }
    }
}
