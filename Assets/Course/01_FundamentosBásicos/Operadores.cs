using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course
{


    public class Operadores : MonoBehaviour
    {
        int myInt;
        bool myBool;

        private void Start()
        {
            // Operadores Aritm�ticos
            myInt = 2 + 2;
            myInt = 1 - 1;
            myInt = 2 * 2;
            myInt = 2 / 2;

            // Operadores de Asignaci�n
            myInt += 2;
            myInt -= 2;
            myInt *= 2;
            myInt /= 2;

            // Operadores Relacionales
            myBool = 2 > 1;
            myBool = 2 < 1;
            myBool = 2 == 1;
            myBool = 2 >= 1;
            myBool = 2 <= 1;
            myBool = 2 != 1;

            // Operadores Logicos
            myBool = 2 == 2 || 4 == 4;
            myBool = 2 == 2 && 4 == 4;
            myBool = !(2 == 2);
        }


    }
}
