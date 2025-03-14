using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course.PatronesDiseño.Template
{
    public class Elf : Character
    {
        protected override bool CanAttack()
        {
            if (health >= 30)
            {
                return true;
            }

            Debug.Log("Can't attack, too meak!!!");
            return false;
        }

        protected override void DoAttack()
        {
            // Attack
        }
        protected override void DamageReceived(bool isDead)
        {
            if (isDead)
            {
                // game Over
            }
        }

    }
}
