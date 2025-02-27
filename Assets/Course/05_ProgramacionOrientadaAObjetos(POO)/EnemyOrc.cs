using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course
{
    public class EnemyOrc : Enemy // Llamas a la clase padre para heredar sus funciones, variables etc...
    {
        public override void Attack() // Llamas a la funcion del padre para sobreescribirla
        {
            damage = 999; 
            base.Attack(); // Se llama a la lógica del padre sin modificacion
            Debug.Log("Im an orc");
        }

        public override void Defense()
        {
            Debug.Log($"Enemy '{Title}' ATTACK. Damage: '{health}'");
        }

        //private void Defense()
        //{
        //    Debug.Log($"Enemy '{_title}' ATTACK. Damage: '{health}'");
        //}
    }
}
