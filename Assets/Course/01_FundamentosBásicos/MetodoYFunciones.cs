using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Course
{
    public class MetodoYFunciones : MonoBehaviour
    {
        MetodoYFunciones myClass;
        private void Start() 
        {
            //Do Something

            Shoot(weaponType: 2);

            int myId;
            myId = GetPlayerId();

            ChangePlayerIdWithOut(out myId); //20

            ChangePlayerIdWithRef(ref myId); //30


        }


        //METODO SE LLAMA DE AFUERA DE LA CLASE
        //FUNCION CUANDO SE LLAMA DESDE ADENTRO DE LA CLASE

        public void Shoot(int amountBullets = 5, int weaponType = 0)
        {
            //Disparar

        }

        private void ChangePlayerIdWithOut(out int id)
        {
            //Do something
            id = 20;
        }

        private void ChangePlayerIdWithRef(ref int id)
        {
            //Do something
            id = 30;
        }


        private int GetPlayerId()
        {
            //Do something
            return 10;
        }

    }
}
