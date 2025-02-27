using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace UnityEngine.Tools // Separar la lógica de todo el proyecto, que esté encapsulado
{
    public static class CourseTools // Debe ser estatica
    {		
        public static RectTransform GetRectTransform(this Transform t) // Igual estática
        {
            return t as RectTransform;
        }

        
    }
}
