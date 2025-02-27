using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course
{
    public class Conversion : MonoBehaviour
    {
        


        private void Start()
        {
            //Conversion (Cast)
            int myCastInt = (int)2.55f;

            Collider myCollider = GetComponent<Collider>();
            BoxCollider myBoxCollider;
            myBoxCollider = (BoxCollider)myCollider;
            myBoxCollider = myCollider as BoxCollider;

            //Convesion (Parse)
            string myStringInt = "128";
            int myIntParsed;

            myIntParsed = int.Parse(myStringInt); //Intenta convertir al determinado

            bool resultParse = int.TryParse(myStringInt, out myIntParsed); //Depurar errores


            //Conversion (Enum)
            string myStringEnum = "Fire";

            Attacktype myEnum;

            myEnum = (Attacktype)System.Enum.Parse(typeof(Attacktype), myStringEnum);    


        }
    }
}
