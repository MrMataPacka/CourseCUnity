using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course
{
    public class IfElsse : MonoBehaviour
    {
        public bool canAttack; //If es un si, si se cumple una determinada funci�n hace una parte, sino hace el Else

        private void Attack()
        {
            if (canAttack)
            {
                Debug.Log("Attack!");
            }


            else
            {
                Debug.Log("I can't attack.");
            }

            Debug.Log(canAttack ? "Attack!" : "I can't attack."); //Operador ternario, m�s leible que el if y else arriba

            int id = canAttack ? 24 : -1; //Operador ternario para variables

            if (canAttack)
                Debug.Log("Attack!"); //Si es solo una l�nea de codigo se puede implementar as�

            if (canAttack) Debug.Log("Attack!"); //O igual se puede implementar as�
        }





        public int currentAmmo;
        public int totalAmmo;

        private void CheckAmmo()
        {
            if (currentAmmo > 0)
            {
                //shoot
            }

            if (totalAmmo == 0 || currentAmmo <= 0)
            {
                // Require ammo
            }
        }
        public SphereCollider shieldCollider;

        private void Defense() 
        {
            if (shieldCollider  != null) //No se suele usar porque no esta bien visto, mala practica
            {
                // Use shield
            }

            if (shieldCollider) //Mismo que el anterior, si existe se ejecuta
            {
                // Use shield
            }
        }
    }
}
