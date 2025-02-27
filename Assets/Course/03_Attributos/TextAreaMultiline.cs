using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course
{
    public class TextAreaMultiline : MonoBehaviour
    {
        [TextArea(1,10)] //Para textos muy largos, se le puede poner un rango de lineas
        public string description;

        [Multiline(6)] //Para textos con múltiples líneas, para notas un poco mas largas, cantidad de lineas totales
        public string note;
    }
}
