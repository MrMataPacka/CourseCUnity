using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course
{
    public class Variables : MonoBehaviour
    {
        // - Modificadores de texto
        // public
        // private

        // - Tipo de Dato
        // int
        // float
        // bool
        // string

        // Tipos de datos (Valor)
        public int MyInt;
        public float MyFloat;
        public double MyDouble;
        public bool MyBool;
        public char MyChar;
        public Vector3 myStructVector;
        public Quaternion myStructQuaternion;

        // Tipos de datos (Referencia)
        public Transform myClassTransform;
        public GameObject myClassGameObject;
        public Variables myClass;

        // - Nombre

        // - Valor por Defecto (Opcional) 

        public string playerName = "Mariano";
        public int age = 27;

        private void Start()
        {
            // Tipos de datos (Valor)
            MyInt = 5;
            MyFloat = 5.2f;
            MyDouble = 0.000000000000001f;
            MyBool = false;
            MyChar = 'a';
            myStructVector = new Vector3(1,2,3);
            myStructQuaternion = new Quaternion(1,2,3,4);

            // Tipos de datos (Referencia)
            myClassTransform = this.transform;
            myClassGameObject = this.gameObject;
            myClass = this;
        }

    }
}
