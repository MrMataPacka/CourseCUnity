using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course.Depuracion
{
    public class ClaseDebug : MonoBehaviour
    {

        private void Start()
        {
            // Print
            print("Hola mundo");

            // Log
            Debug.Log("Hola Log");
            Debug.LogWarning("Hola Warning");
            Debug.LogError("Hola Error");

            // Con Formatos
            Debug.LogFormat("My {0} format!", "Log");
            Debug.LogWarningFormat("My {0} warning format!", "Log");
            Debug.LogErrorFormat("My {0} error format!", "Log");

            // Break
            //Debug.Break();

            // Obtener ubicación del objeto
            Debug.Log("Aqui", gameObject);

            //Draw
            Debug.DrawLine(
                transform.position,
                transform.position + (Vector3.forward * 5),
                Color.green,
                5f,
                true
                );
            Debug.DrawRay(
                transform.position,
                Vector3.forward * 5,
                Color.yellow,
                5f,
                true
                );

            // Rich Text
            Debug.Log("Rich Text: <color=red>Color by name</color>");
            Debug.Log("Rich Text: <color=#ff0000ff>Color by Hex Value</color>");
            Debug.Log("Rich Text: <b>Bold</b>");
            Debug.Log("Rich Text: <i>Italic</i>");
            Debug.Log("Rich Text: <size=50>Size</size>");
        }
        
    }
}
