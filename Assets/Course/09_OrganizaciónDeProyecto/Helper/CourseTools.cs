using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace UnityEngine.Tools // Separar la l�gica de todo el proyecto, que est� encapsulado
{
    public static class CourseTools // Debe ser estatica
    {		
        public static RectTransform GetRectTransform(this Transform t) // Igual est�tica
        {
            return t as RectTransform;
        }

        
    }
}
