using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course
{
    public class UpdateLateAndFixed : MonoBehaviour
    {
        private void FixedUpdate()
        {
            Debug.Log("Fixed");
        }

        private void Update()
        {
            Debug.Log("Update");

        }

        private void LateUpdate()
        {
            Debug.Log("Late");
        }
    }
}
