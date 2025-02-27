using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course
{
    [HelpURL("https://docs.unity3d.com/6000.0/Documentation/Manual/UnityManual.html")] //Sirve para que al poner en el signo de pregunta te mande a la URL
    public class TooltipHelpURL : MonoBehaviour
    {
        [Tooltip("Player ID used by AWS")] //Sirve para documentar y que al poner el mouse se ve la información
        public int id;
    }
}
