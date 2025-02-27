using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course
{
    public class SerializedFieldHideInspector : MonoBehaviour
    {
        [SerializeField] //Serializa (toma información para reconstruirlo y utilizarlo desde el editor) una variable privada para usarse en el editor
        private bool canShoot;

        [HideInInspector] // Oculta la variable publica en el editor
        public bool canRun;
    }
}
